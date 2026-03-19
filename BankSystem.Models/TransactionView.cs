using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class TransactionView
    {

        public int ID { get; set; }
        public string? Type { get; set; }
        public decimal Amount { get; set; }
        public int? ToAccount { get; set; }
        public DateTime Date { get; set; }
    }
}
