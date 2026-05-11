namespace BankSystem.UI
{
    internal static class Program
    {
       
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}