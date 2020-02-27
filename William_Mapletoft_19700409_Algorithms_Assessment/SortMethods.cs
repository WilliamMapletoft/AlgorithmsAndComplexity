using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Mapletoft_19700409_Algorithms_Assessment
{
    class SortMethods
    {
        public static int[] BubbleSort(int[] Input)
        {
            Console.WriteLine("<BubbleSort>");
            int counter = 0;
            int temp = 0;
            bool sorted = false;
            while (sorted == false)
            {
                sorted = true;
                for (int i = 0; i < Input.Length - 1; i++)
                {
                    if (Input[i + 1] < Input[i])
                    {
                        temp = Input[i + 1];
                        Input[i + 1] = Input[i];
                        Input[i] = temp;
                        sorted = false;
                    }
                    counter++;
                }
            }
            
            Console.WriteLine($"Total operations: {counter}");
            return Input;
        }
    }
}
