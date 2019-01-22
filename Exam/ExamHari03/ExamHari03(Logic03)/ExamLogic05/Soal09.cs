using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal09 : LogicBase
    {
        public Soal09(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = n * 2 - 1;
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
                int StrKolom = (n * 2 - 1) / 2 - bangun;

                //Ending Point
                int EndBaris = StrBaris + bangun;
                int EndKolom = StrKolom + (bangun * 2);

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
