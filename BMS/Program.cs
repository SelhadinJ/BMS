/**  ********************************************************
     *                St.Mary's University                  *
     *      Rapid Application Development Assignment        *
     *          Boutique Management System (Boutique_Management_System)            *
     *      Using MVC (Model View Controller) Pattern       *
     *   **********************************************     * 
     *   Developed By 3rd Year Computer Science Students    *
     *        Mohammed Abduselam  &  Selhadin Jemal         *
     *         (RCD/1333/2012)      (RCD/2101/2012)         *
     ********************************************************
*/
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
