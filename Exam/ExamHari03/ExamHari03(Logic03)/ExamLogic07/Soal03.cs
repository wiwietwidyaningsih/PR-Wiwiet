using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class Soal03: LogicBase
    {
        public Soal03(int n)
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

                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b == StrBaris || k == StrKolom)
                        {
                            Array2D[b, k] = "*";
                            Array2D[b, JmlhKolom - 1 - k] = "*";
                        }
                    }
                }
            }
        }
    }
}