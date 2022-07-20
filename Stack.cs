using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Stack
    {
        public int top_idx;
        public int[] arr;
        public int size;
        public Stack(int size)//emptey array of  size
        {
            arr = new int[size];
            top_idx = 0;//first element index to be add to array
        }
        public void Push(int no) 
        {
            if (top_idx < size )
                Console.WriteLine("the srack is full");
            arr[top_idx] = no;
            top_idx++;//go to the next elemnt index
        }

        public int Pop()
        {
            if (top_idx < 0)
                Console.WriteLine("the srack is empty");
            Console.WriteLine(arr[top_idx-1]);//-1 due to increase by one in index by last push    
            return arr[top_idx-1];
            
        }

        public int Peek()
        {
            if (top_idx <= 0)
                Console.WriteLine("the srack is empty");
            
            Console.WriteLine(arr[top_idx - 1]);
            return arr[top_idx - 1];
        }

        public void printStack()
        {
            while (top_idx > 0)
            {
                Console.WriteLine(arr[top_idx - 1]);
                top_idx--;
            }
        }

    }
}
