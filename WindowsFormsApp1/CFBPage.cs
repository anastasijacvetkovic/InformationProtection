using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CFBPage : Form
    {
        private OpenFileDialog openFileDialog1;

        
    public CFBPage()
        {
            InitializeComponent();
        }

        private void a51ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A51Page a51 = new A51Page();
            a51.ShowDialog();
        }

        private void playfairCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairCipherPage pcp = new PlayfairCipherPage();
            pcp.ShowDialog();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAPage rsa = new RSAPage();
            rsa.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCFBUploadFile_Click(object sender, EventArgs e)
        {
            //Izaberite fajl dugme
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName); ;
            }
        }

        private void btnCFBSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, tbCFBResult.Text);
            }
        }

        private void btnCFBEncrypt_Click(object sender, EventArgs e)
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(tbCFBKey.Text);
            int[] bitsKey = new int[byteKey.Length * 8];
            int i = 0;
            while (i < byteKey.Length)
            {
                int j = 7;
                while (j >= 0)
                {
                    bitsKey[i * 8 + (7 - j)] = (byteKey[i] >> j) & 1;
                    j--;
                }
                i++;
            }
            A51 a51 = new A51(bitsKey);
            byte[] ivByte = Encoding.ASCII.GetBytes(tbIV.Text);
            CFB cfb = new CFB(bitsKey, 8, ivByte);
            byte[] byteSource = Encoding.ASCII.GetBytes(textBox1.Text);
            byte[] byteOutput = cfb.Encrypt(byteSource);
            tbCFBResult.Text = System.Text.Encoding.ASCII.GetString(byteOutput);
        }

        private void tbIV_TextChanged(object sender, EventArgs e)
        {

        }

        private void CFBPage_Load(object sender, EventArgs e)
        {
            char[] keyChar = tbCFBKey.Text.ToCharArray();
            int[] key = new int[keyChar.Length];
            for (int i = 0; i < keyChar.Length; i++)
            {
                key[i] = int.Parse(keyChar[i].ToString());
            }
            CFB cfb = new CFB(key, 8);
            tbIV.Text = cfb.getStringCFB(cfb.IV);
        }
       
        private void tbCFBKey_TextChanged(object sender, EventArgs e)
        {
            if (tbCFBKey.TextLength == 64)
            {
                char[] keyChar = tbCFBKey.Text.ToCharArray();
                int[] key = new int[keyChar.Length];
                for (int i = 0; i < keyChar.Length; i++)
                {
                    key[i] = int.Parse(keyChar[i].ToString());
                }
                CFB cfb = new CFB(key, 8);

                tbIV.Text = cfb.getStringCFB(cfb.IV);
            }
           
        }

        private void btnCFBDecrypt_Click(object sender, EventArgs e)
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(tbCFBKey.Text);
            int[] bitsKey = new int[byteKey.Length * 8];
            int i = 0;
            while (i < byteKey.Length)
            {
                int j = 7;
                while (j >= 0)
                {
                    bitsKey[i * 8 + (7 - j)] = (byteKey[i] >> j) & 1;
                    j--;
                }
                i++;
            }
            A51 a51 = new A51(bitsKey);
            byte[] ivByte = Encoding.ASCII.GetBytes(tbIV.Text);
            CFB cfb = new CFB(bitsKey, 8,ivByte);
            byte[] byteSource = Encoding.ASCII.GetBytes(tbCFBResult.Text);
            byte[] byteOutput = cfb.Decrypt(byteSource);
            tbCFBResult.Text = System.Text.Encoding.ASCII.GetString(byteOutput);
        }

        private void tbCFBResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHA256Pagecs sha = new SHA256Pagecs();
            sha.ShowDialog();
        }
    }
}
