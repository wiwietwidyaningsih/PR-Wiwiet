using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
        {
            JmlhBaris = n * n;
            if (n == 1)
            {
                JmlhKolom = 1;
            }
            else
            {
                JmlhKolom = (n * 2 - 1) * 2;
            }
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StrBaris = n * bangun;
                int StrKolom = bangun % 2 * (n * 2 - 1);
                int EndBaris = StrBaris + n - 1;
                int EndKolom = StrKolom + 2 * (n - 1);

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b + k >= StrKolom + EndBaris && k + EndBaris <= b + EndKolom)
                            Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
