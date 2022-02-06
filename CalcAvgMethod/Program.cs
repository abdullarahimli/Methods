using System;

namespace CalcAvgMethod                                                                            // Methodlar ayri ayri proyektlerde yaradilib
{                                                                                                  // Sag terefde ================= >>>>>>>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int eded1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil edin");
            int eded2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ucuncu ededi daxil edin");
            int eded3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dorduncu ededi daxil edin");
            int eded4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Besinci ededi daxil edin");
            int eded5 = int.Parse(Console.ReadLine());

            int[] netice = { eded1, eded2, eded3, eded4, eded5 };

            CalcAvg(netice);
        }


        static void CalcAvg(int[] a)
        {
            int count = 0;
            int yekundeyer = 0;
            for (var i = 0; i < a.Length; i++)
            {
                yekundeyer = yekundeyer + a[i];
                count++;
            };

            int average = yekundeyer / count;

            Console.WriteLine("Sizin umumi ortalamaniz :");
            Console.WriteLine(average);

            if (average >= 60)
            {
                Console.WriteLine("Tebrikler mezun oldunuz !");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz !)");
            }


        }
    }
}

