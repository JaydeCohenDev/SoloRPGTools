using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{
    public class Quit : ICommand
    {
        public void Execute(string[] args)
        {
            System.Environment.Exit(0);
        }

        public string GetName()
        {
            return "quit";
        }
    }
}
