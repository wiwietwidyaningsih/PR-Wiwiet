using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase
{
    public class LogicBase
    {
        public int JmlhBaris { get; set; }
        public int JmlhKolom { get; set; }
        public string[,] Array2D { get; set; }
    }

    public class FunctionBase
    {
        public static int[] FibonacciSoal01(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1; //agar kotak ke 1 dan 2 (index 0 dan 1) bernilai 1
                else
                    result[pos] = result[pos - 1] + result[pos - 2];
            }
            return result;
        }

        public static int[] FibonacciSoal02(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1; //agar kotak ke 1, 2 dan 3 (index 0, 1 dan 2) bernilai 1
                else
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
            }
            return result;
        }

        public static int[] FibonacciSoal03(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1; //agar kotak ke 1 dan 2 (index 0 dan 1) bernilai 1
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2];
                else
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }

        public static int[] FibonacciSoal04(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                    result[pos] = 1; //agar kotak ke 1, 2 dan 3 (index 0, 1 dan 2) bernilai 1
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
                else
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }

        public static int[] FibonacciSoal05(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 1)
                    result[pos] = 1; //agar kotak ke 1 dan 2 (index 0 dan 1) bernilai 1
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2];
                else
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }

        public static int[] FibonacciSoal10(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= n)
                    result[pos] = 1; //agar kotak ke 1 dan 2 (index 0 dan 1) bernilai 1
                else if (pos <= n / 2)
                    result[pos] = result[pos - 1] + result[pos - 2];
                else
                    result[pos] = result[n - 1 - pos];
            }
            return result;
        }

        public static void CetakArray(string[,] array)
        {
            for (int b = 0; b < array.GetLength(0); b++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write("{0}\t", array[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}