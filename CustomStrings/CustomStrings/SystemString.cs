using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class SystemString : ICustomString
    {
        string normalstring;

        public SystemString(string instring)
        {
            normalstring = instring;
        }
        public override string ToString()
        {
            return normalstring.ToString();
        }
        public void Insert(int start, string insertString)
        {
           normalstring = normalstring.Insert(start, insertString);
        }

        public int Length()
        {
            return normalstring.Count();
        }

        public void Remove(int start, int numToRemove)
        {
           normalstring = normalstring.Remove(start, numToRemove);
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ICustomString otherstring = obj as ICustomString;
            return this.Length().CompareTo(otherstring.Length());
        }
    }
}
