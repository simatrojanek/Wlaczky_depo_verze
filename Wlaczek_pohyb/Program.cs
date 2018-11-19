using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wlaczek_pohyb
{
    class Program
    {
        static void Main(string[] args)
        {
            string wlaczek = "=>";
            // string cil = "|°$ $°|";
            int i = 0;

            while (i < 22)
            {
                Thread.Sleep(1000);

                Console.CursorVisible = false;
                Console.SetCursorPosition(i++, 6);
                Console.WriteLine(wlaczek);

                Console.Clear();
            }
        }
    }
}
