using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public enum GenderEnum
    {
        Male,
        Female,
        Unkown
    }

    [XmlInclude(typeof(Patient))]
    [XmlInclude(typeof(Worker))]
    public abstract class Person : Validate
    {
        private const string DefaultPesel = "00000000000";

        private string _pesel;
        private string _firstName;
        private string _lastName;
        private DateTime? _dateOfBirth;
        private GenderEnum _gender;
        private string _address;
        private string _eMail;
        private string _phoneNumber;
        private bool _insurance;
        private string _iDNumber;
        private Bitmap _photo;

        public string Pesel { get => _pesel; private set => _pesel = value; }
        public string FirstName { get => _firstName; private set => _firstName = value; }
        public string LastName { get => _lastName; private set => _lastName = value; }
        public DateTime? DateOfBirth { get => _dateOfBirth; private set => _dateOfBirth = value; }
        public GenderEnum Gender { get => _gender; private set => _gender = value; }
        public string Address { get => _address; private set => _address = value; }
        public string Email { get => _eMail; private set => _eMail = value; }
        public string PhoneNumber { get => _phoneNumber; private set => _phoneNumber = value; }
        public bool Insurance { get => _insurance; private set => _insurance = value; }
        public string IdNumber { get => _iDNumber; private set => _iDNumber = value; }

        [XmlIgnore]
        public Bitmap Photo { get => _photo; private set => _photo = value; }

        [XmlElement("Photo")]
        public byte[] PhotoSerialized
        {
            get
            { // serialize
                if (_photo == null) 
                    return null;
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        _photo.Save(ms, ImageFormat.Bmp);
                        return ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            set
            {// deserialize
                if (value == null)
                {
                    _photo = null;
                }
                else
                {
                    try
                    {
                        using (var ms = new MemoryStream(value))
                        {
                            _photo = new Bitmap(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        _photo = null;
                    }
                }
            }
        }

        protected Person()
        {
            _pesel = DefaultPesel;
            _iDNumber = "BB123345";
            _firstName = "Jon";
            _lastName = "Kowalski";
            _dateOfBirth = GetDateOfBirth(_pesel);
            _gender = GenderEnum.Male;
            _address = "55-200 Oława, ul. Piękna 16";
            _eMail = "jkowalski@gmal.com";
            _phoneNumber = "112";
            _insurance = true;
        }

        protected Person(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance)
        {
            //var p = IsValidPesel(pesel) ? pesel : DefaultPesel;
            _pesel = pesel;
            _iDNumber = idNumber;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = GetDateOfBirth(pesel);
            _gender = GetGender(pesel);
            _address = address;
            _eMail = email;
            _phoneNumber = phoneNumber;
            _insurance = insurance;
        }

        protected Person(Person person)
        {
            //var p = IsValidPesel(person.Pesel) ? person.Pesel : DefaultPesel;
            _pesel = person._pesel;
            _iDNumber = person._iDNumber;
            _firstName = person._firstName;
            _lastName = person._lastName;
            _dateOfBirth = GetDateOfBirth(_pesel);
            _gender = GetGender(_pesel);
            _address = person._address;
            _eMail = person._eMail;
            _phoneNumber = person._phoneNumber;
            _insurance = person._insurance;
        }

        public virtual (List<string> info, Bitmap image) GetInfo()
        {
            var lista = new List<string>()
            {
                $"Pesel: {_pesel}",
                $"Seria i nr. dokumnetu: {_iDNumber}",
                $"First Name: {_firstName}",
                $"Last Name: {_lastName}",
                $"Date of Birth: {_dateOfBirth:dd.MM.yyyy}",
                $"Gender: {_gender}",
                $"Address: {_address}",
                $"Email: {_eMail}",
                $"Phone Number: {_phoneNumber}",
                $"Insurance: {_insurance}"
            };
            return (lista, _photo);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return _pesel.Equals(person._pesel) && _firstName.Equals(person._firstName) && _lastName.Equals(person._lastName);
            }
            return false;
        }
        //public virtual bool Equals(string pesel)
        //{
        //    return Pesel.Equals(pesel) ;
        //}

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

        protected bool Update(string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance)
        {
            _iDNumber = idNumber;
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _eMail = email;
            _phoneNumber = phoneNumber;
            _insurance = insurance;
            return true; //TODO: Add conditions
        }

        protected bool Update(Person otherPerson)
        {
            _iDNumber = otherPerson._iDNumber;
            _firstName = otherPerson._firstName;
            _lastName = otherPerson._lastName;
            _address = otherPerson._address;
            _eMail = otherPerson._eMail;
            _phoneNumber = otherPerson._phoneNumber;
            _insurance = otherPerson._insurance;
            return true; //TODO: Add conditions
        }
    }
}