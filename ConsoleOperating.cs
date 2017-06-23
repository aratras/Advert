using System;
using System.Collections.Generic;

namespace Advert
{
    public class ConsoleOperating
    {
        public static AdInfo ReadFromConsole()
        {
            Console.Write("Advertize Description:");
            string advertizeDescription = Console.ReadLine();
            Console.Write("Name of responsible person:");
            string responsibleName = Console.ReadLine();
            Console.Write("Surname of responsible person:");
            string responsibleSurname = Console.ReadLine();
            Console.Write("Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Price:");
            int price = int.Parse(Console.ReadLine());
            return new AdInfo(advertizeDescription, responsibleName, responsibleSurname, phoneNumber, price);
        }
        public static void ShowEntriesInCurrentList(List<AdInfo> toShow)
        {
            foreach (AdInfo item in toShow)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(item.ToString());
            }
        }
        public static void ShowAllLists(List<List<AdInfo>> allLists)
        {
            int index = 0;
            Console.WriteLine("------------------");
            foreach (var item in allLists)
            {
                Console.WriteLine("{0}: {1} entries", index, item.Count);
                index++;
            }
        }
    }
}
