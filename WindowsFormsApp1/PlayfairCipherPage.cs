using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PlayfairCipherPage : Form
    {
        public PlayfairCipherPage()
        {
            InitializeComponent();
        }

        private void playfairCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A51Page a51 = new A51Page();
            a51.ShowDialog();
        }

        private void btnPCEncrypt_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string plainText = textBox2.Text;
            PlayfairCipher pc = new PlayfairCipher(key,plainText);
            textBox3.Text = pc.Encrypt();
        }

        private void btnPCDecrpyt_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string plainText = textBox3.Text;
            PlayfairCipher pc = new PlayfairCipher(key, plainText);
            textBox3.Text = pc.Decrypt();
        }

        private void cFBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFBPage cfb = new CFBPage();
            cfb.ShowDialog();
        }

        private void PlayfairCipherPage_Load(object sender, EventArgs e)
        {

        }

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHA256Pagecs sha = new SHA256Pagecs();
            sha.ShowDialog();
        }
    }
}
