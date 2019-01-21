using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLogic04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai n1 :");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai n2 :");
            int n2 = int.Parse(Console.ReadLine());
            //Soal01 soal01 = new Soal01(n);
            //Soal02 soal02 = new Soal02(n);
            //Soal03 soal03 = new Soal03(n);
            //Soal04 soal04 = new Soal04(n);
            //Soal09 soal09 = new Soal09(n1, n2);
            Soal10 soal10 = new Soal10(n1, n2);
            Console.Write("Tekan sembarang tombol...");
            Console.ReadKey();
        }
    }
}
