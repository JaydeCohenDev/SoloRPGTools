using System;

namespace SoloRPTools
{
    public class Table : ICommand
    {
        public void Execute(string[] args)
        {
            if (args.Length != 2) Console.WriteLine("Invalid. table <file>");

            string file = args[1];

            try { 
                Console.WriteLine(FileReader.ReadRandomLine(file));
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetName()
        {
            return "table";
        }
    }
}
