﻿namespace BL_Day11_12AssignmentOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run");
            Console.WriteLine("1.Count total number of duplicate elements in an array");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the size of array");
                        int len = Convert.ToInt32(Console.ReadLine()); //length of array
                        int[] arr = new int[len];
                        for (int i = 0; i < len; i++)
                        {
                            Console.Write("Enter element number {0} of array:",i+1);
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Number of elements repeating more than once in the array: " + ArrayPrograms.CountOfDulplicateElements(arr));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}