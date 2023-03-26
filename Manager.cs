using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    class Manager
    {

        static readonly string path = FileCreater.GetFileCsvPath();
                

        private static List<Contact> ListContact()
        {
            List<Contact> contact = new List<Contact>();

            using (StreamReader readContact = new StreamReader(path))
            {
                while (!readContact.EndOfStream)
                {
                    string line = readContact.ReadLine();
                    var value = line.Split(',');
                    var row = new Contact { Id = value[0], FirstName = value[1], LastName = value[2], PhoneNumber = value[3] };
                    contact.Add(row);
                }
            }

            return contact;
        }


        public static void ShowAllContacts(List<Contact> readContact)
        {

            var rows = ListContact();

            if (rows.Count == 0)
            {
                Console.WriteLine("\n\n  File is empty\n");
            }

            else
            {
                foreach (Contact x in readContact)
                {
                    Console.Write($"\n | {x.Id,3}  | {x.FirstName,-12} | {x.LastName,-12}  |  {x.PhoneNumber,-12}   |");
                    Console.Write(GuiMenu.TABLE_LINE);
                }
            }

        }


        private void AddContact(List<Contact> addContact)
        {            
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Contact row in addContact)
                {
                    writer.WriteLine("{0},{1},{2},{3}", row.Id, row.FirstName, row.LastName, row.PhoneNumber);
                }
            }
        }


        private void WritePhoneBook(List<Contact> rows)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var row in rows)
                {
                    writer.WriteLine("{0},{1},{2},{3}", row.Id, row.FirstName, row.LastName, row.PhoneNumber);
                }
            }
        }


        private static void WritePhoneBook(List<Contact> rows, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var row in rows)
                {
                    writer.WriteLine("{0},{1},{2},{3}", row.Id, row.FirstName, row.LastName, row.PhoneNumber);
                }
            }
        }

        internal void ShowAllContacts(Contacts contacts)
        {
            throw new NotImplementedException();
        }
    }
}
