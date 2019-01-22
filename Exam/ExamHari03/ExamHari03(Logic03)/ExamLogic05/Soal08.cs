using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamLogic05
{
    class Soal08 : LogicBase
    {
        public Soal08(int n)
        {
            JmlhBaris = (n * n + n) / 2;
            JmlhKolom = (n * n + n) / 2;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            //value
            int ganjil = 1;
            int genap = 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //Starting Point
                int strBaris = (bangun * bangun + bangun) / 2;
                int strKolom = strBaris;

                //Ending Point
                int EndBaris = strBaris + bangun;
                int EndKolom = EndBaris;

                //Flow
                bool kanan = true;
                //string arah = "kanan";

                for (int b = strBaris; b <= EndBaris; b++)
                {
                    for (int k = strKolom; k <= EndKolom; k++)
                    {
                        //Array2D[b, kanan ? k : EndKolom - k + strKolom] = bangun % 2 == 0 ? ganjil.ToString() : genap.ToString();
                        //if (bangun % 2 == 0) ganjil += 2; else genap += 2;
                        if (kanan)
                        {
                            if (bangun % 2 == 0)
                                Array2D[b, k] = ganjil.ToString();
                            else
                                Array2D[b, k] = genap.ToString();
                        }
                        else
                        {
                            if (bangun % 2 == 0)
                                Array2D[b, EndKolom - k + strKolom] = ganjil.ToString();
                            else
                                Array2D[b, EndKolom - k + strKolom] = genap.ToString();
                        }

                        if (bangun % 2 == 0)
                            ganjil += 2;
                        else
                            genap += 2;
                    }
                    kanan = !kanan;
                    //if (arah == "kanan")
                    //    arah = "kiri";
                    //else
                    //    arah = "kanan";
                }
            }
        }
    }
}