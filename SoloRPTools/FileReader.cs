using System;
using System.IO;

namespace SoloRPTools
{
    public class FileReader
    {
        public static string[] ReadLines(string path)
        {
            string fpath = Directory.GetCurrentDirectory() + "\\" + path;
            string[] lines = System.IO.File.ReadAllLines(fpath);
            return lines;
        }

        public static string ReadRandomLine(string path)
        {
            string[] lines = ReadLines(path);
            return lines[new Random().Next(0, lines.Length)];
        }
    }
}
