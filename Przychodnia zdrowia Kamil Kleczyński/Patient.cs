using System;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Patient : Person
    {
        public string MedicalRecordNumber { get; set; }
        public string PrimaryDoctor { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string BloodGroup { get; set; }

        public List<string> Disease { get; set; }
        public List<DateTime> DateVisits { get; set; }

        public Patient()
        {
            MedicalRecordNumber = "123456";
            PrimaryDoctor = "Marek Sowula";
            Weight = 90;
            Height = 190;
            BloodGroup = "0RH+";
            Disease = new List<string>();
            DateVisits = new List<DateTime>();
        }

        public Patient(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, string medicalRecordNumber, string primaryDoctor, int weight,
            int height, string bloodGroup, List<string> disease, List<DateTime> dateVisits)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            MedicalRecordNumber = medicalRecordNumber;
            PrimaryDoctor = primaryDoctor;
            Weight = weight;
            Height = height;
            BloodGroup = bloodGroup;
            Disease = disease;
            DateVisits = dateVisits;
        }

        public Patient(Patient p) : base(p)
        {
            MedicalRecordNumber = p.MedicalRecordNumber;
            PrimaryDoctor = p.PrimaryDoctor;
            Weight = p.Weight;
            Height = p.Height;
            BloodGroup = p.BloodGroup;
            var tmpDisease = new List<string>();
            tmpDisease.AddRange(p.Disease);
            Disease = tmpDisease;
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
            info.Add($"Allergies: {string.Join(", ", Disease)}");
            info.Add($"Current Medications: {string.Join(", ", DateVisits)}");
            return info;
        }

        public void AddDisease(string name)
        {
            if (!IsValidName(name, 30))
                throw new Exception("Niepoprawna nazwa choroby.");

            Disease.Add(name);
        }

        public void AddDateVisit(DateTime date)
        {
            DateVisits.Add(date);
        }
    }
}