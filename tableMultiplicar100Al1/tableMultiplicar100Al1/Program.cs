using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tableMultiplicar100Al1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int init = 100; init >= 1; init--)
            {
                Console.WriteLine("Tabla del = " + init);

                for (int i = 1; i <= 12; i++)
                {
                    int result = init * i;
                    Console.WriteLine(init + " x " + i + " = " + result);
                }
            }


            Console.ReadKey();
        }
    }
}
