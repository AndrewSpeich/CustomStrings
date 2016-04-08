using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStrings
{
    class Node<T> 
    {
        T storage;
        Node<T> next;
        public Node()
        {
            
        }
        public T value
        {
            get { return storage; }
            set { this.storage = value;
                if (next == null) { next = new Node<T>(); }
                }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
           
        }

     
    }
}
