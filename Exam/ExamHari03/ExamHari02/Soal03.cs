﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari02
{
    class Soal03
    {
       public Soal03(int n)
        {
            //baris
            for (int b = 0; b < n; b++)
            {
                //kolom
                for (int k = 0; k < n; k++)
                {
                    if (b == k)
                    {
                        Console.Write("{0}\t", k * 2 + 1);
                    }
                    else if (b + k == n - 1)
                    {
                        Console.Write("{0}\t", k * 2);
                    }
                    //prepare yg kosong
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