using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class Soal07: LogicBase
    {
        public Soal07(int n)
        {
             JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb + bk == n - 1)
                    {
                        int StrBaris = bb * n;
                        int StarKolom = bk * n;
                        int EndBaris = StrBaris + n - 1;
                        int EndKolom = StarKolom + n - 1;
                        for (int b = StrBaris; b <= EndBaris; b++)
                        {
                            for (int k = StarKolom; k <= EndKolom; k++)
                            {
                                if ((b - StrBaris) + (k - StarKolom) >= n / 2 && (k - StarKolom) - (b - StrBaris) <= n / 2 && b - StrBaris <= n / 2)
                                {
                                    Array2D[b, k] = "*";
                                    Array2D[EndBaris - (b - StrBaris), k] = "*";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}