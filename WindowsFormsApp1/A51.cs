using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class A51
    {
        public LFSR X = new LFSR();
        public LFSR Y = new LFSR();
        public LFSR Z = new LFSR();
        private int[] key;
        public int[] Key
        {
            get { return this.key; }
            set
            {
                this.key = value;
                int[] pomX = new int[19];
                int i = 0;
                while (i < 19)
                {
                    pomX[i]= key[i];
                    i++;
                }
                X.Register = pomX;
                int[] pomY = new int[22];
                while (i < 41)
                {
                    pomY[i-19] = key[i];
                    i++;
                }
                Y.Register = pomY;
                int[] pomZ = new int[23];
                while (i < 64)
                {
                    pomZ[i-41] = key[i];
                    i++;
                }
                Z.Register = pomZ;
            }
        }
        public A51()
        {
            X.OperationMembers = new int[] { 13, 16, 17, 18 };
            Y.OperationMembers = new int[] { 20,21 };
            Z.OperationMembers = new int[] { 7,20,21,22};
        }
        public A51(int[] newKey) : this()
        {
            this.Key = newKey;
        }
        public void RegisterSteps(LFSR r)
        {
            int t=0;
            foreach(int index in r.OperationMembers)
            {
                t = t ^ r.Register[index];
            }
            r.Shift(t);
        }
        public int MajorityVote()
        {
            int sum = X.Register[8];
            sum += Y.Register[10];
            sum += Z.Register[10];
            if (sum > 1) return 1;
            else return 0;
        }
        public byte[] Encrypt(byte[] source)
        {

            int[] input = new int[8];
            int byteLen = source.Length;
            int[] cryptOutput = new int[8];
            // byte[] byteInFile = new byte[byteLen];
            int[] bits = new int[source.Length * 8];
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bits[i * 8 + (7 - j)] = (source[i] >> j) & 1;
                }
            }
            int[] outP = new int[bits.Length];
            int y = 0;
            foreach (int i in bits)
            {
                int m = MajorityVote();
                if (X.Register[8] == m)
                    RegisterSteps(X);
                if (Y.Register[10] == m)
                    RegisterSteps(Y);
                if (Z.Register[10] == m)
                    RegisterSteps(Z);

                int s = 0;
                s ^=X.Output;
                s ^=Y.Output;
                s ^=Z.Output;

                outP[y] = s^i;
                y++;
            }
            byte[] bytes = new byte[outP.Length / 8];
            for (int p = 0; p < outP.Length; p += 8)
            {
                outP[p] = 0;
            }
            for (int i = 0; i < bytes.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bytes[i] |= (byte)(outP[i * 8 + (7 - j)] << j);

                }
            }
            return bytes;
        }

        public byte[] Decrypt(byte[] source)
        {
            return this.Encrypt(source);
        }
    }
}
