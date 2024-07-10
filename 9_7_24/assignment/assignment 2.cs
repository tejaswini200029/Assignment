// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Threading;
namespace myproductDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter unit Price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity");
            int quantity = int.Parse(Console.ReadLine());

            double totalAmount = unitPrice * quantity;
            Console.WriteLine("total amount without Discount: " +totalAmount);

            double discount = 0;
            if (totalAmount > 5000)
            {
                discount = 0.20 *totalAmount;
            }
            else if (totalAmount > 3000)
            {
                discount = 0.15 *totalAmount;
            }
            else if (totalAmount > 1000) ;
            discount = 0.10*totalAmount;

                double discountAmount =totalAmount*discount;
            double finalAmount =totalAmount-discountAmount;
            Console.WriteLine("discount applied: {discount:}"+discount);
            Console.WriteLine("Discount amount:{discountAmount: }"+discountAmount);
            Console.WriteLine("Final amount with discount{finalAmount: "+finalAmount);


                
        }
    }

}


