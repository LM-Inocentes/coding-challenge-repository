using System;

class Program
{
    static void Main()
    {
        string[] words = { "bat", "tab", "cat", "race", "car", "ooo", "ooo", "_124?#", "_124?#", "#?421" };
        int[][] result = PalindromePairs(words);

        //following the output format answer must be: [[0, 1], [1, 0], [3, 4], [5, 6], [6, 5], [9, 7], [9, 8]]
        Console.Write("[");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"[{result[i][0]}, {result[i][1]}]");
            if (i < result.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
    }

    static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    static int[][] PalindromePairs(string[] words)
    {
        int n = words.Length;
        int[][] tempResult = new int[n * (n - 1)][];  //maximum number of unique pairs of words that can be formed from n words n * (n - 1)
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    string concatenatedWord = words[i] + words[j];
                    if (IsPalindrome(concatenatedWord))
                    {
                        tempResult[count] = new int[] { i, j };
                        count++;
                    }
                }
            }
        }

        int[][] result = new int[count][];
        Array.Copy(tempResult, result, count);

        return result;
    }
}