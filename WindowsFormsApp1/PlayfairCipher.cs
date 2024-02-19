using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PlayfairCipher
    {
        private char[,] keySquare;
        private int keySquareSize;
        private string key;
        private string plainText;
        public PlayfairCipher(string key,string pt)
        {
            this.key = key;
            this.plainText = pt;
            keySquareSize = 5;
            keySquare = new char[keySquareSize, keySquareSize];
            generateKeyTable(key);
        }
        public string Key { get { return this.key; } set { this.key = value; } }
        public string PlainText { get { return this.plainText; } set { this.plainText = value; } }
        public char[,] KeySquare
        {
            get { return this.keySquare; }
            set { this.keySquare = value; }
        }
        public void generateKeyTable(string key)
        {
            this.keySquare = new char[keySquareSize, keySquareSize];
            string defaultKeySquare = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string tempKey = key.ToUpper();
            tempKey = tempKey.Replace("J", "I");
            for (int i = 0; i < tempKey.Length-1; i++)
            {
                for (int j = i + 1; j < tempKey.Length; j++)
                {
                    if (tempKey[i] == tempKey[j])
                    {
                        tempKey = tempKey.Remove(j, 1);
                    }
                }
                if (defaultKeySquare.Contains(tempKey[i]) == true)
                {
                    int index = defaultKeySquare.IndexOf(tempKey[i]);
                    defaultKeySquare = defaultKeySquare.Remove(index,1);
                }
            }
            if (defaultKeySquare.Contains(tempKey[tempKey.Length - 1]))
            {
                int index = defaultKeySquare.IndexOf(tempKey[tempKey.Length-1]);
                defaultKeySquare = defaultKeySquare.Remove(index, 1);
            }
            tempKey += defaultKeySquare;
            int br = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    KeySquare[i, j] = tempKey[br++];
                }
            }
        }

        public string[] dividePlainText(string plainText)
        {
            plainText = plainText.ToUpper();
            if (plainText.Length % 2 == 1)
            {
                plainText += "Z";
            }
            string[] result = new string[plainText.Length / 2];
            int i = 0;
            int br = 0;
            while (i < plainText.Length - 1)
            {
                if (plainText[i] == plainText[i + 1])
                {
                    string pom = "";
                    pom += plainText[i];
                    pom += "X";
                    result[br++] = pom;
                    i++;
                }
                else
                {
                    string pom = "";
                    pom += plainText[i];
                    pom += plainText[i + 1];
                    result[br++] = pom;
                    i += 2;
                }
            }
            return result;
        }

        public string Decrypt() {
            string[] result=dividePlainText(this.plainText);
            string pom = "";
            for(int i = 0; i < result.Length; i++)
            {
                int i1=0,j2=0, i2=0,j1=0;
                for(int j = 0; j < 5; j++)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        if (result[i][0] == keySquare[j, k])
                        {
                            i1 = j;
                            j1 = k;
                        }
                        if (result[i][1] == keySquare[j, k])
                        {
                            i2 = j;
                            j2 = k;
                        }
                    }
                }
                if (j2 == j1)
                {
                    if (i1 == 0)
                    {
                        pom += keySquare[4, j1];
                    }
                    else pom += keySquare[i1 -1, j1];
                    if (i2 == 0)
                    {
                        pom += keySquare[4, j2];
                    }
                    else pom += keySquare[i2 - 1, j2];
                }
                else if (i1 == i2)
                {
                    if (j1 == 0)
                    {
                        pom += keySquare[i1, 4];
                    }
                    else pom += keySquare[i1, j1 - 1];
                    if (j2 == 0)
                    {
                        pom += keySquare[i2, 4];
                    }
                    else pom += keySquare[i2, j2 - 1];


                }
                else
                {
                    pom += keySquare[i1, j2];
                    pom += keySquare[i2, j1];
                }
            }
            return pom;
        }
        public string Encrypt()
        {
            string[] result = dividePlainText(this.plainText);
            string pom = "";
            for (int i = 0; i < result.Length; i++)
            {
                int i1 = 0, j2 = 0, i2 = 0, j1 = 0;
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (result[i][0] == keySquare[j, k])
                        {
                            i1 = j;
                            j1 = k;
                        }
                        if (result[i][1] == keySquare[j, k])
                        {
                            i2 = j;
                            j2 = k;
                        }
                    }
                }
                if (j2 == j1)
                {
                    if (i1 == 4)
                    {
                        pom += keySquare[0, j1];
                    }
                    else pom += keySquare[i1 + 1, j1];
                    if (i2 == 4)
                    {
                        pom += keySquare[0, j2];
                    }
                    else pom += keySquare[i2 + 1, j2];
                }
                else if (i1 == i2)
                {
                    if (j1 == 4)
                    {
                        pom += keySquare[i1, 0];
                    }
                    else pom += keySquare[i1, j1 + 1];
                    if (j2 == 4)
                    {
                        pom += keySquare[i2, 0];
                    }
                    else pom += keySquare[i2, j2 + 1];


                }
                else
                {
                    pom += keySquare[i1, j2];
                    pom += keySquare[i2, j1];
                }
            }
            return pom;
           
        }
    }
}

