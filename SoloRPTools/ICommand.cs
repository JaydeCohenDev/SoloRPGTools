using System;
using System.Collections.Generic;
using System.Text;

namespace SoloRPTools
{
    public interface ICommand
    {
        string GetName();
        void Execute(string[] args);
    }
}
