using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class PersonStore
    {
        
        private static PersonStore _instance;
        public static PersonStore Instance()
        {
            if (_instance == null) _instance = new PersonStore();
            return _instance;
        }

        public List<Person> People { get; set; }

        private PersonStore()
        {
            People = new List<Person>();
        }
    }
}
