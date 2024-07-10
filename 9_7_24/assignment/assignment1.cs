// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
       


            //date into the required format
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("dddd,dd MMMM, yyyy AT hh:mm tt"));

            //date after 10 days of today's date
            DateTime Today = DateTime.Now;   
            DateTime futureDate = Today.AddDays(10);


            Console.WriteLine("Todays Date: " + Today.ToString("d"));
            Console.WriteLine("Date after 10 Days: " + futureDate.ToString());

            //difference
            DateTime startDate = new DateTime(2024,10,11);
            DateTime endDate = new DateTime(2024, 10, 12);
            TimeSpan difference = endDate - startDate;
            int numberOfDays = difference.Days;
            Console.WriteLine(numberOfDays.ToString());

        }
    }
}
