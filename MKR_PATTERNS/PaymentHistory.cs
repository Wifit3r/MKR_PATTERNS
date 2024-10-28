using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKR_PATTERNS
{
    class PaymentHistory
    {
        public List<Payment> Payments { get; set; }
            public PaymentHistory()
            {
                Payments = new List<Payment>();
            }

            public void AddPayment(Payment payment)
            {
                Payments.Add(payment);
            }
        public void Copy()
        {
            Console.WriteLine("Введіть Id платежу:");
            int searchId = Convert.ToInt32(Console.ReadLine());
            if (searchId > Payments.Count) {
                throw new Exception("Index out of range");
            }
            
            foreach (Payment payment in Payments) {
                int counter = 0;
                if (payment.Id == searchId) {
                    AddPayment(new Payment(Payments.Count+1, payment.Purpose, DateTime.Now, payment.Amount, payment.IsPaid, payment.Receiver));
                    counter++;
                }
                if(counter == 0)
                {
                    Console.WriteLine("Немає елементу з таким id");
                }
            }
        }
    }
}
