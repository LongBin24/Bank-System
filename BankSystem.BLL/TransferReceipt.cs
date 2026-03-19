using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.DAL;

namespace BankSystem.BLL
{
    public class TransferReceipt
    {
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public int ReferenceNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
