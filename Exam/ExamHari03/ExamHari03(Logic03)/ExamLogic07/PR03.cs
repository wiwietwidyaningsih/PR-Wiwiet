using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic07
{
    class PR03 : LogicBase
    {
        public PR03(int n)
        {
            JmlhBaris = n * 2 + 1;
            JmlhKolom = n * 2 + (n * 2 - 1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {

                int sKolom = bgn * 2;

                int eBaris = JmlhBaris - 1 - bgn * 2;
                int eKolom = JmlhKolom - 1 - sKolom;
                int angka = 1;
                int nAngka = (eBaris) * 2 + (eKolom - sKolom) + 1;
                for (int b = 0; b <= eBaris; b++)
                {
                    for (int k = sKolom; k <= eKolom; k++)
                    {
                        if (b == eBaris || k == sKolom)
                            Array2D[b, k] = angka++.ToString();
                        else if (k == eKolom)
                        {
                            Array2D[b, k] = nAngka--.ToString();
                        }
                    }
                }
            }
        }

    }
}
