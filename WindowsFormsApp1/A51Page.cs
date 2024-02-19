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
    public partial class A51Page : Form
    {
        private OpenFileDialog openFileDialog1;

        public A51Page()
        {
            InitializeComponent();
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Kriptuj dugme
            //char[] keyChar = tbKeyA51.Text.ToCharArray();
            //int[] key = new int[keyChar.Length];
            //for (int i = 0; i < keyChar.Length; i++)
            //{
            //    key[i] = int.Parse(keyChar[i].ToString());
            //}
            byte[] byteKey = Encoding.ASCII.GetBytes(tbKeyA51.Text);
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

            char[] sourceChar = tbMessage.Text.ToCharArray();
            byte[] byteSource = Encoding.ASCII.GetBytes(tbMessage.Text);

            byte[] byteOutput = a51.Encrypt(byteSource);

            tbResultA51.Text = System.Text.Encoding.ASCII.GetString(byteOutput);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Izaberite fajl dugme
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbMessage.Text = File.ReadAllText(openFileDialog1.FileName); ;
            }

        }

        private void tbKeyA51_TextChanged(object sender, EventArgs e)
        {

        }

        private void playfairCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairCipherPage pcp = new PlayfairCipherPage();
            pcp.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(tbKeyA51.Text);
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
            byte[] byteSource = Encoding.ASCII.GetBytes(tbResultA51.Text);
            byte[] byteOutput = a51.Decrypt(byteSource);

            tbResultA51.Text = Encoding.ASCII.GetString(byteOutput);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, tbResultA51.Text);
            }
        }

        private void cFBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFBPage cfb = new CFBPage();
            cfb.ShowDialog();
        }

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHA256Pagecs sha = new SHA256Pagecs();
            sha.ShowDialog();
        }
    }
}
