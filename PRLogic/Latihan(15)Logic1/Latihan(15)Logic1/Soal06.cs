﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_15_Logic1
{
    class Soal06
    {
        public Soal06(int n)
        {
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    //diagonal dari kiri ke kanan
                    if (b >= k)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                //pindah baris
                Console.WriteLine("\n");
            }
        }
    }
}
