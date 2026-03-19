using System;
using System.Drawing;
using System.Drawing.Printing;

namespace BankSystem.UI
{
    public class ReceiptPrinter
    {
 
        private string _accountID;
        private decimal _amount;
        private string _currency;
        private decimal _currentBalance;
        private string _transactionType;

        public void Print(string accID, decimal amt, string curr, decimal bal, string type)
        {
            _accountID = accID;
            _amount = amt;
            _currency = curr;
            _currentBalance = bal;
            _transactionType = type;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPageEvent);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }
        private void PrintPageEvent(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Khmer OS Muol Light", 12, FontStyle.Bold);
            Font fBody = new Font("Khmer OS Battambang", 10);
            float y = 50;

            g.DrawString("បង្កាន់ដៃប្រតិបត្តិការ", fTitle, Brushes.Black, 80, y);
            y += 50;
            g.DrawString("ប្រភេទ: " + _transactionType, fBody, Brushes.Black, 50, y); y += 30;
            g.DrawString("លេខគណនី: " + _accountID, fBody, Brushes.Black, 50, y); y += 30;
            g.DrawString("ចំនួនទឹកប្រាក់: " + _amount.ToString("N2") + " " + _currency, fBody, Brushes.Black, 50, y); y += 30;
            g.DrawString("សមតុល្យនៅសល់: " + _currentBalance.ToString("N2"), fBody, Brushes.Black, 50, y);
        }
    }
}