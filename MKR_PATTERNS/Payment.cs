using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MKR_PATTERNS
{
    class Payment
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public Recipient Receiver { get; set; }

        public Payment(int id, string purpose, DateTime date, decimal amount, bool isPaid, Recipient receiver)
        {
            Id = id;
            Purpose = purpose;
            Date = date;
            Amount = amount;
            IsPaid = isPaid;
            Receiver = receiver;
        }

    }
}
