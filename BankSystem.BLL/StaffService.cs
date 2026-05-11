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
        //Create​ New Customer
        public bool CreateNewCustomer(string name, string pin, string phone, decimal deposit, string currency)
        {
            if (string.IsNullOrEmpty(name) || deposit < 0) return false;

            User newUser = new User { FullName = name, PIN = pin, Phone = phone };
            return _repo.RegisterCustomer(newUser, deposit, currency);
        }
        //Create New Staff
        public  bool CreateNewStaff(string name, string pin, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pin)) return false;

            User newStaff = new User
            {
                FullName = name,
                PIN = pin,
                Phone = phone,
                Role = "Staff" 
            };

            return _repo.RegisterStaff(newStaff);
        }
     
        public DataTable GetUserList(string role)
        {
            if (role == "Customer")
                return _repo.GetAllCustomers();
            else if (role == "Staff")
                return _repo.GetAllStaff();     

            return new DataTable();
        }


        public bool UpdateStaffInfo(User staff) => _repo.UpdateStaff(staff);

        public bool RemoveStaff(int id)
        {
            return _repo.DeleteStaff(id);
        }
    }
}
