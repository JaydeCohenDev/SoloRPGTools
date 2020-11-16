using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{
    public class Dice
    {
        private static Random r
        {
            get
            {
                if (rInternal == null)
                    rInternal = new Random();

                return rInternal;
            }
            set { }
        }
        private static Random rInternal;



        public static string RollLog(int n, int v)
        {
            string log = "";
            RollInternal(n, v, out log);
            return log;
        }

        public static int Roll(int n, int v)
        {
            string log = "";
            return RollInternal(n, v, out log);
        }

        private static int RollInternal(int n, int v, out string log)
        {
            int finalValue = 0;
            log = "[";
            for (int i = 0; i < n; i++)
            {
                int rnd = r.Next(1, v + 1);
                log += i == n - 1 ? rnd + "" : rnd + " + ";
                finalValue += rnd;
            }
            log += "] = " + finalValue;
            return finalValue;

        }
    }
}
