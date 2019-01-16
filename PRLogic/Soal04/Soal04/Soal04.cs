using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal04
{
    class Soal04
    {
        public Soal04()
        {
            int n = 9;
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    //pindah kolom
                    if (b == k || b + k == n-1 || b + k == b + ((n-1)/2) || b + k == ((n-1)/2) + k)
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
