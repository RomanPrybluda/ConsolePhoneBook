

using ConsolePhoneBook;
using Microsoft.Azure.KeyVault.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsWinTuner.SetWindowProperty();
        FileCreater.CreateFileCsv();

        Gui.AppGui();


    }
}