using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Declaring the variable

            string FirstName, LastName, AddressLine1, AddressLine2, City, StateProvince, Country;
            int ZipPostal;
            DateTime BirthDate;

            //Assigning the Student Information value to the variable

            FirstName = "Jim";
            LastName = "Gary";
            BirthDate = Convert.ToDateTime("02/20/1999");
            AddressLine1 = "Ridge Apartment";
            AddressLine2 = "Chicago Ave";
            City = "SaltCity";
            StateProvince = "CA";
            ZipPostal = 12345;
            Country = "USA";

            Console.WriteLine("Student Number 101");
            Console.WriteLine("First Name :" + FirstName);
            Console.WriteLine("Last Name :" + LastName);
            Console.WriteLine("Birth date :" + BirthDate);
            Console.WriteLine("Address Line1 :" + AddressLine1);
            Console.WriteLine("Address Line2 :" + AddressLine2);
            Console.WriteLine("City :" + City);
            Console.WriteLine("State/Province :" + StateProvince);
            Console.WriteLine("Zip/Postal :" + ZipPostal);
            Console.WriteLine("Country :" + Country);


            //Getting input from user

            //Console.WriteLine("Enter the First Name :");
            //FirstName = Console.ReadLine();
            //Console.WriteLine("Enter the Last Name :");
            //LastName = Console.ReadLine();
            //Console.WriteLine("Enter the Birth date[mm/dd/yyyy] :");
            //BirthDate = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Enter the Address line1 :");
            //AddressLine1 = Console.ReadLine();
            //Console.WriteLine("Enter the Address line2 :");
            //AddressLine2 = Console.ReadLine();
            //Console.WriteLine("Enter the City :");
            //City = Console.ReadLine();
            //Console.WriteLine("Enter the State/Province :");
            //StateProvince = Console.ReadLine();
            //Console.WriteLine("Enter the Zip/Postal :");
            //ZipPostal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Country :");
            //Country = Console.ReadLine();

            //Console.WriteLine("First Name :" + FirstName);
            //Console.WriteLine("Last Name :" + LastName);
            //Console.WriteLine("Birth Date :" + BirthDate);
            //Console.WriteLine("Address line1 :" + AddressLine1);
            //Console.WriteLine("Address line2 :" + AddressLine2);
            //Console.WriteLine("City :" + City);
            //Console.WriteLine("State/Province :" + StateProvince);
            //Console.WriteLine("Zip/Postal :" + ZipPostal);
            //Console.WriteLine("Country :" + Country);

        }
        
    }
}
