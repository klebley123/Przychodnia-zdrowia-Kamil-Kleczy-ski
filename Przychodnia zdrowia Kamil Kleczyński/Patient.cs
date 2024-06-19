using Przychodnia_zdrowia_Kamil_Kleczyński;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region konstruktory
        // konstruktor bezargumentowy
        public Patient() : base()
        {
            MedicalRecordNumber = "123456";
            PrimaryDoctor = "Marek Sowula";
            Weight = 90;
            Height = 190;
            BloodGroup = "0RH+";
            Disease = new List<string>();
            DateVisits = new List<DateTime>();
        }

        //// konstruktor wieloargumentowy
        public Patient(string pesel, string idNumber, string firstName, string lastName, string address, string email, string phoneNumber,
                        bool insurance, string medicalRecordNumber, string primaryDoctor, int weight, int height, string bloodGroup,
                        List<string>disease, List<DateTime>dateVisits)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            MedicalRecordNumber = medicalRecordNumber;
            PrimaryDoctor = primaryDoctor;
            Weight = weight;
            Height = height;
            BloodGroup = bloodGroup;
            Disease = new List<string>();
            DateVisits = new List<DateTime>();
        }

        // konstruktor kopiujacy
        public Patient(Patient p) : base(p)
        {
            MedicalRecordNumber = p.MedicalRecordNumber;
            PrimaryDoctor = p.PrimaryDoctor;
            Weight = p.Weight;
            Height = p.Height;
            BloodGroup = p.BloodGroup; 
            Disease.AddRange(p.Disease);
            DateVisits.AddRange(p.DateVisits);
        }

        #endregion

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
            Disease.Add(name);
        }

        public void AddDateVisit(DateTime date)
        {
            DateVisits.Add(date);
        }
    }
}

