using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            JmlhBaris = ((n * 2) - 1) + (n * 2);
            JmlhKolom = JmlhBaris;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int[] fibo = FunctionBase.FibonacciSoal01(JmlhKolom * JmlhKolom);
            int[] tribo = FunctionBase.FibonacciSoal02(JmlhKolom * JmlhKolom);
            int angka = 1;
            int index1 = 0;
            int index2 = 0;
            
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    //segitiga atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2D[b, k] = angka.ToString();
                        angka += 2;
                    }
                    //segitiga kiri
                    if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2D[b, k] = fibo[index1++].ToString();
                    }
                    //segitiga bawah
                    if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= JmlhBaris - n)
                    {
                        Array2D[b, k] = angka.ToString();
                        angka += 2;
                    }
                    if (k - b <= n * 2 -1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= JmlhKolom - n)
                    {
                        Array2D[b, k] = tribo[index2++].ToString();
                    }
                }
            }
        }
    }
}
