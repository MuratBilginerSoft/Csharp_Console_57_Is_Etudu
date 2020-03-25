using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İş_Etüdü
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Saat = new string[25];
            int[] Saat2 = new int[25];
            Random r = new Random();

            int değer;
            int x1,x2;
            int tsaat;

            Console.WriteLine("Başlan");

            for (int i = 0; i < 25; i++)
            {
                do
                {
                    değer = r.Next(0, 540);
                } while (Array.IndexOf(Saat2,değer)!=-1);

                Saat2[i] = değer;
            }

            Array.Sort(Saat2);

            for (int i = 0; i < 25; i++)
            {
                x1 = Saat2[i] / 60;
                x2 = Saat2[i] % 60;

                tsaat = 8 + x1;

                Saat[i] = tsaat + ":" + x2;
            }

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(Saat[i]);
            }

            Console.ReadKey();
            

            




        }
    }
}
