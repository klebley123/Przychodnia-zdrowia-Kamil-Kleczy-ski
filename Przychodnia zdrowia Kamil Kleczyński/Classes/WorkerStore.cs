using System;
using System.Collections.Generic;
using System.Linq;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class WorkerStore 
    {
        private static List<Worker> _workers = new List<Worker>();

        public static List<Worker> Workers { get => _workers; set => _workers = value; }

        public static List<Worker> GetAllInOrder()
        {
            return _workers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }

        public static int GetCount()
        {
            return _workers.Count;
        }

        public static Worker GetByIndex(int idx)
        {
            return GetAllInOrder()[idx];
        }

        public static Worker GetByPesel(string pesel)
        {
            var worker = GetAllInOrder().FirstOrDefault(x => x.Pesel == pesel);
            if (worker == null)
                throw new Exception($"Brak osoby o numerze PESEL:{pesel}");
            return worker;
        }

        public static void Add(Worker worker)
        {
            //var message = ValidateWorker(worker);
            //if (!string.IsNullOrEmpty(message))
            //    throw new Exception(message);

            if (IsExists(worker))
                throw new Exception($"Istnieje już człowiek o numerze PESEL: {worker.Pesel}");

            Workers.Add(worker);
            PersonStore.People.Add(worker);
            
        }

        public static void Update(Worker worker)
        {
            //var message = ValidateWorker(worker);
            //if (!string.IsNullOrEmpty(message)) return message;

            var workerToUpdate = GetByPesel(worker.Pesel);
            workerToUpdate.Update(worker);
        }

        private static bool IsExists(Worker worker)
        {
            foreach(var item in GetAllInOrder()) 
            {
                if(item.Equals(worker))
                    return true;
            }
            return false;
        }
    }
}