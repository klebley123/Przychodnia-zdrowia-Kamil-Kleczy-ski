using System;
using System.Collections.Generic;
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
        public List<DateTime> DateVisits { get; set; }

        private readonly DiseaseStore _diseaseStoreStore = new DiseaseStore();

        public Patient()
        {
            MedicalRecordNumber = "123456";
            PrimaryDoctor = "Marek Sowula";
            Weight = 90;
            Height = 190;
            BloodGroup = "0RH+";
            DiseaseId = new List<int>();
            DateVisits = new List<DateTime>();
        }

        public Patient(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, string medicalRecordNumber, string primaryDoctor, int weight,
            int height, string bloodGroup, List<int> disease, List<DateTime> dateVisits)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            MedicalRecordNumber = medicalRecordNumber;
            PrimaryDoctor = primaryDoctor;
            Weight = weight;
            Height = height;
            BloodGroup = bloodGroup;
            DiseaseId = disease;
            DateVisits = dateVisits;
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
            tmpDateVisits.AddRange(p.DateVisits);
            DateVisits = tmpDateVisits;
        }

        public override List<string> GetInfo()
        {
            var info = base.GetInfo();
            info.Add($"Medical Record Number: {MedicalRecordNumber}");
            info.Add($"Primary Doctor: {PrimaryDoctor}");
            info.Add($"Weight: {Weight}");
            info.Add($"Height: {Height}");
            info.Add($"BloodGroup: {BloodGroup}");
            info.Add($"Diseases: {string.Join(", ", GetDisease(DiseaseId))}");
            info.Add($"Date Visits: {string.Join(", ", GetDateVisits(DateVisits))}");
            return info;
        }

        public bool Equals(Patient a, Patient b)
        {
            return base.Equals(a, b);
        }

        private IEnumerable<string> GetDisease(ICollection<int> ids)
        {
            return ids.Any()
                ? _diseaseStoreStore.Diseases.Where(x => ids.Contains(x.Id)).Select(x => x.Name)
                : _diseaseStoreStore.Diseases.Where(x => x.Id == 1).Select(x => x.Name);
        }

        private static IEnumerable<string> GetDateVisits(ICollection<DateTime> dateVisits)
        {
            return dateVisits.Any() ? dateVisits.Select(x => x.ToString("dd.MM.yyyy")) : new List<string> { "Brak" };
        }
    }
}