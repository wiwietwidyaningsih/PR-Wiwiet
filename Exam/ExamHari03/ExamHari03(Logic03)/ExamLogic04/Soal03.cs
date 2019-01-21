using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic04
{
    class Soal03 : LogicBase
    {
        public Soal03(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int b = 0; b < JmlhBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < JmlhKolom; k++)
                {
                    if (b + k >= JmlhBaris / 2 && k - b <= JmlhBaris / 2 && b <= JmlhBaris / 2)
                    {
                        Array2D[b, k] = angka.ToString();
                        Array2D[JmlhBaris - 1 - b, k] = angka.ToString();
                        angka++;
                    }
                }
            }
        }
    }
}