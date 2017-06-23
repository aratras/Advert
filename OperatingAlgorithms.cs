using System;
using System.Collections.Generic;
using System.Linq;

namespace Advert
{
    public enum SortingType
    {
        AdvertizeDescription,
        PersonName,
        PersonSurname,
        PhoneNumber,
        Price
    }
    public class OperatingAlgorithms
    {
        public static List<AdInfo> CurrentOperating;
        public static List<List<AdInfo>> AllLists;

        

        public static void ChooseList(int index)
        {
            CurrentOperating = AllLists.ElementAt(index);
        }
        public static void CreateEmptyList()
        {
            AllLists.Add(new List<AdInfo>());
        }
        public static void AddEntryToList(AdInfo ad)
        {
            CurrentOperating.Add(ad);
        }
        public static void DeleteEntryFromList(int index)
        {
            CurrentOperating.RemoveAt(index);
        }
        public static void SortAllEntriesInList(SortingType type)
        {

            switch (type)
            {
                case SortingType.AdvertizeDescription:
                    CurrentOperating.OrderBy(r => r.AdvertizeDescription);
                    break;
                case SortingType.PersonName:
                    CurrentOperating.OrderBy(r => r.Person.Name);
                    break;
                case SortingType.PersonSurname:
                    CurrentOperating.OrderBy(r => r.Person.Surname);
                    break;
                case SortingType.PhoneNumber:
                    CurrentOperating.OrderBy(r => r.PhoneNumber);
                    break;
                case SortingType.Price:
                    CurrentOperating.OrderBy(r => r.Price);
                    break;
                default:
                    break;
            }
        }
        public static List<AdInfo> FindEntryInCurrentList(string findKey)
        {
            List<AdInfo> result = new List<AdInfo>();
            if (CurrentOperating.Exists(r => r.AdvertizeDescription.Equals(findKey)))
            {
                result = CurrentOperating.FindAll((r => r.AdvertizeDescription.Equals(findKey)));
                return result;
            }
            if (CurrentOperating.Exists(r => r.Person.Name.Equals(findKey)))
            {
                result = CurrentOperating.FindAll((r => r.Person.Name.Equals(findKey)));
                return result;
            }
            if (CurrentOperating.Exists(r => r.Person.Surname.Equals(findKey)))
            {
                result = CurrentOperating.FindAll((r => r.Person.Surname.Equals(findKey)));
                return result;
            }
            if (CurrentOperating.Exists(r => r.PhoneNumber.Equals(findKey)))
            {
                result = CurrentOperating.FindAll((r => r.PhoneNumber.Equals(findKey)));
                return result;
            }
            if (CurrentOperating.Exists(r => r.Price.Equals(findKey)))
            {
                result = CurrentOperating.FindAll((r => r.Price.Equals(findKey)));
                return result;
            }
            throw new Exception("No Matches found");
        }
    }
}
