using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal04: LogicBase
    {
        public Soal04(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //Starting point
                int StrBaris = (bangun * bangun + bangun) / 2;
                int EndBaris = StrBaris + bangun;
                int StrKolom = JmlhKolom - 1 - StrBaris - EndBaris;

                //Ending Point
                int EndKolom = JmlhKolom - (bangun * bangun) - 1;

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
