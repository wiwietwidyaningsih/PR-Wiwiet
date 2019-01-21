using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal07 : LogicBase
    {
        public Soal07(int n)
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
                    //Atas
                    if (b <= k && b + k <= JmlhBaris - 1)
                    {
                        //Segitiga atas
                        Array2D[b, k] = fibo[b].ToString();
                        //Segitiga bawah - MIRROR
                        Array2D[JmlhBaris - 1 - b, k] = fibo[b].ToString();
                    }
                    //Kiri
                    else if (b >= k && b + k <= JmlhBaris - 1)
                    {
                        //Segitiga kiri
                        Array2D[b, k] = fibo[k].ToString();
                        //Segitiga kanan - MIRROR
                        Array2D[b, JmlhKolom - 1 - k] = fibo[k].ToString();
                    }
                }
            }
        }
    }
}
