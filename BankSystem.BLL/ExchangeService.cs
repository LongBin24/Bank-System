using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.DAL;

namespace BankSystem.BLL
{
    public class ExchangeService
    {
        
            private AccountRepository _accRepo = new AccountRepository();

            public decimal CalculateResult(decimal amount, decimal rate)
            {
                return amount * rate;
            }

            public bool ConfirmExchange(int accId, decimal deductAmount, decimal addAmount)
            {
                // Logic: ដកលុយពីកុងមួយ (USD) រួចបូកចូលកុងមួយទៀត (KHR) 
                // ឬគ្រាន់តែដកលុយពីកុង រួចឱ្យលុយសុទ្ធទៅអតិថិជន
                return _accRepo.UpdateBalance(accId, deductAmount); // ឧទាហរណ៍សាមញ្ញ
            }
        
    }
}
