using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateNames();
            ValdiateEmails();
            ValidatePhonenumbers();
            ValidateDate();

        }

        public static void ValidateNames()
        {
            Console.Write("Please enter a name: ");
            string input = Console.ReadLine();
            bool match = Regex.IsMatch(input, @"^([A-Z]{1}[A-Za-z]{1,29})$");
            if (match)
            {
                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Sorry, name is NOT valid");
            }

        }

        public static void ValdiateEmails()
        {
            Console.Write("Please enter an email: ");
            string input = Console.ReadLine();
            bool match = Regex.IsMatch(input, @"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})$");
            if (match)
            {
                Console.WriteLine("Email is valid."); 
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid");
            }
        }


        public static void ValidatePhonenumbers()
        {
            Console.Write("Please enter a phone number (123-456-7890):  ");
            string input = Console.ReadLine();
            bool match = Regex.IsMatch(input, @"^(\d{3})-(\d{3})-(\d{4})$");
            if (match)
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Phone number is NOT valid");
            }
        }

        public static void ValidateDate()
        {
            Console.Write("Please enter a date (dd/mm/yyyy): ");
            string input = Console.ReadLine();
            bool match = Regex.IsMatch(input, @"^((0|1)\d{1})/((0|1|2|3)\d{1})/([0-9]{4})$"); 
            if (match)
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is NOT valid");
            }
        }
        
    }
}
        
