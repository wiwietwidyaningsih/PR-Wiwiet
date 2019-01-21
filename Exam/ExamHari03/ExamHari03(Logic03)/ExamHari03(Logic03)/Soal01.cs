using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal01: LogicBase
    {
        public Soal01(int n)
        {
            //JmlhBaris = n;
            JmlhBaris = 1;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            //Console.WriteLine("Nilai Jumlah Baris : {0}", JmlhBaris);
            //Console.WriteLine("Nilai Jumlah Kolom : {0}", JmlhKolom);
            //Console.WriteLine("Buffer Array : {0}", JmlhBaris * JmlhKolom);

            //for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                    int[] Fibo = FunctionBase.FibonacciSoal01(JmlhKolom);
                    {
                        Array2D[0, k] = Fibo[k].ToString();
                    }
                    ////diagonal kiri atas
                    //if (b == k)
                    //    Array2D[b, k] = (k * 2 + 1).ToString();
                    ////diagonal kiri bawah
                    //else if (b + k == JmlhBaris - 1)
                    //    Array2D[b, k] = (k * 2).ToString();
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
