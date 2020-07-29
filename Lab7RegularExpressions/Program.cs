using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Lab7RegularExpressions
{
    class Program
    {
        public static bool ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, @"([A-Z][a-z]){1,30}\w"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateEmail(string email)
        {
            
            if (Regex.IsMatch(email, @"([\w\. \-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidatePhoneNumber(string number)
        {
            if(Regex.IsMatch(number, @"[0-9]{3}\-([0-9]{3})\-[0-9]{4}"))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public static bool ValidateDate(string date)
        {
            if(Regex.IsMatch(date, @"([0-3]{1})([0-9]{1})(/)([0-1]{1})([0-9]{1})(/)([0-9]){4}"))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name with the first letter capitalized. ex John.");
            string input = Console.ReadLine();
            bool name = ValidateFirstName(input);
            
            while (!name)
            {
                Console.WriteLine("Try again");
                name = ValidateFirstName(Console.ReadLine());
            }

            Console.WriteLine("Please enter your email. ex john@test.com");
            string input2 = Console.ReadLine();
            bool email = ValidateEmail(input2);

            while (!email)
            {
                Console.WriteLine("Please enter a valid email.");
                email = ValidateEmail(Console.ReadLine());
            }

            Console.WriteLine("Please enter your phone number in the following format. 555-867-5305");
            string input3 = Console.ReadLine();
            bool number = ValidatePhoneNumber(input3);

            while (!number)
            {
                Console.WriteLine("Please enter a valid phone number. ex 517-867-5309");
                number = ValidatePhoneNumber(Console.ReadLine());
            }

            Console.WriteLine("Please enter the date in the following format. mm/dd/yyyy");
            string input4 = Console.ReadLine();
            bool date = ValidateDate(input4);
            
            while (!date)
            {
                Console.WriteLine("Please enter a VALID date with the format mm/dd/yyy.");
                date = ValidateDate(Console.ReadLine()); 
            }

            Console.WriteLine("Your name is " + input);
            Console.WriteLine("Your email is " + input2);
            Console.WriteLine("Your phone number is " + input3);
            Console.WriteLine("The date is " + input4);

        }


    }
}
