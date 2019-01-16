using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal04
{
    class Soal05
    {
        public Soal05()
        {
            int n = 9;
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    //pindah kolom
                    if (b == k || b + k == n - 1 || b + k == k || b + k == b || b + k == (n - 1) + k || b + k == b + (n - 1))
                    {
                        Console.Write("*\t");
                    }
                    else
                        Console.Write("\t");
                }
                //pindah baris
                Console.WriteLine("\n");
            }
            //tahan cetakan
            Console.WriteLine("Tekan sembarang tombol untuk exit.");
            Console.ReadKey();
        }
    }
}
