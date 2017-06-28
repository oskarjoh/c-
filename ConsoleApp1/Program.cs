using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   static class Program
    {
        static void Main(string[] args)
        {
            //dete skal vere logoen eter vert
            Console.WriteLine(" x x xxx");
            Console.WriteLine("  x x  x");
            Console.WriteLine("x x x x ");
            Console.WriteLine(" x  x  x");
            Console.WriteLine("  x  x x");
            Console.WriteLine("x  x  x ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            string home; //string home er den som sier vis man skriver noe på startmenyen
            string yore_name;
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
                //dene delen skal lage en tom side med melomron
                int a = 0;
                while (a < 30)
                {
                    a = ++a;
                    Console.WriteLine("");
                }
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
                for (int i = 0; i < screenwidth; i++)
                {
                    Console.SetCursorPosition(i, screenheight - 1);
                    Console.Write("■");
                }
                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("■");
                }
                for (int i = 0; i < screenheight; i++)
                {
                    Console.SetCursorPosition(screenwidth - 1, i);
                    Console.Write("■");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (berryx == hoofd.xpos && berryy == hoofd.ypos)
                {
                    score++;
                    berryx = randomnomber.Next(1, screenwidth - 2);
                    berryy = randomnomber.Next(1, screenheight - 2);
                }
                for (int i = 0; i < xposlijf.Count(); i++)
                {
                    Console.SetCursorPosition(xposlijf[i], yposlijf[i]);
                    Console.Write("■");
                    if (xposlijf[i] == hoofd.xpos && yposlijf[i] == hoofd.ypos)
                    {
                        gameover = 1;
                    }
                }
                if (gameover == 1)
                {
                    break;
                }
                Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
                Console.ForegroundColor = hoofd.schermkleur;
                Console.Write("■");
                Console.SetCursorPosition(berryx, berryy);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("■");
                tijd = DateTime.Now;
                buttonpressed = "no";
                while (true)
                {
                    tijd2 = DateTime.Now;
                    if (tijd2.Subtract(tijd).TotalMilliseconds > 500) { break; }
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo toets = Console.ReadKey(true);
                        //Console.WriteLine(toets.Key.ToString());
                        if (toets.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonpressed == "no")
                        {
                            movement = "UP";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonpressed == "no")
                        {
                            movement = "DOWN";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonpressed == "no")
                        {
                            movement = "LEFT";
                            buttonpressed = "yes";
                        }
                        if (toets.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonpressed == "no")
                        {
                            movement = "RIGHT";
                            buttonpressed = "yes";
                        }
                    }
                }
                xposlijf.Add(hoofd.xpos);
                yposlijf.Add(hoofd.ypos);
                switch (movement)
                {
                    case "UP":
                        hoofd.ypos--;
                        break;
                    case "DOWN":
                        hoofd.ypos++;
                        break;
                    case "LEFT":
                        hoofd.xpos--;
                        break;
                    case "RIGHT":
                        hoofd.xpos++;
                        break;
                }
                if (xposlijf.Count() > score)
                {
                    xposlijf.RemoveAt(0);
                    yposlijf.RemoveAt(0);
                }
            }
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
            Console.WriteLine("Game over, Score: " + score);
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);
        }
    }
}

    internal class pixel
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
        public ConsoleColor schermkleur { get; set; }
    }

