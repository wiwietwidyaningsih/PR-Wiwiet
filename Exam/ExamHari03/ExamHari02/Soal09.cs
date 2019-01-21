using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari02
{
    class Soal09
    {
        public Soal09(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    //kolom 0 sampai 4
                    if (k <= jK / 2)
                    {
                        Console.Write("{0}\t", k * 2 + 1);
                    }
                    //kolom 5 sampai 8
                    else if (k > jK / 2)
                    {
                        Console.Write("{0}\t", (jK - 1 - k) * 2 + 1);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}