using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
     class Program
    {

    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
         }

      

        // this method from codeproject.com
            public static void ClearTextBoxes(Form form)
            {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }

            }
            }

    }
}

