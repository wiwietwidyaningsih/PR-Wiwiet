using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLogic07
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
            //Soal10 soal10 = new Soal10(n);
            PR03 pr03 = new PR03(n);
            //PostTest posttest = new PostTest(n);
            Console.Write("Tekan sembarang tombol...");
            Console.ReadKey();
        }
    }
}