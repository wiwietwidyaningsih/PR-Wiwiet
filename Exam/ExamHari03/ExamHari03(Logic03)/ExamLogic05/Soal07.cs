using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal07 : LogicBase
    {
        public Soal07(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = (n * n + n) / 2;
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
                int StrKolom = JmlhKolom - bangun - StrBaris - 1;

                //Ending Point
                int EndBaris = StrBaris + bangun;
                int EndKolom = JmlhKolom + bangun - EndBaris - 1;

                int angka = 1;

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        Array2D[b, k] = angka++.ToString();
                    }
                }
            }
        }
    }
}
