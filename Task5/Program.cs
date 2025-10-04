using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    using System;

    public class Program
    {
        // Середній бал у групі
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return (double)sum / marks.Length;
        }

        // Мінімальна оцінка
        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min) min = marks[i];
            }
            return min;
        }

        // Максимальна оцінка
        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max) max = marks[i];
            }
            return max;
        }

        // Статистика для всіх груп
        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                Console.WriteLine($"Група {i + 1}:");
                Console.WriteLine($"  Середній бал: {GetAverage(group):F2}");
                Console.WriteLine($"  Мінімальна оцінка: {GetMin(group)}");
                Console.WriteLine($"  Максимальна оцінка: {GetMax(group)}");
                Console.WriteLine();
            }
        }

        public static void Main()
        {

            int[][] groups = new int[][]
            {
            new int[] { 12, 10, 8, 9, 11, 7, 12, 6, 10, 8 },
            new int[] { 9, 8, 7, 6, 5, 10, 11, 12, 8, 9, 10, 6 },
            new int[] { 12, 12, 11, 10, 9, 8, 7, 12, 10, 11, 12 }
            };

            PrintGroupStatistics(groups);
        }
    }
}