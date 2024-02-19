using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CFB
    {
        int blockSize;
        byte[] iv=new byte[64];
        A51 a51;
        public CFB(int[] key,int bs)
        {
            a51 = new A51(key);
            Random rnd = new Random();
            rnd.NextBytes(iv);
            
            this.blockSize = bs;
        }
        public CFB(int[] key,int bs,byte[] iVector)
        {
            a51 = new A51(key);
            this.iv = iVector;
            this.blockSize = bs;
        }
        public int BlockSize
        {
            get { return this.blockSize; }
            set { this.blockSize = value; }
        }
        public byte[] IV
        {
            get { return this.iv; }
            set { this.iv = value; }
        }
        public A51 A51
        {
            get { return this.a51; }
            set { this.a51 = value; }
        }
        public byte[] Encrypt(byte[] message)
        {
            int l = message.Length;
            int[] bits = new int[l*8];
            int[] cipherText = new int[l*8];
            for (int i = 0; i < l; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bits[i * 8 + (7 - j)] = (message[i] >> j) & 1;
                }
            }
            byte[] ivEncrypted = new byte[iv.Length];
            ivEncrypted = a51.Encrypt(iv);
            int[] ivEBits = new int[ivEncrypted.Length * 8];

            for (int i = 0; i < ivEncrypted.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    ivEBits[i * 8 + (7 - j)] = (ivEncrypted[i] >> j) & 1;
                }
            }
            for (int i = 0; i < bits.Length; i+=blockSize*8)
            {
                for(int j = 0; j < blockSize*8; j++)
                {
                    if (i + j < bits.Length) {
                        cipherText[i + j] = ivEBits[j+i] ^ bits[i + j];
                        ivEBits[j] = cipherText[i + j];
                    }
                   
                }
            }
            byte[] resCipher = new byte[cipherText.Length / 8];
            for (int p = 0; p < cipherText.Length; p += 8)
            {
               cipherText[p] = 0;
            }
            for (int i = 0; i < resCipher.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    resCipher[i] |= (byte)(cipherText[i * 8 + (7 - j)] << j);

                }
            }
            return resCipher;
        }
        public byte[] Decrypt(byte[] message)
        {
            return this.Encrypt(message);
        }
        public string getStringCFB(byte[] iv)
        {
            string textIV="";
            int[] bits = new int[iv.Length * 8];
            for (int i = 0; i < iv.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bits[i * 8 + (7 - j)] = (iv[i] >> j) & 1;
                }
            }
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0) textIV += "0";
                else if(bits[i]==1) textIV += "1";
            }
            return textIV;
        }
    }
}
