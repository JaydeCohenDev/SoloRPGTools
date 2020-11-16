using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{

    class Fate : ICommand
    {
        public string[,] fateOdds = new string[,] {
            {"10,50,91","5,25,86","3,15,84","2,10,83","1,5,82","1,5,82","0,0,81","0,0,81","0,-20,77"},
            {"15,75,96","10,50,91","7,35,88","5,25,86","3,15,84","2,10,83","1,5,82","1,5,82","0,0,81"},
            {"16,85,97","13,65,94"}
        };

        public void Execute(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Improper arguments. fate <chaosfactor>");
                return;
            }

            int chaosFactor = Math.Clamp(int.Parse(args[1]), 1, 9);
            int chaosIndex = 10 - chaosFactor - 1;
            Console.WriteLine("Select a likeyhood: ");
            Console.WriteLine("");
            Console.WriteLine("[0] Impossible");
            Console.WriteLine("[1] No way");
            Console.WriteLine("[2] Very unlikely");
            Console.WriteLine("[3] Unlikely");
            Console.WriteLine("[4] 50/50");
            Console.WriteLine("[5] Somewhat likely");
            Console.WriteLine("[6] Likely");
            Console.WriteLine("[7] Very likely");
            Console.WriteLine("[8] Near sure thing");
            Console.WriteLine("[9] A sure thing");
            Console.WriteLine("[10] Has to be");
            Console.WriteLine("");
            Console.Write(">");
            int option = Math.Clamp(int.Parse(Console.ReadLine()), 0, 10);

            string[] oddsArgs = fateOdds[option, chaosIndex].Split(",");
            int a = Dice.Roll(1, 10);
            int b = Dice.Roll(1, 10);
            int r = a + b;
            if (r <= int.Parse(oddsArgs[0]))
            {
                Console.WriteLine("Exceptional yes");
            }
            else if (r <= int.Parse(oddsArgs[1]))
            {
                Console.WriteLine("Yes");
            }
            else if (r <= int.Parse(oddsArgs[2]))
            { 
                Console.WriteLine("No");
            }
            else
            { 
                Console.WriteLine("Exceptional no");
            }

            if (a == b)
                Console.WriteLine("Random event!");
        }
    

        public string GetName()
        {
            return "fate";
        }
    }
}
