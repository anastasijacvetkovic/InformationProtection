using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RSAPage : Form
    {
        private OpenFileDialog openFileDialog1;
		RSA rsa=new RSA();

		public RSAPage()
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

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
			int p = Convert.ToInt32(this.tbP.Text);
			int q = Convert.ToInt32(this.tbQ.Text);
			int rsaN = p * q;
			
			this.tbN.Text = (rsaN).ToString();

			int rsaE = 1;

			try
			{
				rsaE = Convert.ToInt32(this.tbE.Text);
			}
			catch
			{
				rsaE = 1;
			}

			if (rsaE == 1 || rsa.GetMinimalDivider((p - 1) * (q - 1), rsaE) > 1)
			{
				if (rsaE == 1)
					rsaE = 3;
				while (rsa.GetMinimalDivider((p - 1) * (q - 1), rsaE) > 1)
				{
					rsaE++;
				}
			}

			this.tbE.Text = rsaE.ToString();
			int rsaD = 1;

			while ((rsaD * rsaE) % ((p - 1) * (q - 1)) != 1)
			{
				rsaD++;
			}
			this.tbD.Text = rsaD.ToString();
			rsa.N = System.Convert.ToInt32(this.tbN.Text);
			rsa.E = System.Convert.ToInt32(this.tbE.Text);
			rsa.D = System.Convert.ToInt32(this.tbD.Text);	
		}

        private void button2_Click(object sender, EventArgs e)
        {
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(this.tbMessage.Text);
			
			string outstr = "";
			foreach (byte b in inputBytes)
			{
				int res = rsa.Encrypt(b);
				outstr += res.ToString() + " ";
			}
			this.tbResult.Text = outstr;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			string[] codes = this.tbResult.Text.Split(' ');
			
			string output = "";
			foreach (string s in codes)
			{
				int C = 0;
				try
				{
					C = System.Convert.ToInt32(s);
				}
				catch
				{
					C = 1;
				}
				C = rsa.Decrypt(C);
				output += System.Convert.ToChar(C);
			}
			this.tbResult.Text = output;
		}

        private void btnUploadFileRSA_Click(object sender, EventArgs e)
        {
			openFileDialog1 = new OpenFileDialog();
			
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string ext = Path.GetExtension(openFileDialog1.FileName);
                if (ext == ".bin") {
				byte[] bytes= File.ReadAllBytes(openFileDialog1.FileName);
					tbMessage.Text = System.Text.Encoding.ASCII.GetString(bytes);
				}
                if (ext == ".txt") { tbMessage.Text = File.ReadAllText(openFileDialog1.FileName); }
                if (ext == ".bmp")
                {
					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
			}
		}

        private void btnSaveFileRSA_Click(object sender, EventArgs e)
        {
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				File.WriteAllText(fileName, tbResult.Text);
			}
		}

        private void RSAPage_Load(object sender, EventArgs e)
        {

        }

        private void cFBToolStripMenuItem_Click(object sender, EventArgs e)
        {
			CFBPage cfb = new CFBPage();
			cfb.ShowDialog();
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Bitmap bmp = (Bitmap)pictureBox1.Image;
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.Image= rsa.EncryptBMP(bmp);
			bmp =rsa.EncryptBMP(bmp);
			bmp.Save("Zastita"+DateTime.Now.Ticks+".bmp");
		}

        private void button4_Click(object sender, EventArgs e)
        {
			Bitmap bmp = (Bitmap)pictureBox2.Image;
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.Image = rsa.DecryptBMP(bmp);
			bmp = rsa.DecryptBMP(bmp);
			bmp.Save("Zastita" + DateTime.Now.Ticks+".bmp");
		}

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SHA256Pagecs sha = new SHA256Pagecs();
			sha.ShowDialog();
		}
    }
}
