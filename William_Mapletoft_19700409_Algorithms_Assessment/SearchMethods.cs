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

            do
            {
                mid = (high + low) / 2;
                if (Input[mid] > Search)
                {
                    high = mid;
                }
                else if (Input[mid] < Search)
                {
                    low = mid;
                }
                else
                {
                    found = true;
                }
            }
            while (found == false && low < high - 1);

            if (found = false)
            {
                return 0;
            }
            else
            {
                return mid + 1;
            }
        }
    }
}
