using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMPin_App
{
    internal class DebitCard
    {
        private string _pinCode;

        public string PinCode
        {
            set 
            {
                if (IsValidPin(value))
                {
                    _pinCode = value;
                }
            }
            get { return _pinCode; }
        }

        private bool IsValidPin(string pinCode)
        {
            bool isValid = int.TryParse(pinCode, out int number);
            if (isValid && (pinCode.Length == 4 || pinCode.Length == 6))
            {
                Console.WriteLine("Your PIN code successfully created!");
                return true;
            }
            else
            {
                Console.WriteLine("PIN code must be 4 or 6 digits and could contain only numbers!");
                return false;
            }
        }


    }
}
