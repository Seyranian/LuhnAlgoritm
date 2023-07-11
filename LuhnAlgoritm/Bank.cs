using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgoritm
{
    internal class Bank
    {
        int sum = 0;
        bool alternate = false;
        public bool IsCardNumberValid(string number)
        {
            number = new string(number.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                if (alternate)
                {
                    digit *= 2;

                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }
                sum += digit;
                alternate = !alternate;
            }
            Console.WriteLine("Your card is valid!!!");
            return sum % 10 == 0;
        }
    }
}
