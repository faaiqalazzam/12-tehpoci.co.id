using System;
using System.Windows.Forms;
using Project_KLP_12.Models;
using Project_KLP_12.Presenters;
using Project_KLP_12.Views;

namespace Project_KLP_12
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ILoginView loginView = new Form1();
            IUserRepository userRepository = new UserRepository();
            new LoginPresenter(loginView, userRepository);

            Application.Run((Form)loginView);
        }
    }
}