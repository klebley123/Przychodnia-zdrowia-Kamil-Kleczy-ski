using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DiseaseStore
    {
        public List<Disease> Diseases { get; }

        public DiseaseStore(bool withEmpty = true)
        {
            Diseases = new List<Disease>();
            if (withEmpty)
                Diseases.Add(new Disease { Id = 1, Name = "Brak" });

            Diseases.AddRange(new List<Disease>
            {
                new Disease { Id = 2, Name = "Grypa" },
                new Disease { Id = 3, Name = "Ból głowy" },
                new Disease { Id = 4, Name = "Ból brzucha" },
                new Disease { Id = 5, Name = "Nadciśnienie" },
                new Disease { Id = 6, Name = "Koronawirus COVID-19" },
                new Disease { Id = 7, Name = "Depresja" }
            });
        }
    }
}