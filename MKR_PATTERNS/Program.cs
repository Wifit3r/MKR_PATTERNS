using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MKR_PATTERNS
{
    class Program
    {
        static void Main()
        {
            var receiver = new Recipient("Company A", "123456789");
            var receiver2 = new Recipient("Company B", "000000000");
            var Payment = new Payment(1, "Payment for services", DateTime.Parse("2023-01-01"), 1000.00m, true, receiver);
            var Payment2 = new Payment(2, "Buy a new computer", DateTime.Parse("2024-04-03"), 11111.0m, false, receiver2);
            var history = new PaymentHistory();
            history.AddPayment(Payment);
            history.AddPayment(Payment2);
            Console.WriteLine(Payment2.Purpose);
            history.Copy();
            

            foreach (var payment in history.Payments)
            {
                if (payment != null)
                {
                    Console.WriteLine($"ID: {payment.Id}, Purpose: {payment.Purpose}, Date: {payment.Date}, Amount: {payment.Amount}, Is Paid: {payment.IsPaid}, Receiver: {payment.Receiver.Name}, Code: {payment.Receiver.Code}");
                }
                else { Console.WriteLine("Null :("); }
            }
            
        }
    }
}