using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class Program
    {
        //Create a System.Collections.SortedList, SortedList<ICustomString> sortedStringList, 
        //    sorted by the length of each string element, populated by a mix of each of the ICustomString subclasses
        static void Main(string[] args)
        {
            

            SortedList<ICustomString, int> stringlist = new SortedList<ICustomString, int>();
            SystemString pew = new SystemString("Pew Pew Pew");
            SystemArrayString pow = new SystemArrayString("Pow");
            SystemLinkedListString paw = new SystemLinkedListString("paw");
            CustomLinkedListString poh = new CustomLinkedListString("abcd");
            pew.Insert(4, "moo");
            pew.Remove(7, 3);
            Console.WriteLine(pew + " " + pew.Length().ToString());
            pow.Insert(2, "om");
            Console.WriteLine(pow + " " + pow.Length().ToString());
            pow.Remove(1, 1);
            Console.WriteLine(pow + " " + pow.Length().ToString());
            paw.Insert(3, "t");
            paw.Remove(3, 1);
            Console.WriteLine(paw + " " + paw.Length().ToString());
            poh.Insert(1, "xxx");
            Console.WriteLine(poh + " " + poh.Length());
            poh.Remove(3, 1);
            Console.WriteLine(poh + " " + poh.Length());

            stringlist.Add(pew, pew.Length());
            stringlist.Add(pow, pow.Length());
            stringlist.Add(paw, paw.Length());
            stringlist.Add(poh, poh.Length());
           
            foreach (KeyValuePair<ICustomString, int> i in stringlist)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();

        }
    }
    internal class comparater : IComparer<ICustomString>
    {
        public int Compare(ICustomString x, ICustomString y)
        {
            int result = 0;

            result = (x.Length() < y.Length()) ?  x.Length() : y.Length();

            result = (result == 0) ?  x.Length() : x.Length() ; 


            return result;
        }
    }
}
