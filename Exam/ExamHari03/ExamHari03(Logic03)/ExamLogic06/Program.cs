using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLogic06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai n : ");
            int n = int.Parse(Console.ReadLine());
            //Soal01 soal01 = new Soal01(n);
            //Soal02 soal02 = new Soal02(n);
            //Soal03 soal03 = new Soal03(n);
            //Soal04 soal04 = new Soal04(n);
            //Soal05 soal05 = new Soal05(n);
            //Soal06 soal06 = new Soal06(n);
            //Soal08 soal08 = new Soal08(n);
            //Soal09 soal09 = new Soal09(n);
            //Soal10 soal10 = new Soal10(n);
            //PR01 pr01 = new PR01(n);
            PR02 pr02 = new PR02(n);
            Console.Write("Tekan sembarang tombol...");
            Console.ReadKey();
        }
    }
}
