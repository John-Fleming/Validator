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

        }
    }
}
