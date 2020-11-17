using System;

namespace SoloRPTools
{
    public class Scene : ICommand
    {
        public void Execute(string[] args)
        {
            if(args.Length > 1)
            {
                switch(args[1])
                {
                    case "setup":
                        if (args.Length != 3) Console.WriteLine("scene setup <cahosfacto>");

                        int chaosFactor = Math.Clamp(int.Parse(args[2]), 1, 9);
                        int r = Dice.Roll(1, 10);
                        if(r <= chaosFactor)
                        {
                            if (r % 2 == 0)
                                Console.WriteLine("Scene is interrupted!");
                            else
                                Console.WriteLine("Scene is altered!");
                        } else
                        {
                            Console.WriteLine("Everything is as expected");
                        }
                        break;
                }
            }
        }

        public string GetName()
        {
            return "scene";
        }
    }
}
