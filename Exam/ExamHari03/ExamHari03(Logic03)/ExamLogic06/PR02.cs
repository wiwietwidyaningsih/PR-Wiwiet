using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class PR02: LogicBase
    {
        public PR02(int n)
        {
            JmlhBaris = n + 2;
            JmlhKolom = 3 * n + (n * (n - 1) / 2);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StrBaris = n - bangun - 1;
                int StrKolom = JmlhKolom - 1 - (bangun * 3 + (bangun * (bangun - 1) / 2)) - (bangun + 2);
                int EndBaris = n + 1;
                int EndKolom = StrKolom + 2 + bangun;
                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if ((b - StrBaris) + (k - StrKolom) == EndKolom - StrKolom || b == StrBaris || k == StrKolom)
                            Array2D[b, k] = (JmlhKolom - k).ToString();
                    }
                }
            }
        }
    }
}