using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    //}
    public static class PersonStore
    {

        private static List<Person> _people = new List<Person>();
        public static List<Person> People
        {
            get => _people;
            set => _people = value;
        }
        

        public static List<Person> GetInOrder()
            =>_people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        

        public static int GetCount()
            => _people.Count;
        

        public static Person GetByIndex(int idx)
            => GetInOrder()[idx];
        
    }
}