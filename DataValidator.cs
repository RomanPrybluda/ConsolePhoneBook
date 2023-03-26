using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public static class Validator
    {

        public static int GetValidInputMainMenu()
        {
            int inputMmenu;
            bool inputIsValid;

            do
            {
                Console.Write(GuiMassage.INPUT_MENU_ITEM);
                string itemMainMenu = Console.ReadLine();

                inputIsValid = int.TryParse(itemMainMenu, NumberStyles.Integer, CultureInfo.InvariantCulture, out inputMmenu) && inputMmenu >= 1 && inputMmenu <= 5;

                if (!inputIsValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(GuiMassage.INPUT_INVALID_MAIN_MENU_ITEM);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (!inputIsValid);

            return inputMmenu;
        }


        public static int GetValidInputFindMenu()
        {
            int inputFmenu;
            bool inputIsValid;

            do
            {
                Console.Write(GuiMassage.INPUT_MENU_ITEM);
                string itemFindMenu = Console.ReadLine();

                inputIsValid = int.TryParse(itemFindMenu, NumberStyles.Integer, CultureInfo.InvariantCulture, out inputFmenu) && inputFmenu >= 1 && inputFmenu <= 4;

                if (!inputIsValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(GuiMassage.INPUT_INVALID_FIND_MENU_ITEM);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (!inputIsValid);

            return inputFmenu;
        }
    }
}
