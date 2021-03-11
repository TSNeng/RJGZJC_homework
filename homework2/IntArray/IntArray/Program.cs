using System;

namespace IntArray
{
    class IntArray
    {
        static void Main(string[] args)
        {
            int[] nums = Sum_max_min(numbers);
            Console.WriteLine($"最大值为{nums[0]},最小值为{nums[1]}，和为{nums[2]}");
        }

        static int[] numbers = new int[] { 1, 2, 2423, 3423, 235235, 656, 5656 };

        static int[] Sum_max_min(int [] numbers)
        {
            int[] results = new int[3];
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max) { max = numbers[i]; }
                if(numbers[i] < min) { min = numbers[i]; }
                sum += numbers[i];
            }
            results[0] = max;
            results[1] = min;
            results[2] = sum;
            return results;
        }
    }
}
