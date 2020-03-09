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
        public static int HeapCounter = 0;
        public static int[] BubbleSort(int[] Input, bool debug)
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
                        if (debug == true) { Console.WriteLine($"Swapping items {Input[i]} and {Input[i + 1]}"); }
                        temp = Input[i + 1];
                        Input[i + 1] = Input[i];
                        Input[i] = temp;
                        sorted = false;
                        counter++;
                    }
                }
            }
            
            Console.WriteLine($"Bubble sort operations: {counter}");
            return Input;
        }
        public static int[] BubbleSortDown(int[] Input, bool debug)
        {
            int counter = 0;
            int temp = 0;
            bool sorted = false;
            while (sorted == false)
            {
                sorted = true;
                for (int i = 0; i < Input.Length - 1; i++)
                {
                    if (Input[i + 1] > Input[i])
                    {
                        if (debug == true) { Console.WriteLine($"Swapping items {Input[i]} and {Input[i + 1]}"); }
                        temp = Input[i + 1];
                        Input[i + 1] = Input[i];
                        Input[i] = temp;
                        sorted = false;
                        counter++;
                    }
                    
                }
            }

            Console.WriteLine($"Bubble sort operations: {counter}");
            return Input;
        }
        public static int[] InsertionSort(int[] Input, bool debug)
        {
            int counter = 0;
            int numSorted = 1;
            int i;
            while (numSorted < Input.Length)
            {
                int temp = Input[numSorted];
                for (i = numSorted; i > 0; i--)
                {
                    if (temp < Input[i - 1])
                    {
                        counter++;
                        if (debug == true) { Console.WriteLine($"Swapping items {Input[i]} and {Input[i - 1]}"); }
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
        public static int[] InsertionSortDown(int[] Input, bool debug)
        {
            int counter = 0;
            int numSorted = 1;
            int i;
            while (numSorted < Input.Length)
            {
                int temp = Input[numSorted];
                for (i = numSorted; i > 0; i--)
                {
                    if (temp > Input[i - 1])
                    {
                        counter++;
                        if (debug == true) { Console.WriteLine($"Swapping items {Input[i]} and {Input[i - 1]}"); }
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
        private static void Merge(int[] Input, int[] temp, int low, int middle, int high, bool debug)
        {
            int ResultIndex = low;
            int TempIndex = low;
            int DestinationIndex = middle;
            while (TempIndex < middle && DestinationIndex <= high)
            {
                MergeCounter++;
                if (Input[DestinationIndex] < temp[TempIndex])
                {
                    if (debug == true) { Console.WriteLine($"Swapping items {Input[DestinationIndex]} and {temp[TempIndex]}"); }
                    Input[ResultIndex++] = Input[DestinationIndex++];
                }
                else
                {
                    Input[ResultIndex++] = temp[TempIndex++];
                }
            }
            while (TempIndex < middle)
            {
                Input[ResultIndex++] = temp[TempIndex++];
            }
        }
        private static void MergeDown(int[] Input, int[] temp, int low, int middle, int high, bool debug)
        {
            int ResultIndex = low;
            int TempIndex = low;
            int DestinationIndex = middle;
            while (TempIndex < middle && DestinationIndex <= high)
            {
                MergeCounter++;
                if (Input[DestinationIndex] > temp[TempIndex])
                {
                    if (debug == true) { Console.WriteLine($"Swapping items {Input[DestinationIndex]} and {temp[TempIndex]}"); }
                    Input[ResultIndex++] = Input[DestinationIndex++];
                }
                else
                {
                    Input[ResultIndex++] = temp[TempIndex++];
                }
            }
            while (TempIndex < middle)
            {
                Input[ResultIndex++] = temp[TempIndex++];
            }
        }
        private static void MergeSortRecursive(int[] Input, int[] temp, int low, int high, bool debug)
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
            MergeSortRecursive(temp, Input, low, middle - 1, debug);
            MergeSortRecursive(Input, temp, middle, high, debug);
            Merge(Input, temp, low, middle, high, debug);
        }
        private static void MergeSortRecursiveDown(int[] Input, int[] temp, int low, int high, bool debug)
        {
            MergeCounter++;
            int n = high - low + 1;
            int middle = low + n / 2;
            int i;

            if (n < 2) return;
            for (i = low; i < middle; i++)
            {
                temp[i] = Input[i];
            }
            MergeSortRecursiveDown(temp, Input, low, middle - 1, debug);
            MergeSortRecursiveDown(Input, temp, middle, high, debug);
            MergeDown(Input, temp, low, middle, high, debug);
        }
        public static int[] MergeSort(int[] Input, bool debug)
        {
            int[] temp = new int[Input.Length];
            MergeCounter = 0;
            MergeSortRecursive(Input, temp, 0, Input.Length - 1, debug);
            Console.WriteLine($"Merge sort operations : {MergeCounter}");
            return Input;
        }
        public static int[] MergeSortDown(int[] Input, bool debug)
        {
            int[] temp = new int[Input.Length];
            MergeCounter = 0;
            MergeSortRecursiveDown(Input, temp, 0, Input.Length - 1, debug);
            Console.WriteLine($"Merge sort operations : {MergeCounter}");
            return Input;
        }
        public static int[] HeapSort(int[] Input, bool debug)
        {
            int n = Input.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(Input, n, i, debug);
            }

            for(int i = n-1; i>=0;i--)
            {
                int temp = Input[0];
                Input[0] = Input[i];
                Input[i] = temp;

                Heapify(Input, i, 0, debug);
            }
            Console.WriteLine($"Heap sort operations : {HeapCounter}");
            return Input;
        }
        public static int[] HeapSortDown(int[] Input, bool debug)
        {
            int n = Input.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                HeapifyDown(Input, n, i, debug);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = Input[0];
                Input[0] = Input[i];
                Input[i] = temp;

                HeapifyDown(Input, i, 0, debug);
            }
            Console.WriteLine($"Heap sort operations : {HeapCounter}");
            return Input;
        }
        private static void Heapify(int[] Input, int n, int i, bool debug)
        {
            HeapCounter++;
            int Largest = i;
            int Left = 2 * i + 1;
            int Right = 2 * i + 2;

            if (Left < n && Input[Left] > Input[Largest])
            {
                Largest = Left;
            }

            if (Right < n && Input[Right] > Input[Largest])
            {
                Largest = Right;
            }

            if(Largest != i)
            {
                if (debug == true) {  Console.WriteLine($"Swapping items {Input[i]} and {Input[Largest]}"); }
                int swap = Input[i];
                Input[i] = Input[Largest];
                Input[Largest] = swap;

                Heapify(Input, n, Largest, debug);
            }
        }
        private static void HeapifyDown(int[] Input, int n, int i, bool debug)
        {
            HeapCounter++;
            int Largest = i;
            int Left = 2 * i + 1;
            int Right = 2 * i + 2;

            if (Left < n && Input[Left] < Input[Largest])
            {
                Largest = Left;
            }

            if (Right < n && Input[Right] < Input[Largest])
            {
                Largest = Right;
            }

            if (Largest != i)
            {
                if (debug == true){ Console.WriteLine($"Swapping items {Input[i]} and {Input[Largest]}"); }
                int swap = Input[i];
                Input[i] = Input[Largest];
                Input[Largest] = swap;

                HeapifyDown(Input, n, Largest, debug);
            }
        }
    }

    
}
