using System;

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
            return FileReader.ReadRandomLine("tables\\EventFocusTable.txt");
        }

        private string GetAction()
        {
            return FileReader.ReadRandomLine("tables\\EventMeaningAction.txt");
        }

        private string GetSubject()
        {
            return FileReader.ReadRandomLine("tables\\EventMeaningSubject.txt");
        }
    }
}
