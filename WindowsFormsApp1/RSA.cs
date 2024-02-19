using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RSA
    {
        int n;
        int e;
        int d;
        public RSA() { }
        public int N
        {
            get
            {
                return this.n;
            }
            set
            {
                this.n = value;
            }
        }
        public int E
        {
            get
            {
                return this.e;
            }
            set
            {
                this.e = value;
            }
        }
        public int D
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }
        public int Encrypt(int M)
        {
            return this.Calculate(M, this.e);
        }

        public int Calculate(int startValue, int eksp)
        {
            int retValue = startValue;

            for (int i = 1; i < eksp; i++)
            {
                retValue = (retValue * startValue) % this.n;
            }

            return retValue;
        }

        public int Decrypt(int C)
        {
            return this.Calculate(C, this.d);
        }
        public int GetMinimalDivider(int a, int b)
        {
            if ((a % b) == 0)
            {
                return b;
            }
            else
            {
                a -= b;
                if (a > b)
                    return this.GetMinimalDivider(a, b);
                else
                    return this.GetMinimalDivider(b, a);
            }
        }

        public Bitmap DecryptBMP(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            Bitmap encryptedBmp = new Bitmap(w, h);
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    int bitsR, bitsG, bitsB;
                    bitsR = System.Convert.ToInt32(r);
                    bitsG = System.Convert.ToInt32(g);
                    bitsB = System.Convert.ToInt32(b);

                    bitsR= Decrypt(bitsR);
                    bitsG = Decrypt(bitsG);
                    bitsB = Decrypt(bitsB);
                   
                    byte rNew = (byte)bitsR;
                    byte gNew = (byte)bitsG;
                    byte bNew = (byte)bitsB;
                    encryptedBmp.SetPixel(x, y, Color.FromArgb(rNew, gNew, bNew));
                }
            }
            return encryptedBmp;
        }
        public Bitmap EncryptBMP(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            Bitmap encryptedBmp=new Bitmap(w,h);
            for (int x = 0; x < w; x++)
            {
                for(int y = 0; y < h; y++)
                {

                    Color pixel = bmp.GetPixel(x, y);
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    int bitsR, bitsG, bitsB;
                    bitsR = System.Convert.ToInt32(r);
                    bitsG = System.Convert.ToInt32(g);
                    bitsB = System.Convert.ToInt32(b);

                    bitsR = Encrypt(bitsR);

                    bitsG = Encrypt(bitsG);

                    bitsB = Encrypt(bitsB);

                    byte rNew = (byte)bitsR;
                    byte gNew = (byte)bitsG;
                    byte bNew = (byte)bitsB;
                    encryptedBmp.SetPixel(x, y, Color.FromArgb(rNew, gNew, bNew));
                }
            }
            return encryptedBmp;
        }


    }
}
