using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
        {
            JmlhBaris = ((n * 2) - 1) + (n * 2);
            JmlhKolom = JmlhBaris;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    //segitiga atas
                    if (b + k >= n * 2 - 1 && k - b <= n * 2 - 1 && b <= n - 1)
                    {
                        Array2D[b, k] = "*";
                    }
                    //segitiga kiri
                    if (b + k >= n * 2 - 1 && b - k <= n * 2 - 1 && k <= n - 1)
                    {
                        Array2D[b, k] = "*";
                    }
                    //segitiga bawah
                    if (b - k <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && b >= JmlhBaris - n)
                    {
                        Array2D[b, k] = "*";
                    }
                    if (k - b <= n * 2 - 1 && b + k <= (n * 2 - 1) + (n * 3) + n - 2 && k >= JmlhKolom - n)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
