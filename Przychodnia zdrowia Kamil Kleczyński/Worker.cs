using System;
using System.Collections.Generic;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Worker : Person
    {
        public string EmployeeId;
        public string Position;
        public DateTime DateOfHire;
        public decimal Salary;

        #region konstruktory

        // konstruktor bezargumentowy
        public Worker()
        {
            EmployeeId = "12345";
            Position = "Lekarz";
            DateOfHire = DateTime.MinValue;
            Salary = 0.0m;
        }

        // konstruktor wieloargumentowy
        public Worker(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, string employeeId, string position, DateTime dateOfHire, decimal salary)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            EmployeeId = employeeId;
            Position = position;
            DateOfHire = dateOfHire;
            Salary = salary;
        }

        // konstruktor kopiujacy
        public Worker(Worker p) : base(p)
        {
            EmployeeId = p.EmployeeId;
            Position = p.Position;
            DateOfHire = p.DateOfHire;
            Salary = p.Salary;
        }

        #endregion

        public override List<string> GetInfo()
        {
            var info = base.GetInfo();
            info.Add($"Employee ID: {EmployeeId}");
            info.Add($"Position: {Position}");
            info.Add($"Date of Hire: {DateOfHire:dd.MM.yyyy}");
            info.Add($"Salary: {Salary:C}");
            return info;
        }

        public bool Equals(Worker a, Worker b)
        {
            return base.Equals(a, b);
        }
    }
}