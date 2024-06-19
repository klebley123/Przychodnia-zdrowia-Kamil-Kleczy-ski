using Przychodnia_zdrowia_Kamil_Kleczyński;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Worker : Person
    {
        public string EmployeeID;
        public string Position;
        public DateTime DateOfHire;
        public decimal Salary;

        #region konstruktory
        // konstruktor bezargumentowy
        public Worker() : base()
        {
            EmployeeID = "12345";
            Position = "Lekarz";
            DateOfHire = DateTime.MinValue;
            Salary = 0.0m;
        }

        // konstruktor wieloargumentowy
        public Worker(string pesel, string idNumber, string firstName, string lastName, string address, string email, string phoneNumber,
                         DateTime dateOfVisit, bool insurance, string employeeID, string position, DateTime dateOfHire, decimal salary)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            EmployeeID = employeeID;
            Position = position;
            DateOfHire = dateOfHire;
            Salary = salary;
        }

        // konstruktor kopiujacy
        public Worker(Worker p) : base(p)
        {
            EmployeeID = p.EmployeeID;
            Position = p.Position;
            DateOfHire = p.DateOfHire;
            Salary = p.Salary;
        }
        #endregion

        public override List<string> GetInfo()
        {
            var info = base.GetInfo();
            info.Add($"Employee ID: {EmployeeID}");
            info.Add($"Position: {Position}");
            info.Add($"Date of Hire: {DateOfHire}");
            info.Add($"Salary: {Salary:C}");
            return info;
        }
    }
}
