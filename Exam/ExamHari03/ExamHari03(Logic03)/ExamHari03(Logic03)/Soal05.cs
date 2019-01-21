using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            for (int b = 0; b < JmlhBaris; b++) //untuk mengisi baris (berjalan di baris)
            {
                for (int k = 0; k < JmlhKolom; k++) //untuk mengisi kolom (berjalan di kolom)
                {
                    int[] Fibo = FunctionBase.FibonacciSoal05(JmlhKolom); //nahh...yg berjalan di baris dan di kolom itu = bilangan fibonacci
                    {
                        Array2D[b, k] = Fibo[k].ToString();
                    }
                }
            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++) //untuk mencetak nilai baris
            {
                for (int k = 0; k < Array2D.GetLength(1); k++) //untuk mencetak nilai kolom
                {
                    if (b > k && b + k < JmlhBaris - 1)
                        Console.Write("\t");
                    else
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}