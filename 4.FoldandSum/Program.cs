using System;
using System.Linq;
namespace _4.FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowNums = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToArray();
            int k = rowNums.Length / 4;
            int[] firstRow = new int[2 * k + 1];
            int[] secondRow = new int[2 * k + 1];
            int firstKCount = 0;
            int secondRowCount = 0;
            for (int i = rowNums.Length - 1; i >= 0; i--)
            {
                int currentNum = rowNums[i];
            }
            for (int firstK = k - 1; firstK >= 0; firstK--)
            {
                firstKCount++;
                firstRow[firstKCount] = rowNums[firstK];
            }
            for (int lastK = rowNums.Length - 1; lastK >= rowNums.Length - k; lastK--)
            {
                firstKCount++;
                firstRow[firstKCount] = rowNums[lastK];
            }
            for (int middleRow = k; middleRow < 3 * k; middleRow++)
            {
                secondRowCount++;
                secondRow[secondRowCount] = rowNums[middleRow];
            }

            for (int sum = 1; sum <= 2 * k; sum++)
            {
                Console.Write(secondRow[sum] + firstRow[sum] + " ");
            }
        }
    }
}
