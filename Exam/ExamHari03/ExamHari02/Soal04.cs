using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari02
{
    class Soal04
    {
         public Soal04(int n)
        {
            CetakPola(n, n);
        }

        private void CetakPola(int jB, int jK)
        {
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    //diagonal kiri ke kanan/vertikal
                    if (b == k || k == jK / 2)
                    {
                        Console.Write("{0}\t", b * 2 + 1);
                    }
                    //diagonal kanan ke kiri/horizontal
                    else if (b + k == jK - 1 || b == jB / 2)
                    {
                        Console.Write("{0}\t", k * 2);
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
