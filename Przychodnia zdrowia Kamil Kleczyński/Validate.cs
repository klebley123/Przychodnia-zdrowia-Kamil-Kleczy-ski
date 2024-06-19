using Przychodnia_zdrowia_Kamil_Kleczyński;
using System.Text.RegularExpressions;

namespace Przychodnia_zdrowia_Kamil_Kleczynski
{
    public abstract class Validate
    {
        public string ValidatePerson(Person person)
        {
            if (!IsValidPESEL(person.Pesel))
            {
                return $"Niepoprawny numer PESEL: {person.Pesel}.";
            }
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.Length >= 20)
            {
                return "Niepoprawne imię.";
            }
            if (string.IsNullOrEmpty(person.LastName) || person.LastName.Length >= 30)
            {
                return "Niepoprawne nazwisko.";
            }
            if (string.IsNullOrEmpty(person.Address) || person.Address.Length >= 100)
            {
                return "Niepoprawny adres.";
            }
            if (!string.IsNullOrEmpty(person.Email))
            {
                bool isEmail = Regex.IsMatch(person.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    return "Niepoprawny adres email.";
                }
            }
            if (!string.IsNullOrEmpty(person.PhoneNumber))
            {
                bool isPhoneNumber = Regex.IsMatch(person.PhoneNumber, @"/^(?:(?:(?:(?:\+|00)\d{2})?[ -]?(?:(?:\(0?\d{2}\))|(?:0?\d{2})))?[ -]?(?:\d{3}[- ]?\d{2}[- ]?\d{2}|\d{2}[- ]?\d{2}[- ]?\d{3}|\d{7})|(?:(?:(?:\+|00)\d{2})?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}))$", RegexOptions.IgnoreCase);
                if (!isPhoneNumber)
                {
                    return "Niepoprawny nr. telefonu.";
                }
            }
            return string.Empty;
        }

        protected bool IsValidPESEL(string pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            bool result = false;
            if (pesel.Length == 11)
            {
                int controlSum = CalculateControlSum(pesel, weights);
                int controlNum = controlSum % 10;
                controlNum = 10 - controlNum;
                if (controlNum == 10)
                {
                    controlNum = 0;
                }
                int lastDigit = int.Parse(pesel[pesel.Length - 1].ToString());
                result = controlNum == lastDigit;
            }
            return result;
        }

        private int CalculateControlSum(string input, int[] weights, int offset = 0)
        {
            int controlSum = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(input[i].ToString());
            }
            return controlSum;
        }
    }
}
