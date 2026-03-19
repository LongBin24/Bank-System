using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.DAL;

namespace BankSystem.BLL
{
    public class StaffService
    {

        private UserRepository _repo = new UserRepository();

        //Delete 
        public bool DeleteCustomer(int id)
        {
            return _repo.DeleteCustomer(id);
        }
        //Update 
        public bool UpdateCustomer(User user)
        {
            return _repo.UpdateCustomer(user);
        }
        //Create
        public bool CreateNewCustomer(string name, string pin, string phone, decimal deposit, string currency)
        {
            if (string.IsNullOrEmpty(name) || deposit < 0) return false;

            User newUser = new User { FullName = name, PIN = pin, Phone = phone };
            return _repo.RegisterCustomer(newUser, deposit, currency);
        }
        //Read
        public DataTable GetCustomerList()
        {
            return _repo.GetAllCustomers();
        }
        
    }
}
