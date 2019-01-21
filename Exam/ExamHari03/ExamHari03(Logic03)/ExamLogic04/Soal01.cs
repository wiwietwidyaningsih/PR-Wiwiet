using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic04
{
    class Soal01 : LogicBase
    {
        public Soal01(int n)
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
               
                for (int k = 0; k < JmlhKolom; k++)
                {
                    if (b + k >= JmlhBaris - 1 && k - b <= JmlhBaris - 1)
                    {
                        Array2D[b, k] = "*";
                    }
                }
            }
        }
    }
}