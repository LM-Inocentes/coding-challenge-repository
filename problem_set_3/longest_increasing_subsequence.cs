using System;

class Program
{
    static void Main()
    {
        int[] nums = { 10, 9, 2, 5, 3, 7, 101, 100, 101, 101, 18 };
        PrintLIS(nums); // Output: 5
    }

    static void PrintLIS(int[] nums)
    {
        Console.WriteLine($"Input: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Output: {LengthOfLIS(nums)}");
    }

    static int LengthOfLIS(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int[] LISarr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            LISarr[i] = 1;
        }

        int maxLength = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    LISarr[i] = Math.Max(LISarr[i], LISarr[j] + 1);
                }
            }
            maxLength = Math.Max(maxLength, LISarr[i]);
            // Console.WriteLine($"After processing index {i}: LISarr = [{string.Join(", ", LISarr)}], maxLength = {maxLength}");
        }

        return maxLength;
    }
}