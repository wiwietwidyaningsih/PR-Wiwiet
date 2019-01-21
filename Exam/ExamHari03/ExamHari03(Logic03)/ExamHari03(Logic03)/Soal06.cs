using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal06: LogicBase
    {
        public Soal06(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray()
        {
            int[] fibo = FunctionBase.FibonacciSoal01(JmlhBaris);
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    if (b == k || b + k == JmlhKolom - 1)
                        Array2D[b, k] = fibo[k].ToString();
                    else if (b < k && b + k < JmlhKolom - 1)
                        Array2D[b, k] = "A";
                    else if (b < k && b + k > JmlhKolom - 1)
                        Array2D[b, k] = "B";
                    else if (b > k && b + k > JmlhKolom - 1)
                        Array2D[b, k] = "C";
                    else
                        Array2D[b, k] = "D";
                }
            }
        }
    }
}
