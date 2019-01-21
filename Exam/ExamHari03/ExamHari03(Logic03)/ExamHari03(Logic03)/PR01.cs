using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace ExamHari03_Logic03_
{
    class PR01: LogicBase
    {
        public PR01(int n)
        {
            JmlhBaris = n;
            JmlhKolom = n * 2 - 1;
            Array2D = new string[JmlhBaris, JmlhKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray()
        {
            int ascii = 65;
            int[] fibo = FunctionBase.FibonacciSoal01(JmlhBaris);
            for (int b = 0; b < JmlhBaris; b++)
            {
                for (int k = 0; k < JmlhKolom; k++)
                {
                     if (b == k)
                    {
                        Array2D[b, k] = fibo[b].ToString();
                        Array2D[b, JmlhKolom - k - 1] = fibo[b].ToString();
                    }
                    else if (b == JmlhBaris / 2 && k <= JmlhKolom / 2)
                    {
                        Array2D[b,k] = ((char)ascii).ToString();
                        Array2D[b, JmlhKolom - k - 1] = ((char)ascii).ToString();
                        ascii++;
                    }
                     else if (b + k == (JmlhKolom - 1) / 2)
                     {
                         Array2D[b, k] = fibo[k].ToString();
                         Array2D[b, JmlhKolom - k - 1] = fibo[k].ToString();
                     }
                } 
            }
        }
    }
}
