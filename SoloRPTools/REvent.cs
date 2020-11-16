using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SoloRPTools
{
    public class REvent : ICommand
    {
        public string GetName()
        {
            return "revent";
        }

        public void Execute(string[] args)
        {
            if (args.Length != 1)
            {
                switch(args[1])
                {
                    case "focus":
                        Console.WriteLine(GetFocus());
                        break;
                    case "action":
                        Console.WriteLine(GetAction());
                        break;
                    case "subject":
                        Console.WriteLine(GetSubject());
                        break;
                    case "meaning":
                        Console.WriteLine(GetAction() + " " + GetSubject());
                        break;
                    default:
                        Console.WriteLine("Unknown command: " + args[1]);
                        break;
              }
            } else
            {
                Console.WriteLine($"Focus: {GetFocus()} Meaning: {GetAction()} {GetSubject()}");
            }
        }

        private string GetFocus()
        {
            string path = Directory.GetCurrentDirectory()+ "\\tables\\EventFocusTable.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines[new Random().Next(0, 100)];
        }

        private string GetAction()
        {
            string path = Directory.GetCurrentDirectory() + "\\tables\\EventMeaningAction.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines[new Random().Next(0, 100)];
        }

        private string GetSubject()
        {
            string path = Directory.GetCurrentDirectory() + "\\tables\\EventMeaningSubject.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines[new Random().Next(0, 100)];
        }
    }
}
