using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public static class Gui
    {

        public static void AppGui()
        {

            var manager = new Manager();


            while (true)
            {
                Console.WriteLine(GuiMenu.MENU_MAIN);
                int itemMainMenu = Validator.GetValidInputMainMenu();

                Console.Clear();

                switch (itemMainMenu)
                {
                    case 1: // Show all contacts
                        {
                            Console.WriteLine(GuiMenu.TOP_SHOW_CONTACT);
                            Console.WriteLine(GuiMenu.TABLE_HEADER);
                            Console.WriteLine(GuiMenu.TABLE_LINE);                            
                            break;
                        }

                    case 2: // Add new contact
                        {
                            Console.WriteLine(GuiMenu.TOP_MENU_ADD_CONTACT);
                            Console.WriteLine(GuiMassage.INPUT_ID);
                            Console.WriteLine(GuiMassage.INPUT_FIRST_NAME);
                            Console.WriteLine(GuiMassage.INPUT_LAST_NAME);
                            Console.WriteLine(GuiMassage.INPUT_PHONE_NUMBER);

                            break;
                        }

                    case 3: // Delete contact by Id
                        {
                            Console.WriteLine(GuiMenu.TOP_MENU_DELETE);
                            Console.WriteLine(GuiMassage.INPUT_ID);

                            break;
                        }

                    case 4: // Find contact
                        {
                            Console.WriteLine(GuiMenu.MENU_FIND);
                            int itemFindMenu = Validator.GetValidInputFindMenu();
                            

                            break;
                        }

                    case 5: // Exit from App
                        {
                            Console.WriteLine(GuiMenu.TOP_MENU_EXIT);
                            ExitFromApp();
                            break;
                        }


                }

                Console.Write(GuiMassage.GO_TO_MAIN_MENU);
                Console.ReadKey();
                Console.Clear();

            }

        }

        public static void ExitFromApp()
        {
            Console.Clear();
            Console.WriteLine(GuiMenu.TOP_MENU_EXIT);
            Console.Write(GuiMassage.EXIT_ASK);

            string exit = Console.ReadLine();

            if (exit.ToLower() == "y")
            {
                Console.Write(GuiMassage.GOODBAY);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

        }


    }

}
