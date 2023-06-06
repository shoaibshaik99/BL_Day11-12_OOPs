namespace BL_Day11_12AssignmentOOPs
{
    internal class NumberPrograms
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}