using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.BLL
{
    internal class OtpService
    {
        private static string _currentOtp;

        public string GenerateOtp()
        {
            Random res = new Random();
            _currentOtp = res.Next(100000, 999999).ToString();
            return _currentOtp;
        }

        public bool VerifyOtp(string inputOtp)
        {
            return inputOtp == _currentOtp;
        }
    }
}
