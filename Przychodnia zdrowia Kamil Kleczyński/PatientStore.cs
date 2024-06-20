using System;
using System.Linq;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class PatientStore : Validate
    {
        public List<Patient> Patients { get; set; }

        public PatientStore(List<Patient> patients)
        {
            Patients = patients;
        }

        public string Add(Patient patient)
        {
            var message = ValidatePatient(patient);
            if (!string.IsNullOrEmpty(message)) return message;

            if (IsExists(patient.Pesel))
                return $"Istnieje już pacjent o numerze PESEL: {patient.Pesel}";

            Patients.Add(patient);
            return string.Empty;
        }

        public string Update(Patient patient)
        {
            var message = ValidatePatient(patient);
            if (!string.IsNullOrEmpty(message)) return message;

            var patientToUpdate = GetByPesel(patient.Pesel);
            patientToUpdate.IdNumber = patient.IdNumber;
            patientToUpdate.FirstName = patient.FirstName;
            patientToUpdate.LastName = patient.LastName;
            patientToUpdate.Address = patient.Address;
            patientToUpdate.Email = patient.Email;
            patientToUpdate.PhoneNumber = patient.PhoneNumber;
            patientToUpdate.Insurance = patient.Insurance;
            patientToUpdate.MedicalRecordNumber = patient.MedicalRecordNumber;
            patientToUpdate.PrimaryDoctor = patient.PrimaryDoctor;
            patientToUpdate.Weight = patient.Weight;
            patientToUpdate.Height = patient.Height;
            patientToUpdate.BloodGroup = patient.BloodGroup;
            patientToUpdate.DiseaseId = patient.DiseaseId;

            return string.Empty;
        }

        public List<string> GetInfoDefaultPatient()
        {
            var patient = new Patient();
            return patient.GetInfo();
        }

        public List<Patient> GetAll()
        {
            return Patients.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public int GetCount()
        {
            return Patients.Count;
        }

        public Patient GetByPesel(string pesel)
        {
            var person = Patients.FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }

        public Patient GetByIndex(int idx)
        {
            var pat = Patients[idx];
            return pat;
        }

        private bool IsExists(string pesel)
        {
            var patient = Patients.FirstOrDefault(x => x.Pesel == pesel);
            return patient != null;
        }
    }
}