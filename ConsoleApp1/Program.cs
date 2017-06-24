using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string logo =
                " x x xxx" +
                "  x x  x" +
                "x x x x " +
                " x  x  x" +
                "  x  x x" +
                "x  x  x ";
            string home; //string home er den som sier vis man skriver noe på startmenyen
            string yore_name;
            Console.WriteLine(logo);
            Console.WriteLine("username");
           yore_name = Console.ReadLine();
            Console.WriteLine("hallo {0}", yore_name);

            
            while (true) {
                Console.WriteLine("hva vil du jøre nå {0}", yore_name);
                Console.WriteLine("skriv 'start' vis du vil starte spillet.");
                Console.WriteLine("hvis du vil vite mer om programet skriv 'help'.");
                home = Console.ReadLine();
                if (home == "help") {
                    Console.WriteLine("welkomen til help");
                    Console.WriteLine("her står alt det du trenger å vite om spillet");
                    Console.WriteLine("");

                } else if(home == "q") {
                    break;
                }
                //lager melomrom
                Console.WriteLine();
            }
        }
    }
}
