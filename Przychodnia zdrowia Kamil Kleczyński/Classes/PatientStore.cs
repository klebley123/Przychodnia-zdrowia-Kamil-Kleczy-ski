using System;
using System.Linq;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class PatientStore 
    {
        private static List<Patient> _patients = new List<Patient>();

        public static List<Patient> Patients { get => _patients; set => _patients = value; }

        public static List<Patient> GetAllInOrder()
        {
            return _patients.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public static int GetCount()
        {
            return _patients.Count;
        }

        public static Patient GetByIndex(int idx)
        {
            return GetAllInOrder()[idx];
        }

        public static Patient GetByPesel(string pesel)
        {
            var patient = GetAllInOrder().FirstOrDefault(x => x.Pesel == pesel);
            if (patient == null)
                throw new Exception($"Brak pacjenta o numerze PESEL:{pesel}");
            return patient;
        }

        public static string Add(Patient patient)
        {

            if (IsExists(patient))
                throw new Exception($"Istnieje już pacjent o numerze PESEL: {patient.Pesel}");
            //return $"Istnieje już pacjent o numerze PESEL: {patient.Pesel}";

            _patients.Add(patient);
            PersonStore.People.Add(patient);
            return string.Empty;
        }

        public static void Update(Patient patient)
        {
            var patientToUpdate = PersonStore.GetByPesel(patient.Pesel) as Patient;
            patientToUpdate.Update(patient);

        }

        private static bool IsExists(Patient patient)
        {
            foreach (var item in PersonStore.GetAllInOrder())
            {
                if (item.Equals(patient))
                    return true;
            }

            return false;
        }
    }
}
