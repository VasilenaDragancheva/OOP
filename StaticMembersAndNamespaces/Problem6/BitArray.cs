using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem6
{
    class BitArray
    {
        private const int MAX_LENGTH = 100000;
        private const int MIN_LENGTH = 1;
        private int length;
        private int[] bits;

        public BitArray(int length)
        {
            this.Length = length;

        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > MAX_LENGTH||value<MIN_LENGTH)
                {
                    throw new ArgumentOutOfRangeException("Max length is in range of 1 to 100 000 elements.");
                }
                this.length = value;
                this.bits = new int[this.Length];
            }
            
        }

        private BigInteger GetDecimalValue()
        {
            BigInteger result = 0;
            for (int i = 0; i < this.bits.Length; i++)
            {
                int currBit = this.bits[i];
                BigInteger n=0;
                if(currBit==1)
                {
                    n=1;
                    for (int j = 0; j < i; j++)
                    {
                        n *= 2;
                    }
                }
                result += n;
            }
            return result;

        }
        
        public int this[int index]
        {
            get
            {
                if(index>=this.Length||index<0)
                {
                    throw new IndexOutOfRangeException("Index is outside boundries of BitArray");
                }
                return this.bits[index];
            }
            set
            {
                if(index>=this.Length||index<0)
                {
                    throw new IndexOutOfRangeException("Index is outside boundries of BitArray");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Bit value can be only 0 or 1");
                }
                this.bits[index] = value;
            }
        }

        public override string ToString()
        {
            return this.GetDecimalValue().ToString();
        }
       
    }
}
