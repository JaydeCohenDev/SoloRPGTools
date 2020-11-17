using System;
using System.Collections.Generic;
using System.Linq;

namespace SoloRPTools
{
    public class Program
    {
        private static List<ICommand> Commands = new List<ICommand>();

        static void Main(string[] args)
        {
            LoadCommands();


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

        private static void LoadCommands()
        {
            var iType = typeof(ICommand);
            var all = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => iType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => Activator.CreateInstance(x));

            foreach (var a in all)
                Commands.Add((ICommand)a);
        }
    }
}
