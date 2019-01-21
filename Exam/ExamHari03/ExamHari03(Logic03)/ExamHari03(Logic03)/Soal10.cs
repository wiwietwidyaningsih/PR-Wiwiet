using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
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
            int ascii = 64;
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    //Atas
                    if (b <= k && b + k <= JmlhBaris - 1 && b % 2 == 0)
                    {
                        //Segitiga atas
                        Array2D[b, k] = fibo[b / 2].ToString();
                        //Segitiga bawah - MIRROR
                        Array2D[JmlhBaris - 1 - b, k] = fibo[b / 2].ToString();
                    }
                    else
                    {
                        //else segitiga atas
                        Array2D[b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                        //else segitiga bawah - MIRROR
                        Array2D[JmlhBaris - 1 - b, k] = ((char)(ascii + (b + 1) / 2)).ToString();
                    }
                }
            }
        }
    }
}
