using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace William_Mapletoft_19700409_Algorithms_Assessment
{
    class Program
    {
        public static string[] arr = File.ReadAllLines("Net_1_256.txt");
        public static int[] Net1_256 = arr.Select(int.Parse).ToArray();
        public static string[] arr2 = File.ReadAllLines("Net_2_256.txt");
        public static int[] Net2_256 = arr2.Select(int.Parse).ToArray();
        public static string[] arr3 = File.ReadAllLines("Net_3_256.txt");
        public static int[] Net3_256 = arr3.Select(int.Parse).ToArray();
        public static string[] arr4 = File.ReadAllLines("Net_1_2048.txt");
        public static int[] Net1_2048 = arr4.Select(int.Parse).ToArray();
        public static string[] arr5 = File.ReadAllLines("Net_2_2048.txt");
        public static int[] Net2_2048 = arr5.Select(int.Parse).ToArray();
        public static string[] arr6 = File.ReadAllLines("Net_3_2048.txt");
        public static int[] Net3_2048 = arr6.Select(int.Parse).ToArray();
        static void Main(string[] args)
        {
            int[] SortedArray = SortMethods.BubbleSort(Net1_256);
            foreach(int j in SortedArray)
            {
                Console.WriteLine(j);
            }
            //\Console.WriteLine(SearchMethods.BinarySearch(Net1_256, 8350));
            Console.ReadLine();
        }
    }
}
