using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal03: LogicBase
    {
           public Soal03(int n)
        {
            JmlhBaris = 1;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            for (int k = 0; k < JmlhKolom; k++)
                {
                    int[] Fibo = FunctionBase.FibonacciSoal03(JmlhKolom);
                    {
                        Array2D[0, k] = Fibo[k].ToString();
                    }
                  
                }
            }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}