using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class StringDisperser:ICloneable,IComparable<StringDisperser>,IEnumerable<StringDisperser>
    {
       private List<string> words;
        public StringDisperser(params string[] input)
        {
            this.words = new List<string>();
        }

        private void AddInput(string[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentNullException("There are no input words");
            }
            if (input.All(word => word == null))
            {
                throw new ArgumentNullException("There are no input words different from null");
            }
            this.words = new List<string>();
            words.AddRange(input);
        }
        public List<String> Words { get { return this.words; } }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} consists of :{1}",this.GetType().Name,Environment.NewLine);
            foreach (var word in this.words)
            {
                result.AppendFormat("{0} {1}", word, Environment.NewLine);
            }
            return result.ToString();
        }
        public override int GetHashCode()
        {
            return this.words[0].GetHashCode() ^ this.words.Count();
        }
        public override bool Equals(object obj)
        {
            //equal if same strings in same order
              StringDisperser other=obj as StringDisperser;
            if(obj==null)
            {
                return false;
            }
            if(other.Words.Count()!=this.Words.Count())
            {
                return false;
            }
            for (int i = 0; i < this.Words.Count(); i++)
            {
                if(other.Words[i]!=this.Words[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator ==(StringDisperser a,StringDisperser b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !a.Equals(b);
        }

        public object Clone()
        {
            List<string> clonedWords=new List<string>(this.Words);
            StringDisperser cloned = new StringDisperser(clonedWords.ToArray());
            return cloned;
        }
       


        public int CompareTo(StringDisperser other)
        {
            string thisTotalValue = this.TotalStringValue();
            string otherTotalValue = this.TotalStringValue();
            return thisTotalValue.CompareTo(otherTotalValue);
        }
        
        private string TotalStringValue()
        {
            StringBuilder result = new StringBuilder();
            foreach (var word in this.Words)
            {
                result.Append(word);

            }
            return result.ToString();
        }



        public IEnumerator<StringDisperser> IEnumerable<StringDisperser>.GetEnumerator()
        {
            string totalValue = this.TotalStringValue();
            for (int i = 0; i < totalValue.Length; i++)
            {
                char symbol = totalValue[i];
                yield return 
            }
        }
    }
}
