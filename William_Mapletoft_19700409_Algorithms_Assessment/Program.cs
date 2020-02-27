﻿using System;
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
        public static string SelectedNet = "Net_1_256.txt";
        public static string[] arr = File.ReadAllLines(SelectedNet);
        public static int[] DownloadedArray = arr.Select(int.Parse).ToArray();
        static void Main(string[] args)
        {
            Console.WriteLine($"Selected net: {SelectedNet}");
            switch(Menu())
            {
                case 1: SelectedNet = SelectNet(); Main(args); break;
                case 2: int[] SortedArray = SortMethods.BubbleSort(DownloadedArray); break;
                case 3:
                    break;
                case 4:
                    break;
            }
            //int[] SortedArray = SortMethods.BubbleSort(Net1_256);
            //Console.WriteLine(SearchMethods.BinarySearch(SortedArray, 8351));
            //EveryTenth(SortedArray);
            Console.ReadLine();
        }

        static int Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Choose from the 4 following options:");
                Console.WriteLine("1: Select the array to analyse");
                Console.WriteLine("2: Sort in ascending order");
                Console.WriteLine("3: Sort in descrending order");
                Console.WriteLine("4: Search the array for a user defined value");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine(choice);
            }
            while (choice < 1 || choice > 4);
            return choice;
        }

        static void EveryTenth(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        static void EveryFifty(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 50 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        static string SelectNet()
        {
            string net = "";
            int choice;
            do
            {
                Console.WriteLine("Choose from the 6 following options:");
                Console.WriteLine("1: Net_1_256");
                Console.WriteLine("2: Net_1_2048");
                Console.WriteLine("3: Net_2_256");
                Console.WriteLine("4: Net_2_2048");
                Console.WriteLine("5: Net_3_256");
                Console.WriteLine("6: Net_3_2048");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine(choice);
                switch (choice)
                {
                    case 1: net = "Net_1_256.txt"; break;
                    case 2: net = "Net_1_2048.txt"; break;
                    case 3: net = "Net_2_256.txt"; break;
                    case 4: net = "Net_2_2048.txt"; break;
                    case 5: net = "Net_3_256.txt"; break;
                    case 6: net = "Net_3_2048.txt"; break;
                }
                arr = File.ReadAllLines(net);
                DownloadedArray = arr.Select(int.Parse).ToArray();
            }
            while (choice < 1 || choice > 6);
            return net;
        }
    }
}
