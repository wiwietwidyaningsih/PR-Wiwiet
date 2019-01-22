using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
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
                int StrKolom = bangun * bangun;

                //Ending Point
                int EndBaris = StrBaris + bangun;
                int EndKolom = StrKolom + (bangun * 2);

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (k - b >= StrKolom - StrBaris && b + k <= EndKolom + StrBaris)
                            Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}
