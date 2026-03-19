using System;
using System.Collections.Generic; 
using BankSystem.Models;
using BankSystem.DAL;

namespace BankSystem.BLL
{
    public class BankService
    {
        private UserRepository _userRepo = new UserRepository();
        private AccountRepository _accRepo = new AccountRepository();
        private TransactionRepository _transRepo = new TransactionRepository();

        public List<TransactionView> GetTransactionHistory(int accountId)
        {
            return _transRepo.GetHistory(accountId);
        }

        public Account GetAccountByUserId(int userId)
        {
            return _accRepo.GetAccountByUserId(userId);
        }

        public string Withdraw(int userId, decimal amount)
        {
            Account acc = _accRepo.GetAccountByUserId(userId);

            if (acc == null) return "រកមិនឃើញគណនីឡើយ!";
            if (acc.Balance < amount) return "សមតុល្យទឹកប្រាក់មិនគ្រប់គ្រាន់ទេ!";

            decimal newBalance = acc.Balance - amount;

            if (_accRepo.UpdateBalance(acc.AccountID, newBalance))
            {
                return "Success";
            }
            return "មានបញ្ហាបច្ចេកទេស ក្នុងការដកប្រាក់!";
        }
        public string Transfer(int senderId, int receiverId, decimal amount, out int refNo)
        {
            refNo = 0;
            if (senderId == receiverId) return "មិនអាចផ្ទេរឱ្យខ្លួនឯងបានទេ!";
            if (amount <= 0) return "ចំនួនទឹកប្រាក់មិនត្រឹមត្រូវ!";

            var senderAcc = _accRepo.GetAccountByUserId(senderId);
            if (senderAcc == null) return "រកមិនឃើញគណនីអ្នកផ្ញើ!";
            if (senderAcc.Balance < amount) return "សមតុល្យមិនគ្រប់គ្រាន់!";

            refNo = _accRepo.ExecuteTransfer(senderId, receiverId, amount);
            return refNo > 0 ? "Success" : "ការផ្ទេរប្រាក់បរាជ័យ!";
        }

        public TransferReceipt ProcessTransfer(int senderAccId, int receiverAccId, decimal amount)
        {
            int refNo = _accRepo.ExecuteTransfer(senderAccId, receiverAccId, amount);

            if (refNo > 0)
            {
                return new TransferReceipt
                {
                   
                    SenderName = _userRepo.GetNameByAccountId(senderAccId),
                    ReceiverName = _userRepo.GetNameByAccountId(receiverAccId),
                    ReferenceNo = refNo,
                    Amount = amount,
                    Date = DateTime.Now
                };
            }
            return null;
        }

        public string Deposit(int userId, decimal amount)
        {
            var acc = _accRepo.GetAccountByUserId(userId);
            if (acc == null) return "រកមិនឃើញគណនី!";

            decimal newBalance = acc.Balance + amount;

            if (_accRepo.UpdateBalance(acc.AccountID, newBalance))
            {
                return "Success";
            }
            return "មានបញ្ហាបច្ចេកទេស!";
        }
    }
}