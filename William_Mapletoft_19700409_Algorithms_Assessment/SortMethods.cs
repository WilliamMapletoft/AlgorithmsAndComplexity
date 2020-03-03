using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace William_Mapletoft_19700409_Algorithms_Assessment
{
    class SortMethods
    {

        public static int MergeCounter = 0;
        public static int[] BubbleSort(int[] Input)
        {
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
            
            Console.WriteLine($"Bubble sort operations: {counter}");
            return Input;
        }
        public static int[] InsertionSort(int[] Input)
        {
            int counter = 0;
            int numSorted = 1;
            int i;
            while (numSorted < Input.Length)
            {
                int temp = Input[numSorted];
                for (i = numSorted; i > 0; i--)
                {
                    counter++;
                    if (temp < Input[i - 1])
                    {
                        Input[i] = Input[i - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                Input[i] = temp;
                numSorted++;
            }
            Console.WriteLine($"Insertion sort operations : {counter}");
            return Input;
        }

        private static void Merge(int[] Input, int[] temp, int low, int middle, int high)
        {
            int ResultIndex = low;
            int TempIndex = low;
            int DestinationIndex = middle;
            while (TempIndex < middle && DestinationIndex <= high)
            {
                if (Input[DestinationIndex] < temp[TempIndex])
                {
                    Input[ResultIndex++] = Input[DestinationIndex++];
                }
                else
                {
                    Input[ResultIndex++] = temp[TempIndex++];
                }
                MergeCounter++;
            }
            while (TempIndex < middle)
            {
                Input[ResultIndex++] = temp[TempIndex++];
            }
        }

        private static void MergeSortRecursive(int[] Input, int[] temp, int low, int high)
        {
            MergeCounter++;
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;

            if (n < 2) return;
            for(i = low; i<middle;i++)
            {
                temp[i] = Input[i];
            }
            MergeSortRecursive(temp, Input, low, middle - 1);
            MergeSortRecursive(Input, temp, middle, high);
            Merge(Input, temp, low, middle, high);
        }

        public static int[] MergeSort(int[] Input)
        {
            int[] temp = new int[Input.Length];
            MergeCounter = 0;
            MergeSortRecursive(Input, temp, 0, Input.Length - 1);
            Console.WriteLine($"Merge sort operations : {MergeCounter}");
            return Input;
        }
    }

    
}
