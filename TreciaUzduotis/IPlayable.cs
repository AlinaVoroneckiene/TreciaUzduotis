using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    interface IPlayable : IOld
    {
        string Kind { get; }
        string ToyName { get; }
        int ToyAmount { get; }
        bool IsExpensive();
        void PrintToScreen();

    }
}
