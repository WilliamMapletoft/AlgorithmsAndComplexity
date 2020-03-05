using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Mapletoft_19700409_Algorithms_Assessment
{
    class SearchMethods
    {
        public static int BinarySearch(int[] Input, int Search)
        {
            bool found = false;
            int high = Input.Length - 1;
            int low = 0;
            int mid = (high + low) / 2;
            int counter = 0;
            int closest = 0;

            do
            {
                counter++;
                mid = (high + low) / 2;
                if (Input[mid] > Search)
                {
                    closest = Input[mid];
                    high = mid;
                }
                else if (Input[mid] < Search)
                {
                    closest = Input[mid];
                    low = mid;
                }
                else if (Input[mid] == Search)
                {
                    found = true;
                }
            }
            while (found == false && low < high - 1);
            Console.WriteLine($"Binary Search counter = {counter}");
            if (found == false)
            {
                if (Search > Input[Input.Length - 1])
                {
                    closest = Input[Input.Length - 1];
                }
                Console.WriteLine($"Item not found. Closest item: {closest}");
                return -1;
            }
            else
            {
                return mid;
            }
        }

        public static int InterPolationSearch(int[] Input, int Search)
        {
            int closest = 0;
            int lo = 0, hi = (Input.Length - 1);

            while (lo <= hi && Search >= Input[lo] && Search <= Input[hi])
            {
                if(lo == hi)
                {
                    if (Input[lo] == Search) return lo;
                    Console.WriteLine($"Item not found. Closest item : {Input[Input.Length - 1]}");
                    return -1;
                }

                int pos = lo + (((hi - lo) / (Input[hi] - Input[lo])) * (Search - Input[lo]));
                closest = Input[pos];
                if (Input[pos] == Search)
                    return pos;

                if (Input[pos] < Search)
                {
                    lo = pos + 1;
                }
                else
                {
                    hi = pos - 1;
                }
            }
            if (closest == 0)
            {
                closest = Input[Input.Length-1];
            }
            Console.WriteLine($"Item not found. Closest item : {closest}");
            return -1;
            
        }
    }
}
