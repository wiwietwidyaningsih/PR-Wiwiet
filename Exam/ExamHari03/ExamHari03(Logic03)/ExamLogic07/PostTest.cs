using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class PostTest : LogicBase
    {
        public PostTest(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = JmlhBaris;
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.FibonacciSoal01(n * n);
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int angka = 0;
                        int nAngka = n * 2 + (n - 2) * 2 - 1;
                        int sBaris = bb * n;
                        int sKolom = bk * n;
                        int eBaris = sBaris + n - 1;
                        int eKolom = sKolom + n - 1;
                        for (int b = sBaris; b <= eBaris; b++)
                        {
                            for (int k = sKolom; k <= eKolom; k++)
                            {
                                if (b == sBaris || k == eKolom)
                                    Array2D[b, k] = fibo[angka++].ToString();
                                else if (b == eBaris || k == sKolom)
                                    Array2D[b, k] = fibo[nAngka--].ToString();
                            }
                        }
                    }
                }
            }
        }

    }
}
