using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = n * 2 - 1;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int[] Fibo = FunctionBase.FibonacciSoal01(JmlhKolom * n);
                int index = 0;
                int ganjil = 1;
                //Starting point
                int StrBaris = (bangun * bangun + bangun) / 2;
                int StrKolom = (n * 2 - 1) / 2 - bangun;

                //Ending Point
                int EndBaris = StrBaris + bangun;
                int EndKolom = StrKolom + (bangun * 2);


                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b + k >= StrKolom + EndBaris && k + EndBaris <= b + EndKolom)
                        {
                            if (bangun % 2 == 0)
                            {

                                Array2D[b, k] = ganjil.ToString();
                                ganjil += 2;
                            }
                            else
                                Array2D[b, k] = Fibo[index++].ToString();
                        }

                    }
                }
            }
        }
    }
}
