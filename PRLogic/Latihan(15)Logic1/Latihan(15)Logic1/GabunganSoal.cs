using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_15_Logic1
{
    class GabunganSoal
    {
        public GabunganSoal()
        {
            string jawab = "y"; //t-> tidak keluar
            //jawab.toLower() -> alternatif
            while (jawab == "y" || jawab == "Y")
            {
                Console.WriteLine("--- Logic 01 ---");

                Console.Write("Masukkan nomor soal : ");
                int soal = int.Parse(Console.ReadLine());

                Console.Write("Masukkan nilai n : ");
                int val = int.Parse(Console.ReadLine());

                switch (soal)
                {
                    case 6:
                        Soal06 soal06 = new Soal06(val);
                        break;
                    case 7:
                        Soal07 soal07 = new Soal07(val);
                        break;
                    default:
                        Console.Write("Soal tidak ditemukan!!!");
                        break;
                }
                //ganjalan
                Console.Write("Apakah masih berlanjut?[Y/T]");
                jawab = Console.ReadLine();
            }
        }
    }
}
