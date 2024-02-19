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
    public partial class SHA256Pagecs : Form
    {
        SHA256 sha = new SHA256();
        private OpenFileDialog openFileDialog1;

        public SHA256Pagecs()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void a51ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A51Page a51 = new A51Page();
            a51.ShowDialog();
        }

        private void cFBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFBPage cfb = new CFBPage();
            cfb.ShowDialog();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAPage rsa = new RSAPage();
            rsa.ShowDialog();
        }

        private void playfairCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayfairCipherPage pcp = new PlayfairCipherPage();
            pcp.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] randombits = new int[64];
            Random rnd = new Random();
            for(int i = 0; i < 64; i++)
            {
                randombits[i] = rnd.Next(0, 2);
            }
            string key="";
            for(int i =0;i<64;i++)
            {
                key += randombits[i];
                
            }
            tbSHA256Key.Text = key;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string plaintext = textBox1.Text;
            label8.Text = sha.ComputeHash(plaintext);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(tbSHA256Key.Text);
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
            byte[] byteSource = Encoding.ASCII.GetBytes(textBox1.Text);

            byte[] byteOutput = a51.Encrypt(byteSource);

            textBox3.Text = System.Text.Encoding.ASCII.GetString(byteOutput);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] byteKey = Encoding.ASCII.GetBytes(tbSHA256Key.Text);
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
            byte[] byteSource = Encoding.ASCII.GetBytes(textBox3.Text);

            byte[] byteOutput = a51.Encrypt(byteSource);

            textBox4.Text = System.Text.Encoding.ASCII.GetString(byteOutput);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string plaintext = textBox4.Text;
            label9.Text = sha.ComputeHash(plaintext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Izaberite fajl dugme
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBox4.Text);
            }
        }
    }
}
