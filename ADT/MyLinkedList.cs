using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class MyLinkedList
    {
        private class Node
        {
            public Object Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(Object data)
            {
                Data = data;
            }

        }
        public int Count { get; private set; }
        private Node Head;
        private Node Tail { get; set; }
        public void Insert(Object data)
        {
            Node n = new Node(data);
           
            if (Count ==0)
            {
                Head = n;
                n.Next = Tail;
                Tail = n;
                Count++;
            }
            else
            {
                Tail.Next =  n;
                n.Prev = Tail;
                Tail = n;      
               

                Count++;
            }
        }
        
        
        public void Insert(Object data, int index)
        {
            if (index > Count) index = Count;
            if (index <= 0) Insert(data);
            else
            {
                Node position = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                Node n = new Node(data);
                n.Next = position.Next;
                position.Next = n;
                Count++;
            }
        }
        public void Delete()
        {
            if (Count > 0)
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void Delete(int index)
        {
            if (index > Count) index = Count;
            if (index <= 0) Delete();
            else
            {
                Node position = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                position.Next = position.Next.Next;
                Count--;
            }
        }
        public void Reverse()
        {

        }
        public void Swap(int index)
        {

        }
        public string FremTilbage()
        {
            return null;
        }
        public Object ItemAt(int index)
        {
            Object result = null;
            if (index < Count && index >= 0)
            {
                Node position = Head;
                for (int i = 0; i < index; i++)
                {
                    position = position.Next;
                }
                result = position.Data;
            }
            return result;
        }


        public override string ToString()
        {
            string toString = $"{Head.Data.ToString()}\n";

            for (int i = 1; i < Count; i++)
            {
                toString = toString + $"{Tail.Data.ToString()}\n";
            }
        

            return toString;
        }


    }

}
