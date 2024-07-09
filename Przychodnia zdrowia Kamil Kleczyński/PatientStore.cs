using System;
using System.Linq;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class PatientStore : Validate
    {
        //private List<Patient> Patients { get; set; }

        public PatientStore(List<Patient> patients)
        {
            //Patients = patients;
        }

        public string Add(Patient patient)
        {
            var message = ValidatePatient(patient);
            if (!string.IsNullOrEmpty(message)) return message;

            if (IsExists(patient))
                return $"Istnieje już pacjent o numerze PESEL: {patient.Pesel}";

            //Patients.Add(patient);
            PersonStore.Instance().People.Add(patient);
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

        public void UpdateList(List<Patient> patients)
        {
            //Patients = patients;
            //to do: poprawic
            PersonStore.Instance().People = patients.Select(x=>(Person)x).ToList();
        }

        public List<string> GetInfoDefaultPatient()
        {
            var patient = new Patient();
            return patient.GetInfo();
        }

        public List<Patient> GetAll()
        {
            //return Patients.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            return PersonStore.Instance().People.Where(x=>x is Patient)
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x=>(Patient)x).ToList();
        }

        public int GetCount()
        {
            //return Patients.Count;
            return GetAll().Count;
        }

        public Patient GetByPesel(string pesel)
        {
            //var person = Patients.FirstOrDefault(x => x.Pesel == pesel);
            var person = GetAll().FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }

        public Patient GetByIndex(int idx)
        {
            //return Patients[idx];
            return GetAll()[idx];
        }

        private bool IsExists(Patient patient)
        {
            foreach (var item in GetAll()) //Patients)
            {
                if (item.Equals(patient))
                    return true;
            }
            return false;
            //var patient = Patients.FirstOrDefault(x => x.Pesel == pesel);
            //return patient != null;
        }
    }
}