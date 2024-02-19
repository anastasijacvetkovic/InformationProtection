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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
