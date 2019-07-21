using System;
using System.Collections.Generic;
using System.Text;

namespace DSApplications.Queue
{
    public static class RadixSort
    {
        private static void Display(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}\t", nums[i]);
            }
        }

        private static Queue<int>[] InitializeQueues()
        {
            Queue<int>[] queues = new Queue<int>[10];

            for (int i = 0; i < queues.Length; i++)
            {
                queues[i] = new Queue<int>();
            }

            return queues;
        }

        public static void RadixSortAndBuildBack(Queue<int>[] queues, int[] nums, DigitType enumValue)
        {
            if (enumValue == DigitType.NotSupported)
            {
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int queueIndex = FindQueueIndex(nums[i], enumValue);

                queues[queueIndex].Enqueue(nums[i]);
            }

            int x = 0;
            for (int i = 0; i < queues.Length; i++)
            {
                while (queues[i].Count > 0)
                {
                    nums[x++] = queues[i].Dequeue();
                }
            }

            RadixSortAndBuildBack(queues, nums, Next(enumValue));
        }

        private static int FindQueueIndex(int value, DigitType enumValue)
        {
            int index = 0;
            int tempValue = 0;

            switch (enumValue)
            {
                case DigitType.One:
                    index = value > 0 ? value % 10 : 0;
                    break;

                case DigitType.Ten:
                    tempValue = value > 10 ? value % 100 : 0;
                    index = tempValue / 10;
                    break;

                case DigitType.Hundred:
                    tempValue = value > 100 ? value % 1000 : 0;
                    index = tempValue / 100;
                    break;

                case DigitType.Thousand:
                    tempValue = value > 1000 ? value % 10000 : 0;
                    index = tempValue / 1000;
                    break;

                case DigitType.TenThousand:
                    tempValue = value > 10000 ? value % 100000 : 0;
                    index = tempValue / 10000;
                    break;

                case DigitType.HundredThousand:
                    tempValue = value > 100000 ? value % 1000000 : 0;
                    index = tempValue / 100000;
                    break;

                case DigitType.Million:
                    tempValue = value > 1000000 ? value % 10000000 : 0;
                    index = tempValue / 1000000;
                    break;

                case DigitType.TenMillion:
                    tempValue = value > 10000000 ? value % 100000000 : 0;
                    index = tempValue / 10000000;
                    break;

                case DigitType.Billion:
                    tempValue = value > 100000000 ? value % 1000000000 : 0;
                    index = tempValue / 100000000;
                    break;
            }

            return index;
        }

        public static DigitType Next(DigitType curr)
        {
            if (!typeof(DigitType).IsEnum)
            {
                throw new ArgumentException(string.Format("Argument {0} is not an  Enum", typeof(DigitType).FullName));
            }

            DigitType[] arr = (DigitType[])Enum.GetValues(typeof(DigitType));
            int index = Array.IndexOf<DigitType>(arr, curr) + 1;

            return (arr.Length == index) ? arr[0] : arr[index];
        }

        //public static T Next<T>(this T src) where T : struct
        //{
        //    if (!typeof(T).IsEnum)
        //    {
        //        throw new ArgumentException(string.Format("Argument {0} is not an  Enum", typeof(T).FullName));
        //    }

        //    T[] arr = (T[])Enum.GetValues(src.GetType());
        //    int index = Array.IndexOf<T>(arr, src) + 1;

        //    return (arr.Length == index) ? arr[0] : arr[index];
        //}

        // Use: eRat.B.Next();
    }

    public enum DigitType
    {
        One,
        Ten,
        Hundred,
        Thousand,
        TenThousand,
        HundredThousand,
        Million,
        TenMillion,
        Billion,
        NotSupported
    }
}
