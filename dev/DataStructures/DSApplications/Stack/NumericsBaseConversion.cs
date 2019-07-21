using System;
using System.Text;
using DSLibrary.Stack;

namespace DSApplications.Stack
{
    public static class NumericsBaseConversion
    {
        public static int NumberToBaseConversion(int num, int baseVal)
        {
            Stack<int> stack = new Stack<int>();
            int res = 0;

            do
            {
                stack.Push(num % baseVal);
                num = num / baseVal;
            }
            while (num > 0);

            while (stack.Count > 0)
            {
                res = res * 10 + stack.Pop();
            }

            return res;
        }
    }
}
