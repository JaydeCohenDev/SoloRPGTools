using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{
    public class DetailCheck : ICommand
    {
        public void Execute(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Invalid. detailcheck <chaosfactor>");
                return;
            }

            int chaosFactor = Math.Clamp(int.Parse(args[1]), 1, 9);
            int chaosMod = chaosFactor <= 3 ? +2 : chaosFactor <= 8 ? 0 : -2;
            int focusN = Math.Clamp(Dice.Roll(2, 10) + chaosMod, 0, 14);

            string focus = FileReader.ReadLine("tables\\DetailCheckFocus.txt", focusN);
            string action = FileReader.ReadRandomLine("tables\\DetailAction.txt");
            string descr = FileReader.ReadRandomLine("tables\\DetailDescriptor.txt");

            Console.WriteLine($"Focus: {focus} | {action} {descr}");

        }

        public string GetName()
        {
            return "detailcheck";
        }
    }
}
