using System;
using System.Collections.Generic;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class WorkerStore : Validate
    {
        public WorkerStore()
        {
        }

        //public string Add(Worker worker)
        //{
        //    var message = ValidateWorker(worker);
        //    if (!string.IsNullOrEmpty(message)) return message;

        //    if (IsExists(worker))
        //        return $"Istnieje już człowiek o numerze PESEL: {worker.Pesel}";

        //    PersonStore.Instance().People.Add(worker);
        //    return string.Empty;
        //}

        public void Add(Worker worker)
        {
            var message = ValidateWorker(worker);
            if (!string.IsNullOrEmpty(message))
                throw new Exception(message);

            if (IsExists(worker))
                throw new Exception($"Istnieje już człowiek o numerze PESEL: {worker.Pesel}");

            PersonStore.People.Add(worker);
        }

        public string Update(Worker worker)
        {
            var message = ValidateWorker(worker);
            if (!string.IsNullOrEmpty(message)) return message;

            var workerToUpdate = GetByPesel(worker.Pesel);
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.Position = worker.Position;
            workerToUpdate.DateOfHire = worker.DateOfHire;
            workerToUpdate.WorkerId = worker.WorkerId;
            workerToUpdate.Salary = worker.Salary;

            return string.Empty;
        }

        public List<Worker> GetAll()
        {
            return PersonStore.People.Where(x=>x is Worker).OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName).Select(x=>(Worker)x).ToList();
        }

        public int GetCount()
        {
            return GetAll().Count; 
        }

        public Worker GetByPesel(string pesel)
        {
            var person = GetAll().FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }

        public Worker GetByIndex(int idx)
        {
            return GetAll()[idx];
        }

        private bool IsExists(Worker worker)
        {
            foreach(var item in GetAll()) // Workers
            {
                if(item.Equals(worker))
                    return true;
            }
            return false;
        }
    }
}