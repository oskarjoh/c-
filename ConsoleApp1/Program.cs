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
                Console.WindowHeight = 20;
                Console.WindowWidth = 60;

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
        static void Snaik()
        {
            Console.WindowHeight = 15;
            Console.WindowWidth = 36;
            int screenwidth = Console.WindowWidth;
            int screenheight = Console.WindowHeight;
            Random randomnomber = new Random();
            int score = 5;
            int gameover = 0;
            pixel hoofd = new pixel();
            hoofd.xpos = screenwidth / 2;
            hoofd.ypos = screenheight / 2;
            hoofd.schermkleur = ConsoleColor.Red;
            string movement = "RIGHT";
            List<int> xposlijf = new List<int>();
            List<int> yposlijf = new List<int>();
            int berryx = randomnomber.Next(0, screenwidth);
            int berryy = randomnomber.Next(0, screenheight);
            DateTime tijd = DateTime.Now;
            DateTime tijd2 = DateTime.Now;
            string buttonpressed = "no";
            while (true)
            {
                Console.Clear();
                if (hoofd.xpos == screenwidth-1 || hoofd.xpos == 0 || hoofd.ypos == screenheight-1 || hoofd.ypos == 0)
                {
                    gameover = 1;
                }
                for (int i = 0;i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("■");
                }
            }
        }
    }

    internal class pixel
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
        public ConsoleColor schermkleur { get; set; }
    }
}
