namespace BL_Day11_12AssignmentOOPs
{
    internal class PrintingPatterns
    {
        internal static void InvertedRightTriagle()
        {
            Console.WriteLine("Enter number of elements required in first row of pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j >0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
