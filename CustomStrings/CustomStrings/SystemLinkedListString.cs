using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class SystemLinkedListString : ICustomString

    {
        LinkedList<char> linkedstring;
        
        public SystemLinkedListString(string instring)
        {
            linkedstring = makelinkedstring(instring);
        }
        public override string ToString()
        {
            string rebuildstring = "";
            foreach(char i in linkedstring)
            {
                rebuildstring += i.ToString();
            }
            return rebuildstring;
        }
        public void Insert(int start , string insertString)
        {

            char[] insert = insertString.ToCharArray();
            LinkedListNode<char> insertstart = getNode(start);
            foreach(char i  in insert)
            {
                linkedstring.AddAfter(insertstart, i);
            }

        }
        private LinkedList<char> makelinkedstring(string instring)
        {
            LinkedList<char> temp = new LinkedList<char>();
            foreach(char i in instring)
            {
                temp.AddLast(i);
            }
            return temp;
          
        }

        public int Length()
        {
           return linkedstring.Count;
        }

        public void Remove(int start, int numToRemove)
        {
            for (int i = 0; i < numToRemove; i++)
            {
                linkedstring.Remove(getNode(start));
            }

        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ICustomString otherstring = obj as ICustomString;
            return this.Length().CompareTo(otherstring.Length());
        }



        private LinkedListNode<char> getNode(int start)
        {
            LinkedListNode<char> temp = linkedstring.First;
            for (int j = 0; j < start-1; j++)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
}
