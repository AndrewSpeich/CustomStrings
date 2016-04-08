using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class SystemArrayString : ICustomString
    {
        char[] strings;
        
        public SystemArrayString(string instring)
        {
            strings = instring.ToCharArray();
        }
        public override string ToString()
        {
            string stringed = "" ;
            foreach(char i in strings)
            {
                stringed += i.ToString();
            }
            return stringed;
        }
        public void Insert(int start , string insertString)
        {
            int size = strings.Count() + insertString.Count();
            char[] temp = strings;
            strings = new char[size];

            for(int i = 0; i<strings.Length;i++)
            {
                if(i >= start && i < (start + insertString.Length))
                {

                    strings[i] = insertString.ToCharArray()[i - start];
                }
                else
                {
                    int modi = i;
                    if (i > start)
                    {
                        modi = i - start;
                    }
                    strings[i] = temp[modi];
                }
            }

        }

        public int Length()
        {
            return strings.Length;
        }

        public void Remove(int start, int numToRemove)
        {
            
            int endindex = strings.Length - numToRemove;
           for(int i = 0; i< strings.Length ; i++)
            {
                if(i>= start && i+numToRemove<strings.Length)
                {
                int removeindex = i ;
                strings[removeindex] = strings[removeindex + numToRemove];
                }
            }
            char[] temp = new char[endindex];
            for(int i = 0; i < endindex && i<strings.Length; i++)
            {
                temp[i] = strings[i];
            }
            strings = temp;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ICustomString otherstring = obj as ICustomString;
            if (this.Length()!=otherstring.Length()) { return this.Length() - otherstring.Length(); }
            return 1;
        }
    }
}
