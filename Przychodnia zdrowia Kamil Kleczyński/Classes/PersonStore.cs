using System;
using System.Collections.Generic;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    //public class PersonStore
    //{
    //    private static PersonStore _instance;

    //    public static PersonStore Instance()
    //    {
    //        if (_instance == null) _instance = new PersonStore();
    //        return _instance;
    //    }

    //    public List<Person> People { get; set; }

    //    private PersonStore()
    //    {
    //        People = new List<Person>();
    //    }

    //    public List<Person> GetAll()
    //    {
    //        return People.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
    //    }

    //    public int GetCount()
    //    {
    //        return GetAll().Count;
    //    }

    //    public Person GetByIndex(int idx)
    //    {
    //        return GetAll()[idx];
    //    }
    //
    public class PersonStore
    {
        private static List<Person> _people = new List<Person>();

        public static List<Person> People { get => _people; private set => _people = value; }
        
        public static List<Person> GetAllInOrder()
        {
            return _people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public static int GetCount()
        {
            return _people.Count;
        }

        public static Person GetByIndex(int idx)
        {
            var orderedPeople = GetAllInOrder();
            if (idx < 0 || idx >= orderedPeople.Count)
            {
                return null;
            }
            return orderedPeople.ElementAt(idx);
        }


        public static Person GetByPesel(string pesel)
        {
            var person = GetAllInOrder().FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }

    }
}