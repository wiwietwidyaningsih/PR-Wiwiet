using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class PR01 : LogicBase
    {
        public PR01(int n)
        {
            JmlhBaris = 2 * n + (n * 2 -1);
            JmlhKolom = JmlhBaris;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int StrKolom = n;
                int EndKolom = StrKolom + 2 * n - 1;
 
                for (int k = StrKolom; k <= EndKolom; k++)
                {
                    if (b + (k - StrKolom) >= (EndKolom - StrKolom) / 2 && (k - StrKolom) - b <= (EndKolom - StrKolom) / 2)
                    {
                        Array2D[b, k] = "*";
                        Array2D[JmlhBaris - 1 - b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[k, JmlhKolom - 1 - b] = "*";
                    }
                }
            }
        }
    }
}
