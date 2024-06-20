using System.Text.RegularExpressions;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public abstract class Validate
    {
        public string ValidatePerson(Person person)
        {
            if (!IsValidPesel(person.Pesel))
            {
                return $"Niepoprawny numer PESEL: {person.Pesel}.";
            }

            if (!IsValidName(person.FirstName, 20))
            {
                return "Niepoprawne imię.";
            }

            if (!IsValidName(person.LastName, 30))
            {
                return "Niepoprawne nazwisko.";
            }

            if (!IsValidName(person.Address, 50))
            {
                return "Niepoprawny adres.";
            }

            if (!string.IsNullOrEmpty(person.Email) && !IsValidEmail(person.Email))
            {
                return "Niepoprawny adres email.";
            }

            if (!string.IsNullOrEmpty(person.PhoneNumber) && !IsValidPhoneNumber(person.PhoneNumber))
            {
                return "Niepoprawny nr. telefonu.";
            }

            return string.Empty;
        }

        protected bool IsValidPesel(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            var result = false;
            if (pesel.Length == 11)
            {
                var controlSum = CalculateControlSum(pesel, weights);
                var controlNum = controlSum % 10;
                controlNum = 10 - controlNum;
                if (controlNum == 10)
                {
                    controlNum = 0;
                }

                var lastDigit = int.Parse(pesel[pesel.Length - 1].ToString());
                result = controlNum == lastDigit;
            }

            return result;
        }

        protected bool IsValidName(string name, int length)
        {
            return string.IsNullOrEmpty(name) || name.Length >= length;
        }

        protected bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
        }

        protected bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number,
                @"/^(?:(?:(?:(?:\+|00)\d{2})?[ -]?(?:(?:\(0?\d{2}\))|(?:0?\d{2})))?[ -]?(?:\d{3}[- ]?\d{2}[- ]?\d{2}|\d{2}[- ]?\d{2}[- ]?\d{3}|\d{7})|(?:(?:(?:\+|00)\d{2})?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}))$",
                RegexOptions.IgnoreCase);
        }

        private static int CalculateControlSum(string input, int[] weights, int offset = 0)
        {
            var controlSum = 0;
            for (var i = 0; i < input.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(input[i].ToString());
            }

            return controlSum;
        }
    }
}