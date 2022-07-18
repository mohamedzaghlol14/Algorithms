using System;

namespace Algorithms

{
    public class SelectionSort
    {
        public static int[] sort(int[] myarray)
        {

            int no = myarray.Length;
            for(int i = 0; i < no - 1 ; i++)
            {
                int minidx = i;
                int minvalue = myarray[i];

                for(int j = i + 1; j < no ; j++)
                {
                    if(myarray[j] < minvalue) 
                    {
                        minidx = j; 
                        minvalue = myarray[j]; 
                    }

                }
                myarray[minidx] = myarray[i];
                myarray[i] = minvalue;
            }

            return myarray;
        }

    }

}