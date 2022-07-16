using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace binary_search
{
    public class BinarySearch
     {
        public static int Search(int[] oldArray, int key)
        {
           
            Array.Sort(oldArray);


            int Low = 0;
            int High = oldArray.Length - 1;
            int Mid;
            while (Low <= High)
            {
                Mid =( Low + High )/2;
                if (key == oldArray[Mid])
                    return Mid;
                            
                else if (key < oldArray[Mid])                   
                    High = Mid -1 ;

                else 
                    Low = Mid +1;
                
            }
            return -1;

           
        }
    }
}
