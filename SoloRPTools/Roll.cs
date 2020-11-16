using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{
    public class Roll : ICommand
    {
        public string GetName()
        {
            return "roll";
        }
        
        public void Execute(string[] args)
        {
            if (args.Length != 2)
                Console.WriteLine("Invalid arguments. roll 1d10");

            var x = args[1].Split("d");
            int num = int.Parse(x[0]);
            int value = int.Parse(x[1]);

            Console.WriteLine(Dice.RollLog(num, value));
        }

    }
}
