using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        public Worker() : base ()
        {
            _position = "-----";
            _workerId = "000";
            _dateOfHire = DateTime.MinValue;
            _salary = 0.0m;
        }

        // konstruktor wieloargumentowy
        public Worker(string pesel, string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, Bitmap photo, string position, string workerId, DateTime dateOfHire, decimal salary)
            : base(pesel, idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo)
        {
            _position = position;
            _workerId = workerId;
            _dateOfHire = dateOfHire;
            _salary = salary;
        }

        // konstruktor kopiujacy
        public Worker(Worker p) : base(p)
        {
            _position = p._position;
            _workerId = p._workerId;
            _dateOfHire = p._dateOfHire;
            _salary = p._salary;
        }

        #endregion

        public override (List<string> info, Bitmap image) GetInfo()
        {
            var info = base.GetInfo();
            info.info.Add($"Position: {_position}");
            info.info.Add($"Employee ID: {_workerId}");
            info.info.Add($"Date of Hire: {_dateOfHire:dd.MM.yyyy}");
            info.info.Add($"Salary: {_salary:C}");
            info.image = Photo;
            return info;
        }

        //public override bool Equals(object obj)
        //{
        //    if (base.Equals(obj))
        //    {
        //        return true;
        //    }
        //    else if (obj is Person)
        //    {
        //        Person other = (Person)obj;
        //        return this.Pesel == other.Pesel && this.FirstName == ;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                if (obj is Worker other)
                {
                    return _position == other._position &&
                           _workerId == other._workerId &&
                           _dateOfHire == other._dateOfHire &&
                           _salary == other._salary;
                }
                return false;
            }
            return false;
        }

        public int CalculateYearsOfService()
        {
            if (_dateOfHire == DateTime.MinValue)
                return 0; 

            DateTime currentDate = DateTime.Now;
            int yearsOfService = currentDate.Year - _dateOfHire.Year;

            if (currentDate.Month < _dateOfHire.Month ||
                (currentDate.Month == _dateOfHire.Month && currentDate.Day < _dateOfHire.Day))
            {
                yearsOfService--;
            }

            return yearsOfService;
        }

        public void AdjustSalaryBasedOnPerformance(int performanceRating)
        {
            decimal increaseAmount = 0;
            if (performanceRating < 3)
            {
                MessageBox.Show("Performance is below expectations. No salary increase.");
                return;
            }
            else if (performanceRating >= 3 && performanceRating <= 5)
            {
                increaseAmount = 0.03m; 
            }
            else if (performanceRating > 5 && performanceRating <= 8)
            {
                increaseAmount = 0.07m; 
            }
            else if (performanceRating > 8)
            {
                increaseAmount = 0.12m; 
            }

            _salary += _salary * increaseAmount;
            MessageBox.Show($"Salary has been increased by {increaseAmount * 100}% to {_salary:C}");
        }

        public bool Update(string idNumber, string firstName, string lastName, string address, string email,
            string phoneNumber, bool insurance, Bitmap photo, string position, string workerId, DateTime dateOfHire, decimal salary)
        {
            base.Update(idNumber, firstName, lastName, address, email, phoneNumber, insurance, photo);
            _position = position;
            _workerId = workerId;
            _dateOfHire = dateOfHire;
            _salary = salary;
            return true; //TODO: Add conditions
        }
        public bool Update(Worker otherWorker)
        {
            base.Update(otherWorker);
            _position = otherWorker._position;
            _workerId = otherWorker._workerId;
            _dateOfHire = otherWorker._dateOfHire;
            _salary = otherWorker._salary;
            return true; //TODO: Add conditions
        }
    }
}