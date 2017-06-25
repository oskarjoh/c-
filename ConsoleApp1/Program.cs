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
                    int a = 0;
                    while (a < 30)
                    {
                        a = ++a;
                        Console.WriteLine("");
                    }
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
        //dene koden skal sete bloben runt omkring tilfeldig
        static void blob()
        {
            for (int x = 0; x < 50; x++) { 
            string blobb = "*";
            Console.WriteLine("{0}", blobb);
            }
        }

        static void Snaik()
        {
            string slange_hode = "#";
            string slange_krop = "x";
            string blobb = "*";
            Console.WriteLine("{1}{1}{0}   {2}", slange_hode, slange_krop, blobb);
            blob();
        }
    }
}
