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

            do
            {
                counter++;
                mid = (high + low) / 2;
                if (Input[mid] > Search)
                {
                    high = mid;
                }
                else if (Input[mid] < Search)
                {
                    low = mid;
                }
                else if (Input[mid] == Search)
                {
                    found = true;
                }
            }
            while (found == false && low < high - 1);
            Console.WriteLine($"Interpolation Search counter = {counter}");
            if (found == false)
            {
                return 0;
            }
            else
            {
                return mid + 1;
            }
        }

        public static int InterPolationSearch(int[] Input, int Search)
        {
            int low, high, mid;
            int denominator;
            low = 1;
            high = Input.Length - 1;
            int i = 0;
            int counter = 0;
            if (Input[low] <= Search && Search <= Input[high])
            {
                while (low <= high && i == 0)
                {
                    counter++;
                    denominator = Input[high] - Input[low];
                    if (denominator == 0)
                    {
                        mid = low;
                    }
                    else
                    {
                        mid = low + (((Search - Input[low]) * (high - low)) / denominator);
                    }
                    if (Search==Input[mid])
                    {
                        i = mid;
                    }
                    else if (Search < Input[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                Console.WriteLine($"Interpolation Search counter = {counter}");
                return i + 1;
            }
            Console.WriteLine($"Interpolation Search counter = {counter}");
            return 0;
        }

        public static int InterpolationSearch()
        {

        }
    }
}
