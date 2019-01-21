using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic04
{
    class Soal10 : LogicBase
    {
        public Soal10(int n1, int n2)
        {
            JmlhBaris = n1;
            JmlhKolom = (n2 * n1) - (n2 - 1);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n2);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n2)
        {
            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int b = 0; b < JmlhBaris; b++)
                {
                    int ascii = 65;
                    for (int k = 0; k < JmlhKolom; k++)
                    {
                        if (b + k >= (JmlhBaris - 1) / 2 && k - b <= (JmlhBaris - 1) / 2 && b <= JmlhBaris / 2)
                        {
                            Array2D[b, k + (JmlhBaris - 1) * bangun] = ((char)ascii).ToString();
                            Array2D[JmlhBaris - 1 - b, k + (JmlhBaris - 1) * bangun] = ((char)ascii).ToString();
                            if (k < JmlhBaris / 2)
                            {
                                ascii++;
                            }
                            else
                            {
                                ascii--;
                            }
                        }
                    }
                }
            }
        }
    }
}