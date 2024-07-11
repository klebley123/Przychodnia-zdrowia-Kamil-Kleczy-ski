using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Patient : Person
    {
        public string MedicalRecordNumber { get; set; }
        public string PrimaryDoctor { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string BloodGroup { get; set; }

        public List<int> DiseaseId { get; set; }

        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore();

        public Patient()
        {
            MedicalRecordNumber = "123456";
            PrimaryDoctor = "Marek Sowula";
            Weight = 90;
            Height = 190;
            BloodGroup = "0 RH+";
            DiseaseId = new List<int>();
        }

        public Patient(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, string medicalRecordNumber, string primaryDoctor, int weight,
            int height, string bloodGroup, List<int> disease)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            MedicalRecordNumber = medicalRecordNumber;
            PrimaryDoctor = primaryDoctor;
            Weight = weight;
            Height = height;
            BloodGroup = bloodGroup;
            DiseaseId = disease;
        }

        public Patient(Patient p) : base(p)
        {
            MedicalRecordNumber = p.MedicalRecordNumber;
            PrimaryDoctor = p.PrimaryDoctor;
            Weight = p.Weight;
            Height = p.Height;
            BloodGroup = p.BloodGroup;
            var tmpDisease = new List<int>();
            tmpDisease.AddRange(p.DiseaseId);
            DiseaseId = tmpDisease;
            var tmpDateVisits = new List<DateTime>();
        }

        public override (List<string>, Bitmap) GetInfo()
        {
            var info = base.GetInfo();
            info.Item1.Add($"Medical Record Number: {MedicalRecordNumber}");
            info.Item1.Add($"Primary Doctor: {PrimaryDoctor}");
            info.Item1.Add($"Weight: {Weight}");
            info.Item1.Add($"Height: {Height}");
            info.Item1.Add($"BloodGroup: {BloodGroup}");
            info.Item1.Add($"Diseases: {string.Join(", ", GetDisease(DiseaseId))}");
            info.Item2 = Photo;

            return info;
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
                return true;
            }
            else if(obj is Person)
            {
                Person other = (Person)obj;
                return this.Pesel == other.Pesel;
            }
            else
            {
                return false;
            }
        }
    }
}