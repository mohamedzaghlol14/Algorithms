using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class FindSmalest
    {
        public static int Sort(int[] myarray)
        {
            int minidx = myarray[0];

            foreach (int item in myarray)
            {
                if (minidx < item)
                    minidx = item;
                    myarray[0] = minidx;

            }

            return minidx;
        }

      
    }
}
