using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public static class GuiMenu
    {

        public const string MENU_MAIN =            "\n  ========== MAIN MENU =========\n\n" +
                                                     "  1. Show all contacts\n" +
                                                     "  2. Add new contact\n" +
                                                     "  3. Delete contact by Id\n" +
                                                     "  4. Find contact\n" +
                                                     "  5. Exit\n" +
                                                   "\n  ==============================";


        public const string TOP_SHOW_CONTACT =     "\n  ===================== CONTACT LIST =====================\n";

        public const string TABLE_LINE =             "  ------|--------------|---------------|------------------";

        public const string TABLE_HEADER =           "    ID  |  First name  |  Last name    |   Phone number   ";

        public const string TOP_MENU_ADD_CONTACT = "\n  ======= ADD CONTACT =======\n";

        public const string TOP_MENU_DELETE =      "\n  ======= DELETE CONTACT =======\n";

        public const string MENU_FIND =            "\n  ======== FIND CONTACT ========\n\n" +
                                                     "  1. By First name\n" +
                                                     "  2. By Last name\n" +
                                                     "  3. By phone number\n" +
                                                     "  4. By Id\n" +
                                                   "\n  ==============================";

        public const string TOP_MENU_FIND =        "\n  ======== FIND CONTACT ========";

        public const string TOP_MENU_EXIT =        "\n  ============ EXIT ============";

    }
}
