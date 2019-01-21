using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class Soal08: LogicBase
    {
        public Soal08(int n)
        {
            JmlhBaris = n; //mendefinisikan JmlhBaris
            JmlhKolom = n; //mendefinisikan JmlhKolom
            Array2D = new string[JmlhBaris, JmlhKolom]; //mendefinisikan array (didalam if), sebagai pengganti console write
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            for (int b = 0; b < JmlhBaris; b++) //agar di array muncul baris
            {
                for (int k = 0; k < JmlhKolom; k++) //agar di array muncul kolom
                {
                    //Atas
                    if (b <= k && b + k <= JmlhBaris - 1 && b % 2 == 0) //segitiga atas && modulus 2 sisa 0 (agar ada sela baris)
                    {
                        //segitiga atas
                        Array2D[b, k] = (b + 1).ToString();
                        //segitiga bawah - MIRROR
                        Array2D[JmlhBaris - 1 - b, k] = (b + 1).ToString();
                    }
                    //Kiri
                    else if (b >= k && b + k <= JmlhBaris - 1 && k % 2 == 0) //segitiga kiri && modulus 2 sisa 0 (agar ada sela kolom)
                    {
                        //segitiga kiri
                        Array2D[b, k] = (k + 1).ToString(); //fibo[b / 2] = (index ke-) agar penempatan bil. fibonaci sesuai sela kolom
                        //segitiga kanan - MIRROR
                        Array2D[b, JmlhKolom - 1 - k] = (k + 1).ToString();
                    }
                }
            }
        }
    }
}
