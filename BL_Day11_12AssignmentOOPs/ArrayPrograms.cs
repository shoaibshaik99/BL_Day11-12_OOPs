namespace BL_Day11_12AssignmentOOPs
{
    internal class ArrayPrograms
    {
        public static int[] arr;
        static ArrayPrograms()
        {
            Console.WriteLine("Enter the size of array");
            int len = Convert.ToInt32(Console.ReadLine()); //length of array
            arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter element number {0} of array:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int CountOfDulplicateElements()
        {
            Dictionary<int, int> elementsFrequency = new();
            foreach (int i in arr)
            {
                if (elementsFrequency.ContainsKey(i))
                {
                    elementsFrequency[i]++;
                }
                else
                {
                    elementsFrequency[i] = 1;
                    //duplicateElements.Add(i, 1);
                }
            }
            int coountOfDuplicates = 0;
            foreach (int count in elementsFrequency.Values)
            {
                if (count > 1)
                {
                    coountOfDuplicates++;
                }
            }
            if (coountOfDuplicates < 0)
            {
                return -1;
            }
            return coountOfDuplicates;
        }

        public static void PrintUniqueElements()
        {
            int len  = arr.Length;
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < len; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        internal static void EachElementFreq()
        {
            Dictionary<int, int> elementsFrequency = new();
            foreach (int i in arr)
            {
                if (elementsFrequency.ContainsKey(i))
                {
                    elementsFrequency[i]++;
                }
                else
                {
                    elementsFrequency[i] = 1;
                    //duplicateElements.Add(i, 1);
                }
            }

            foreach (int key in elementsFrequency.Keys)
            {
                Console.WriteLine("Number of times " + key + " occurs: " + elementsFrequency[key]);
            }
        }

        internal static void MaxMin()
        {
            int max = arr[1];
            int min = arr[0];
            foreach (int num in arr)
            {
                if (max < num)
                    max = num;

                if (min > num)
                    min = num;
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
    }
}