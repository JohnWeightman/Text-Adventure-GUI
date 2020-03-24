using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(171, 50);
            Console.SetBufferSize(172, 51);
            DrawGUI.DrawGUIConsole();
            Console.ReadLine();
        }
    }
}
