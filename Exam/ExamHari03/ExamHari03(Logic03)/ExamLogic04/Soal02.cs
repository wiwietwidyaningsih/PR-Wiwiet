using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic04
{
    class Soal02: LogicBase
    {
        public Soal02(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n * 2 - 1;
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
                    if (b <= k && b + k <= JmlhKolom - 1)
                        Array2D[b, k] = angka++.ToString();
                }
            }
        }


    }
}
