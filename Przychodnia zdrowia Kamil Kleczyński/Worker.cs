using System;
using System.Collections.Generic;
using System.Drawing;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public class Worker : Person, IBasicInfo, IDetails
    {
        private string _position;
        private string _workerId;
        private decimal _salary;        
        private DateTime _dateOfHire;

        public string Position { get => _position; set => _position = value; }
        public string WorkerId {  get => _workerId; set => _workerId = value; }
        public DateTime DateOfHire { get => _dateOfHire; set => _dateOfHire = value; }
        public decimal Salary { get => _salary; set => _salary = value; }

        #region konstruktory

        // konstruktor bezargumentowy
        public Worker()
        {
            Position = "-----";
            WorkerId = "000";
            DateOfHire = DateTime.MinValue;
            Salary = 0.0m;
        }

        // konstruktor wieloargumentowy
        public Worker(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, string position, string workerId, DateTime dateOfHire, decimal salary)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance)
        {
            Position = position;
            WorkerId = workerId;
            DateOfHire = dateOfHire;
            Salary = salary;
        }

        // konstruktor kopiujacy
        public Worker(Worker p) : base(p)
        {
            Position = p.Position;
            WorkerId = p.WorkerId;
            DateOfHire = p.DateOfHire;
            Salary = p.Salary;
        }

        #endregion

        public override (List<string>, Bitmap) GetInfo()
        {
            var info = base.GetInfo();
            info.Item1.Add($"Position: {Position}");
            info.Item1.Add($"Employee ID: {WorkerId}");
            info.Item1.Add($"Date of Hire: {DateOfHire:dd.MM.yyyy}");
            info.Item1.Add($"Salary: {Salary:C}");
            info.Item2 = Photo;
            return info;
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                return true;
            }
            else if (obj is Person)
            {
                Person other = (Person)obj;
                return this.Pesel == other.Pesel;
            }
            else
            {
                return false;
            }
        }
    }
}