﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JmlhBaris = n * n;
            JmlhKolom = n * n;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int deret = (n + 1) / 2;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int StrBaris = bb * n;
                        int StrKolom = bk * n;
                        int EndBaris = StrBaris + n - 1;
                        int EndKolom = StrKolom + n - 1;

                        for (int b = StrBaris; b <= EndBaris; b++)
                        {
                            int angka = deret;
                            for (int k = StrKolom; k <= EndKolom; k++)
                            {
                                if (b + k >= StrBaris + (StrKolom + EndKolom) / 2 && (k - StrKolom) - (b - StrBaris) <= n / 2 && b <= (StrBaris + EndBaris) / 2)
                                {
                                    if (k < (StrKolom + EndKolom) / 2)
                                    {
                                        Array2D[b, k] = angka.ToString();
                                        Array2D[EndBaris - b + StrBaris, k] = angka.ToString();
                                        angka--;
                                    }
                                    else
                                    {
                                        Array2D[b, k] = angka.ToString();
                                        Array2D[EndBaris - b + StrBaris, k] = angka.ToString();
                                        angka++;
                                    }
                                }
                            }
                        }
                    }
                }
                deret = deret + (n + 1) / 2;
            }
        }
    }
}
