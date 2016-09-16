using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satser
{
    class Program
    {
        static void Main(string[] args) 

            //övning1
        {
            Console.WriteLine("Skriv in mönsterjup");
            int mönsterdjup = int.Parse(Console.ReadLine());

            if (mönsterdjup  < 1.6)
            {
                Console.WriteLine("olagligt däck!");
            }

            //övning2

            Console.WriteLine("Mata in ålder");
            int ålder = int.Parse(Console.ReadLine);

            if (ålder < 12)
            {
                Console.WriteLine.("vit");
            }
            else (ålder < 18)
                    {
                Console.WriteLine.("grön");

           }

        }
    }
}
