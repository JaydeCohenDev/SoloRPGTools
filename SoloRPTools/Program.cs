using System;
using System.Collections.Generic;

namespace SoloRPTools
{
    class Program
    {
        private static List<ICommand> Commands = new List<ICommand>();

        static void Main(string[] args)
        {
            Commands.Add(new Roll());
            Commands.Add(new Quit());
            Commands.Add(new Fate());
            Commands.Add(new REvent());
            Commands.Add(new Scene());

            while (true) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[SoloRPGTools]> ");
                string input = Console.ReadLine();
                Console.WriteLine(input);
                Console.ForegroundColor = ConsoleColor.Yellow;
                ProcessInput(input);
            }
        }

        static void ProcessInput(string input)
        {
            string[] args = input.Split(" ");
            foreach (var c in Commands)
            {
                if (c.GetName() == args[0])
                {
                    c.Execute(args);
                    return;
                }
            }
            Console.WriteLine("Command not found.");
        }
    }
}
