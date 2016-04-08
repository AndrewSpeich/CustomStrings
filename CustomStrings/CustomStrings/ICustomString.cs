using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    interface ICustomString : IComparable
    {
        string ToString();

        void Insert(int start,string insertString);

        void Remove(int start, int numToRemove);

        int Length();
        new int CompareTo(object obj);
        


    }
}
