﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class Soal05 : LogicBase
    {
        public Soal05(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {

            int angka = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb + bk == n - 1)
                    {
                        int StrBaris = bb * n;
                        int StrKolom = bk * n;
                        int EndBaris = StrBaris + n - 1;
                        int EndKolom = StrKolom + n - 1;

                        bool kanan = true;

                        for (int b = StrBaris; b <= EndBaris; b++)
                        {
                            for (int k = StrKolom; k <= EndKolom; k++)
                            {
                                if (kanan)
                                {
                                    Array2D[b, k] = angka.ToString();
                                }
                                else
                                {
                                    Array2D[b, EndKolom - k + StrKolom] = angka.ToString();
                                }
                                angka += 2;
                            }
                            kanan = !kanan;
                        }
                    }
                }
            }
        }
    }
}
