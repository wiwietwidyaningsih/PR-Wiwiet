using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class PR02: LogicBase
    {
        public PR02(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = (n * n);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int[] tribo = FunctionBase.FibonacciSoal02(n * n);
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StrBaris = (bangun * bangun + bangun) / 2 + (n - bangun) * bangun;
                int StrKolom = bangun * bangun + (n - bangun) * bangun * 2;
                int angka = 0;
                int EndBaris = StrBaris + (n - 1 - bangun);
                int EndKolom = StrKolom + ((n - 1 - bangun) * 2);
                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b + k >= StrKolom + EndBaris && k + EndBaris <= b + EndKolom)
                        {
                            Array2D[b, k] = tribo[angka++].ToString();
                        }
                    }
                }
            }
        }
    }
}