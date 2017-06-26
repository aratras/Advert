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
        public List<AdInfo> CurrentOperating;
        public List<List<AdInfo>> AllLists;

        public OperatingAlgorithms()
        {
            CurrentOperating = new List<AdInfo>();
            AllLists = new List<List<AdInfo>>();
        }

        public void ChooseList(int index)
        {
            CurrentOperating = AllLists.ElementAt(index);
        }
        public void CreateEmptyList()
        {
            AllLists.Add(new List<AdInfo>());
        }
        public void AddEntryToList(AdInfo ad)
        {
            CurrentOperating.Add(ad);
        }
        public void DeleteEntryFromList(int index)
        {
            CurrentOperating.RemoveAt(index);
        }
        public List<AdInfo> SortAllEntriesInList(List<AdInfo> sortList, SortingType type)
        {
            List<AdInfo> sorted = new List<AdInfo>();
            switch (type)
            {
                case SortingType.AdvertizeDescription:
                    sorted = sortList.OrderBy(sort => sort.AdvertizeDescription).ToList();
                    break;
                case SortingType.PersonName:
                    sorted = sortList.OrderBy(sort => sort.Person.Name).ToList();
                    break;
                case SortingType.PersonSurname:
                    sorted = sortList.OrderBy(sort => sort.Person.Surname).ToList();
                    break;
                case SortingType.PhoneNumber:
                    sorted = sortList.OrderBy(sort => sort.PhoneNumber).ToList();
                    break;
                case SortingType.Price:
                    sorted = sortList.OrderBy(sort => sort.Price).ToList();
                    break;
                default:
                    break;
            }
            return sorted;
        }
        public List<AdInfo> FindEntryInCurrentList(List<AdInfo> findList, string findKey)
        {
            List<AdInfo> result = new List<AdInfo>();
            if (findList.Exists(r => r.AdvertizeDescription.Equals(findKey)))
            {
                result = findList.FindAll((r => r.AdvertizeDescription.Equals(findKey))).ToList();
                return result;
            }
            if (findList.Exists(r => r.Person.Name.Equals(findKey)))
            {
                result = findList.FindAll((r => r.Person.Name.Equals(findKey))).ToList();
                return result;
            }
            if (findList.Exists(r => r.Person.Surname.Equals(findKey)))
            {
                result = findList.FindAll((r => r.Person.Surname.Equals(findKey))).ToList();
                return result;
            }
            if (findList.Exists(r => r.PhoneNumber.Equals(findKey)))
            {
                result = findList.FindAll((r => r.PhoneNumber.Equals(findKey))).ToList();
                return result;
            }
            if (findList.Exists(r => r.Price.Equals(findKey)))
            {
                result = findList.FindAll((r => r.Price.Equals(findKey))).ToList();
                return result;
            }
            throw new Exception("No Matches found");
        }
    }
}
