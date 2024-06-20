using System.Collections.Generic;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class PersonStore : Validate
    {
        public List<Person> Persons { get; set; }

        public string Add(Person person)
        {
            var message = ValidatePerson(person);
            if (string.IsNullOrEmpty(message))
            {
                Persons.Add(person);
                return string.Empty;
            }
            return message;
        }

        public List<Person> GetAll()
        {
            return Persons.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public Person GetByPesel(string pesel)
        {
            var person = Persons.FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new System.Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }
    }
}
