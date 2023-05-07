using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ1_Reester
{
    class MyQueue
    {
        private List<int> elements;

        public MyQueue()
        {
            elements = new List<int>();
        }

        public void Enqueue(int n)
        {
            elements.Add(n);
        }

        public int Dequeue()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int firstElement = elements[0];
            elements.RemoveAt(0);
            return firstElement;
        }

        public int Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return elements[0];
        }
    }

}

