using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public static class FileCreater
    {

        public static string GetFileCsvPath()

        {
            string getPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return getPath;
        }


        public static string CreateFileCsv()

        {

            string folderName = "MyConsolePhoneBook";
            string fileName = "MyConsolePhoneBook.csv";

            string pathFile = FileCreater.GetFileCsvPath();

            string folderPath = Path.Combine(pathFile, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }


            File.Create(filePath).Dispose();

            return pathFile;

        }

    }
}