using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class CustomLinkedListString : ICustomString
    {
        Node<char> linkedstring = new Node<char>();
        

        public CustomLinkedListString(string instring)
        {
            linkedstring = makeStringNode(ref linkedstring, instring);
        }
        public override string ToString()
        {
            string rebuiltstring = "";
            Node<char> holder = linkedstring;
            while(holder != null)
            {
                rebuiltstring += holder.value.ToString();
                holder = holder.Next;
            }
            return rebuiltstring;
        }
        public void Insert(int start, string insertString)
        {
            char[] stringchar = insertString.ToCharArray();
            int j = 0;
            Node<char> read = linkedstring;
            linkedstring = read;
            Node<char> save = new Node<char>();
            Node<char> savehead = save;
            for (int i = 0; i < start; i++)
            {
                read = read.Next;
            }

            read = read.Next;
            foreach (char i in stringchar)
            {
                save.value = read.value;
                save = save.Next;
                read.value = i;
                if (j < stringchar.Count() - 1)
                {
                    read = read.Next;
                }
                else
                {
                    read.Next = savehead;
                }
                j++;

            }
          

        }
        private Node<char> makeStringNode(ref Node<char> start,string instring)
        {
            Node<char> next = new Node<char>();
            next.value = 'i';
            start = next ;
            char[] temp = instring.ToCharArray();
            foreach (char i in temp)
            {
                next.value = i;
                next = next.Next;
            }
            return start;
        }
        public int Length()
        {
            int size = 0;
            Node<char> node = linkedstring;
            while (node != null)
            {
                node = node.Next;
                size++;
            }
            return size-2;
        }
        public void Remove(int start, int numToRemove)
        {
           
            
            Node<char> read = linkedstring;
            linkedstring = read;
            Node<char> save = new Node<char>();
            Node<char> savehead;
            for (int i = 0; i < start; i++)
            {
                read = read.Next;
            }

         
            save = read.Next;
            for(int j = 0; j < numToRemove; j++)
            {
                save = save.Next;
            }
            savehead = save;
            read.Next = savehead;
                
                
            }
        private Node<char> getToIndex(int start,  ref Node<char> passin)
        {
            Node<char> node = passin;
            for (int i = 0; i < start; i++)
            {
                node = node.Next;
            }
            return node;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            ICustomString otherstring = obj as ICustomString;
            return this.Length().CompareTo(otherstring.Length());
        }
    }
}
