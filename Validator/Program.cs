using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Check PIN input validity

            Console.WriteLine("Please enter a numerical PIN code between 4 and 8 digits:");
            var pinInput = Console.ReadLine();

            var pinLength = pinInput.Length;
            var validPin = true;

            foreach (var c in pinInput)
            {
                if (!char.IsDigit(c))
                {
                    validPin = false;
                    break;
                }
            }

            if (pinLength < 4 || pinLength > 8 || !validPin)
            {
                Console.WriteLine("PIN is invalid");
            }
            else
            {
                Console.WriteLine("PIN is valid");
            }

            // Phone number validation - must be 10 integers; spaces dashes and parentheses are ok; can't start with 555

            Console.WriteLine("Please enter a 10 digit phone number:");
            var phoneInput = Console.ReadLine();
            var concisePhone = phoneInput.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

            var digitCount = 0;
            var invalidChar = false;
            var firstThreeAreFives = false;

            foreach (var c in concisePhone)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    invalidChar = true;
                }
            }

            if (concisePhone[0] == '5' && concisePhone[1] == '5' && concisePhone[2] == '5')
            {
                firstThreeAreFives = true;
            }

            if (digitCount == 10 && !firstThreeAreFives && !invalidChar)
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Not a valid phone number");
            }
        }
    }
}
