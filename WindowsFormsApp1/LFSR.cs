using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LFSR
    {
        public LFSR() { }
        private int[] register;
        private int[] opMembers;
        public int[] Register
        {
            get { return this.register; }
            set { this.register = value; }
        }
        public int[] OperationMembers
        {
            get{return this.opMembers;}
            set{this.opMembers = value;}
        }
        public int Shift(int newEntry)
        {
            if (this.register.Length == 0) return 2;
            int[] reg = register;
            int ret = this.register[this.register.Length-1];
            for(int i = this.register.Length - 1; i > 0; i--)
            {
                reg[i] = this.register[i - 1];
            }
            reg[0] = newEntry;
            register = reg;
            return ret;
        }
        public int Output
        {
            get
            {
                return this.register[this.register.Length - 1];
            }
        }
    }
}
