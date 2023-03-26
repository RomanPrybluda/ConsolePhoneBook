using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public static class ConsWinTuner
    {

        public static void SetWindowProperty()
        {
            Console.Title = "============ Phone Book ============";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 70;
        }

    }
}
