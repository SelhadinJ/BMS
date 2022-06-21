using System;
using System.Windows.Forms;

namespace Boutique_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new User().DoesExist())
                if (new User().SingleUser())
                    Application.Run(new FirstLogin(new User().GetSuperAdmin()));
                else Application.Run(new NotFirstLogin());
            else Application.Run(new WelcomePage());
        }
    }
}
