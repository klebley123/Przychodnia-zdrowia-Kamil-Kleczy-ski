using System;
using System.Collections.Generic;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class WorkerStore : Validate
    {
        private List<Worker> Workers { get; }

        public WorkerStore(List<Worker> workers)
        {
            Workers = workers;
        }

        public string Add(Worker worker)
        {
            var message = ValidatePerson(worker);
            if (string.IsNullOrEmpty(message))
            {
                Workers.Add(worker);
                return string.Empty;
            }

            return message;
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

        public List<string> GetInfoDefaultWorker()
        {
            return new Worker().GetInfo();
        }

        public List<Worker> GetAll()
        {
            return Workers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public Worker GetByPesel(string pesel)
        {
            var person = Workers.FirstOrDefault(x => x.Pesel == pesel);
            if (person == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return person;
        }

        public Worker GetByIndex(int idx)
        {
            return Workers[idx];
        }

        public int GetCount()
        {
            return Workers.Count;
        }
    }
}