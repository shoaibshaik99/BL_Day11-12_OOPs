namespace BL_Day11_12AssignmentOOPs
{
    internal class ArrayPrograms
    {
        public static int CountOfDulplicateElements(int[] arr)
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
            if (coountOfDuplicates <= 0)
            {
                return -1;
            }
            return coountOfDuplicates;
        }

        public static void PrintUniqueElements(int[] arr)
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

        internal static void EachElementFreq(int[] arr)
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

        internal static void MaxMin(int[] arr)
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