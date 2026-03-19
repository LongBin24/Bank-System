using BankSystem.Models;
using BankSystem.DAL;

namespace BankSystem.BLL
{
    public class AuthService
    {
        private UserRepository _userRepo = new UserRepository();

        public BankSystem.Models.User Authenticate(string id, string pin)
        {
       
            if (int.TryParse(id, out int userId))
            {
                return _userRepo.Login(userId, pin);
            }
            return null;
        }
    }
}
