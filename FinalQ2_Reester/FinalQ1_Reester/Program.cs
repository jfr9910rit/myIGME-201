using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ1_Reester
{
    internal class Program
    {
        private List<int> list = new List<int>();

        public void Push(int n)
        {
            list.Add(n);
        }

        public int Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int lastIndex = list.Count - 1;
            int lastItem = list[lastIndex];
            list.RemoveAt(lastIndex);
            return lastItem;
        }

        public int Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return list[list.Count - 1];
        }
    }
}
