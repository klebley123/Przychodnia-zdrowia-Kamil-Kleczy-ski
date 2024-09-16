using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Patient : Person, IDetails, IBasicInfo
    {
        private string _medicalRecordNumber;
        private string _primaryDoctor;
        private int _weight;
        private int _height;
        private string _bloodGroup;

        private List<int> _diseaseId;

        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore();

        public string MedicalRecordNumber { get => _medicalRecordNumber; set => _medicalRecordNumber = value; }
        public string PrimaryDoctor { get => _primaryDoctor; set => _primaryDoctor = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Height { get => _height; set => _height = value; }
        public string BloodGroup { get => _bloodGroup; set => _bloodGroup = value; }
        public List<int> DiseaseId { get => _diseaseId; set => _diseaseId = value; }

        string IBasicInfo.Pesel { get => Pesel; set => Pesel = value; }
        string IBasicInfo.FirstName { get => FirstName; set => FirstName = value; }
        string IBasicInfo.LastName { get => LastName; set => LastName = value; }
        DateTime? IBasicInfo.DateOfBirth { get => DateOfBirth; set => DateOfBirth = value; }
        GenderEnum IBasicInfo.Gender { get => Gender; set => Gender = value; }
        string IBasicInfo.Address { get => Address; set => Address = value; }
        string IBasicInfo.IdNumber { get => IdNumber; set => IdNumber = value; }
        string IDetails.Email { get => Email; set => Email = value; }
        string IDetails.PhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        bool IDetails.Insurance { get => Insurance; set => Insurance = value; }
        Bitmap IDetails.Photo { get => Photo; set => Photo = value; }

        public Patient() : base()
        {
            _medicalRecordNumber = "123456";
            _primaryDoctor = "Marek Sowula";
            _weight = 90;
            _height = 190;
            _bloodGroup = "0 RH+";
            _diseaseId = new List<int>();
        }

        public Patient(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, Bitmap photo, string medicalRecordNumber, string primaryDoctor, int weight,
            int height, string bloodGroup, List<int> disease)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo)
        {
            _medicalRecordNumber = medicalRecordNumber;
            _primaryDoctor = primaryDoctor;
            _weight = weight;
            _height = height;
            _bloodGroup = bloodGroup;
            _diseaseId = disease;
        }

        public Patient(Patient p) : base(p)
        {
            _medicalRecordNumber = p._medicalRecordNumber;
            _primaryDoctor = p._primaryDoctor;
            _weight = p._weight;
            _height = p._height;
            _bloodGroup = p._bloodGroup;
            var tmpDisease = new List<int>();
            tmpDisease.AddRange(p._diseaseId);
            _diseaseId = tmpDisease;
            var tmpDateVisits = new List<DateTime>();
        }

        (List<string>, Bitmap) IBasicInfo.GetInfo()
        {
            List<string> list = new List<string>();
            list.Add($"Pesel: {(this as IBasicInfo).Pesel}");
            list.Add($"Imie: {(this as IBasicInfo).FirstName}");
            list.Add($"Nazwisko: {(this as IBasicInfo).LastName}");
            list.Add($"Data urodzenia: {(this as IBasicInfo).DateOfBirth}");
            list.Add($"Płeć: {(this as IBasicInfo).Gender}");
            list.Add($"Adres: {(this as IBasicInfo).Address}");
            list.Add($"Nr dowodu: {(this as IBasicInfo).IdNumber}");
            //info.Item1.Add($"Pesel: {Pesel}"); 
            //info.Item1.Add($"Medical Record Number: {MedicalRecordNumber}");
            //info.Item1.Add($"Primary Doctor: {PrimaryDoctor}");
            //info.Item1.Add($"Weight: {Weight}");
            //info.Item1.Add($"Height: {Height}");
            //info.Item1.Add($"BloodGroup: {BloodGroup}");
            //info.Item1.Add($"Diseases: {string.Join(", ", GetDisease(DiseaseId))}");

            return (list, Photo);
        }

        (List<string>, Bitmap) IDetails.GetInfo()
        {
            List<string> lista = new List<string>(); //base.GetInfo();
            lista.Add($"Email: {(this as IDetails).Email}");
            lista.Add($"Nr Tel: {(this as IDetails).PhoneNumber}");
            lista.Add($"Ubezpieczenie: {(this as IDetails).Insurance}");

            return (lista, Photo);
        }

        public override (List<string>, Bitmap) GetInfo()
        {
            var basicInfo = ((IBasicInfo)this).GetInfo();
            var details = ((IDetails)this).GetInfo();
            basicInfo.info.AddRange(details.info);
            basicInfo.info.Add($"Medical Record Number: {_medicalRecordNumber}");
            basicInfo.info.Add($"Primary Doctor: {_primaryDoctor}");
            basicInfo.info.Add($"Weight: {_weight}");
            basicInfo.info.Add($"Height: {_height}");
            basicInfo.info.Add($"BloodGroup: {_bloodGroup}");
            basicInfo.info.Add($"Diseases: {string.Join(", ", GetDisease(_diseaseId))}");
            return basicInfo;
        }

        private IEnumerable<string> GetDisease(ICollection<int> ids)
        {
            return ids.Any()
                ? _diseaseStoreStore.Diseases.Where(x => ids.Contains(x.Id)).Select(x => x.Name)
                : _diseaseStoreStore.Diseases.Where(x => x.Id == 1).Select(x => x.Name);
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                if (obj is Patient other)
                {
                    return _medicalRecordNumber == other._medicalRecordNumber &&
                           _primaryDoctor == other._primaryDoctor &&
                           _weight == other._weight &&
                           _height == other._height &&
                           _bloodGroup == other._bloodGroup &&
                           _diseaseId.SequenceEqual(other._diseaseId);
                }
                return false;
            }
            return false;
        }

        public bool Update(string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, Bitmap photo, string medicalRecordNumber, string primaryDoctor, int weight,
            int height, string bloodGroup, List<int> disease)
        {
            base.Update(idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo);
            _medicalRecordNumber = medicalRecordNumber;
            _primaryDoctor = primaryDoctor;
            _weight = weight;
            _height = height;
            _bloodGroup = bloodGroup;
            _diseaseId = disease;
            return true; //TODO: Add conditions
        }

        public bool Update(Patient otherPatient)
        {
            base.Update(otherPatient);
            _medicalRecordNumber = otherPatient._medicalRecordNumber;
            _primaryDoctor = otherPatient._primaryDoctor;
            _weight = otherPatient._weight;
            _height = otherPatient._height;
            _bloodGroup = otherPatient._bloodGroup;
            _diseaseId = otherPatient._diseaseId;
            return true; //TODO: Add conditions
        }
    }
}