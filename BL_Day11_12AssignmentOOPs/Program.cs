namespace BL_Day11_12AssignmentOOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a program to run it");
            Console.WriteLine("1.Count total number of duplicate elements in an array"
                + "\n2.Print all unique elements of array\n3.Frequency of each element" +
                "\n4.Find Max and min in the array\n5.Inverted right triangle pattern" +
                "\n6.Rectangular boundary pattern\n7.Revere each word of a string" +
                "\n8.Sum of digits of a number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Number of elements repeating more than once in the array: "
                            + ArrayPrograms.CountOfDulplicateElements());
                    }
                    break;
                case 2:
                    ArrayPrograms.PrintUniqueElements();
                    break;
                case 3:
                    ArrayPrograms.EachElementFreq();
                    break;
                case 4:
                    ArrayPrograms.MaxMin();
                    break;
                case 5:
                    PrintingPatterns.InvertedRightTriagle();
                    break;
                case 6:
                    PrintingPatterns.RectangularBoundary();
                    break;
                case 7:
                    Console.Write("Enter a string: ");
                    string input = Console.ReadLine();
                    string result = StringPrograms.ReverseEachWordAtItsPosition(input);
                    Console.WriteLine(result);
                    break;
                case 8:
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    int sumOfDigits = NumberPrograms.SumOfDigits(number);
                    Console.WriteLine($"The sum of digits of {number} is {sumOfDigits}.");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}