using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHari02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            //Soal01 soal01 = new Soal01(val);
            //Soal02 soal02 = new Soal02(val);
            //Soal03 soal03 = new Soal03(val);
            //Soal04 soal04 = new Soal04(val);
            //Soal05 soal05 = new Soal05(val);
            //Soal06 soal06 = new Soal06(val);
            //Soal07 soal07 = new Soal07(val);
            //Soal08 soal08 = new Soal08(val);
            //Soal09 soal09 = new Soal09(val);
            Soal10 soal10 = new Soal10(val);
            Console.ReadKey();
        }
    }
}
