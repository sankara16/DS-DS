using System;
using System.Collections.Generic;
using System.Text;

namespace DSQuestions.Randomized
{
    public static class RandomAlgos
    {
        #region Array algos
        public static List<int[]> FindSubArrayWithGivenSum(int[] array, int sum)
        {
            List<int[]> result = new List<int[]>();

            int curr_sum = array[0], start = 0;
            int n = array.Length;

            for (int i = 1; i <= n; i++)
            {
                while (curr_sum  > sum &&  start < (i - 1))
                {
                    curr_sum -= array[start];
                    start++;
                }

                if (curr_sum == sum)
                {
                    int[] subArray = new int[i - start];
                    int k = 0;
                    for (int j = start; j <= (i -1); j++)
                    {
                        subArray[k++] = array[j];
                    }

                    result.Add(subArray);
                }

                if (i < n)
                {
                    curr_sum += array[i];
                }
            }

            return result;
        }

        public static int[] SortBinaryArrayInLinearTime(int[] array)
        {
            int n = array.Length;
            int i = 0;
            int j = n - 1;
            while (i < j)
            {
                // if left point is 1 and right pointer is 0 then swap
                if (array[i] == 1 && array[j] == 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

                // or else left is 0, then go to next pointer
                if (array[i] == 0)
                {
                    i++;
                }

                // if right pointer is on 1 then move to its left element. 
                if (array[j] == 1)
                {
                    j--;
                }
            }

            return array;
        }

        public static int FindDuplicateElementInimitedRangeArray( int[] array)
        {
            //Meethod1: By using Dictionary
            // Method2: Single traversal identification
            int duplicateElement = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int val = Math.Abs(array[i]);

                if (array[val - 1] >= 0)
                {
                    array[val - 1] = -array[val - 1];
                }
                else
                {
                    duplicateElement = val;
                    break;
                }
            }

            // revert back all array changes
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = -array[i];
                }
            }

            return duplicateElement;
        }
        #endregion
    }
}
