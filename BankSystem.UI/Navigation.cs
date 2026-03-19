using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.UI
{
    public static class Navigation
    {
        public static void SwitchForm(Form currentForm, Form nextForm)
        {
            nextForm.Show();     
            currentForm.Hide(); 
        }
    }
}
