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
            //dete skal vere logoen eter vert
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

            

            //her er start menyen
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
                } else if(home == "start")
                {
                    //dene delen skal lage en tom side med melomron
                    int a = 0;
                    while(a < 30)
                    {
                        a = ++a;
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    //her skal spillet starte
                    Snaik();

                }
                //lager melomrom
                Console.WriteLine();
            }
        }

        private static void Snaik()
        {
            Console.WriteLine("xxx#  *");
        }
    }
}
