using System;
using System.Collections.Generic;
using System.Text;
using DSLibrary;
using DSLibrary.Models;

namespace DSQuestions.Hashing
{
    public static class HashAlgos
    {
        public static Dictionary<int, int> FindPairWithGivenSumInAnArray(int[] arr, int sum)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                dictionary.Add(arr[i], i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int val = sum - arr[i];
                
                // Corner cases:
                // 1. [2, 8] ans [8,2] are same. 
                // 2. [5] can be considered as 5 + 5. So we need to avaoid these scenarios by additional conditions
                // in the oif block
                if (dictionary.ContainsKey(val) && i != dictionary[val] && !pairs.ContainsKey(i))
                {
                    pairs.Add(dictionary[val], dictionary[arr[i]]);
                }
            }

            return pairs;
        }
    }
}
