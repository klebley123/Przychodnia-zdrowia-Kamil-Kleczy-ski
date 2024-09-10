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
            var info = base.GetInfo();
            //info.Item1.Add($"Medical Record Number: {MedicalRecordNumber}");
            //info.Item1.Add($"Primary Doctor: {PrimaryDoctor}");
            //info.Item1.Add($"Weight: {Weight}");
            //info.Item1.Add($"Height: {Height}");
            //info.Item1.Add($"BloodGroup: {BloodGroup}");
            //info.Item1.Add($"Diseases: {string.Join(", ", GetDisease(DiseaseId))}");
            info.image = Photo;

            return info;
        }

        (List<string>, Bitmap) IDetails.GetInfo()
        {
            List<string> lista = new List<string>(); //base.GetInfo();
            lista.Add($"Medical Record Number: {_medicalRecordNumber}");
            lista.Add($"Primary Doctor: {_primaryDoctor}");
            lista.Add($"Weight: {_weight}");
            lista.Add($"Height: {_height}");
            lista.Add($"BloodGroup: {_bloodGroup}");
            lista.Add($"Diseases: {string.Join(", ", GetDisease(_diseaseId))}");

            return (lista, Photo);
        }

        public override (List<string>, Bitmap) GetInfo()
        {
            var basicInfo = ((IBasicInfo)this).GetInfo();
            var details = ((IDetails)this).GetInfo();
            basicInfo.info.AddRange(details.info);

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