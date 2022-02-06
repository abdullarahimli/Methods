using System;

namespace FindCharIndexMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String deyeri daxil edin: ");

            string name = (Console.ReadLine());

            Console.WriteLine("Char deyeri daxil edin: ");

            char chelement = char.Parse(Console.ReadLine());

            FindCharIndex(name, chelement);
        }
        static void FindCharIndex(string a, char b)
        {

            bool check = true;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    check = false;

                }

            }

            if (check == false)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
