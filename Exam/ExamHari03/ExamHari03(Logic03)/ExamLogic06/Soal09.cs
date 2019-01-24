using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic06
{
    class Soal09: LogicBase
    {
        public Soal09(int n)
        {
            JmlhBaris = n + 2;
            JmlhKolom = (n * 3) + (n * (n - 1) / 2);
            Array2D = new string[JmlhBaris, JmlhKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void isiArray(int n)
        {
            int angka = 1;
            int deret = 1;
            for (int bangun = 0; bangun < n; bangun++)
            {
                int StrBaris = n - bangun - 1;
                int StrKolom = (bangun * 3) + (bangun * (bangun - 1) / 2);
                int EndBaris = n + 1;
                int EndKolom = StrKolom + 2 + bangun;
                for (int b = StrBaris; b <= EndBaris; b++)
                {
                    angka = deret;
                    for (int k = StrKolom; k <= EndKolom; k++)
                    {
                        if (b + k == StrBaris + EndKolom || k == EndKolom || b == EndBaris)

                            Array2D[b, k] = angka.ToString();
                        angka++;
                    }
                }
                deret = angka;
            }
        }
    }
}