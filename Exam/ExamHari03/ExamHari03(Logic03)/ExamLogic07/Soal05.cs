using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
        {
            JmlhBaris = n + n + 1;
            JmlhKolom = ((n * 2) - 1) + n * 2;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StrBaris = bangun * 2;
                int StrKolom = StrBaris;
                int EndBaris = JmlhBaris - 1;
                int EndKolom = JmlhKolom - EndBaris;

                int angka = 1;

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (k == StrKolom)
                        {
                            Array2D[b, k] = (JmlhBaris - b).ToString();
                            Array2D[b, JmlhKolom - 1 - k] = (JmlhBaris - b).ToString();
                        }
                        else if (b == StrBaris)
                        {
                            Array2D[b, k] = angka.ToString();
                            Array2D[b, JmlhKolom - 1 - k] = angka.ToString();
                            angka++;
                        }
                    }
                }
            }
        }
    }
}