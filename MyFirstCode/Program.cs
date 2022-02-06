using System;

namespace MyFirstCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin: ");
            int a = int.Parse(Console.ReadLine());


            IsPrime(a);
            
        }


        static void IsPrime(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Eded murekkebdir");
            }

            else
            {
                Console.WriteLine("Eded sadedir");
            }
        }

    }
}
