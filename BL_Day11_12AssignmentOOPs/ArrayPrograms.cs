using System.Diagnostics.Metrics;

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
    }
}
