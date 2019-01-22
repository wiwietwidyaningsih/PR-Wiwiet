using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class PR01 : LogicBase
    {
        public PR01(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = (n * n);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.FibonacciSoal01(n * n);
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StarBaris = (bangun * bangun + bangun) / 2 + (n - bangun) * bangun;
                int StarKolom = (n - 1 - bangun) * (n - 1 - bangun);
                int angka = 0;
                int EndBaris = StarBaris + (n - 1 - bangun);
                int EndKolom = StarKolom + ((n - 1 - bangun) * 2);
                for (int b = StarBaris; b <= EndBaris; b++)
                {
                    for (int k = StarKolom; k <= EndKolom; k++)
                    {
                        if (b + k >= StarKolom + EndBaris && k + EndBaris <= b + EndKolom)
                        {
                            Array2D[b, k] = fibo[angka++].ToString();
                        }
                    }

                }
            }
        }
    }
}