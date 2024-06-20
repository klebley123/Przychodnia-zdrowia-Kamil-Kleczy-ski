using System;
using System.Linq;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public enum GenderEnum
    {
        Male,
        Female,
        Unkown
    }

    public abstract class Person : Validate
    {
        public string Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Insurance { get; set; }
        public string IdNumber { get; set; }

        private const string DefaultPesel = "00000000000";

        protected Person()
        {
            Pesel = DefaultPesel;
            IdNumber = "BB123345";
            FirstName = "Jon";
            LastName = "Kowalski";
            DateOfBirth = GetDateOfBirth(Pesel);
            Gender = GenderEnum.Male;
            Address = "55-200 Oława, ul. Piękna 16";
            Email = "jkowalski@gmal.com";
            PhoneNumber = "112";
            Insurance = true;
        }

        protected Person(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance)
        {
            var p = IsValidPesel(pesel) ? pesel : DefaultPesel;
            Pesel = p;
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = GetDateOfBirth(p);
            Gender = GetGender(p);
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Insurance = insurance;
        }


        protected Person(Person person)
        {
            var p = IsValidPesel(person.Pesel) ? person.Pesel : DefaultPesel;
            Pesel = p;
            IdNumber = person.IdNumber;
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = GetDateOfBirth(p);
            Gender = GetGender(p);
            Address = person.Address;
            Email = person.Email;
            PhoneNumber = person.PhoneNumber;
            Insurance = person.Insurance;
        }

        public virtual List<string> GetInfo()
        {
            return new List<string>()
            {
                $"Pesel: {Pesel}",
                $"Seria i nr. dokumnetu: {IdNumber}",
                $"First Name: {FirstName}",
                $"Last Name: {LastName}",
                $"Date of Birth: {DateOfBirth:dd.MM.yyyy}",
                $"Gender: {Gender}",
                $"Address: {Address}",
                $"Email: {Email}",
                $"Phone Number: {PhoneNumber}",
                $"Insurance: {Insurance}"
            };
        }

        public virtual bool Equals(string pesel)
        {
            return Pesel.Equals(pesel);
        }

        private DateTime? GetDateOfBirth(string pesel)
        {
            if (!IsValidPesel(pesel))
                return null;

            var peselInt = pesel.Select(x => int.Parse(x.ToString())).ToArray();
            var year = 1900 + peselInt[0] * 10 + peselInt[1];
            if (peselInt[2] >= 2 && peselInt[2] < 8)
            {
                year += (int)Math.Floor((decimal)peselInt[2] / 2) * 100;
            }

            if (peselInt[2] >= 8)
            {
                year -= 100;
            }

            var month = (peselInt[2] % 2) * 10 + peselInt[3];
            var day = peselInt[4] * 10 + peselInt[5];

            return new DateTime(year, month == 0 ? 1 : month, day == 0 ? 1 : day);
        }

        private GenderEnum GetGender(string pesel)
        {
            if (!IsValidPesel(pesel))
                return GenderEnum.Unkown;

            var peselInt = pesel.Select(x => int.Parse(x.ToString())).ToArray();
            return peselInt[9] % 2 == 1 ? GenderEnum.Male : GenderEnum.Female;
        }
    }
}