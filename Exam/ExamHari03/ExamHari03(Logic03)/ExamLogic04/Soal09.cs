using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic04
{
    class Soal09: LogicBase
    {
        public Soal09(int n1, int n2)
        {
            JmlhBaris = n1;
            JmlhKolom = (n1 * n2) - (n2 - n1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n2)
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int b = 0; b < JmlhBaris; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < JmlhKolom; k++)
                    {
                        if (b + k >= (JmlhBaris - 1) / 2 && k - b <= (JmlhBaris - 1) / 2 && b <= JmlhBaris / 2)
                        {
                            Array2D[b, k + (JmlhBaris - 1) * bangun] = angka.ToString();
                            Array2D[JmlhBaris - 1 - b, k + (JmlhBaris - 1) * bangun] = angka.ToString();
                            if (k < JmlhBaris / 2)
                            {
                                angka += 2;
                            }
                            else
                            {
                                angka -= 2;
                            }
                        }
                    }
                }
            }
        }

    }
}
