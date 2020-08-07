using HRDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using HRDataLayer.Managers;
using HRDataLayer.Enums;
using System.Net.Http;
using System.Web.Configuration;
using System.Configuration;
using System.Net.Http.Headers;
using System.Security.Policy;

namespace HR
{
    public partial class LoginForm : Form
    {
     
        string ApiUrl;
        public LoginForm()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();
        }
        UserManager userManager = new UserManager();

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //HTTP GET

                    if (userManager.IsManager(textUserName.Text))
                    {
                      
                        var result = client.GetAsync($"Users/GetLogin?username={textUserName.Text}&password={textPassword.Text}&type={0}").Result;
                        
                        if (result.IsSuccessStatusCode)
                        {
                            ManagerForm form = new ManagerForm();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Somthing went wrong");
                        }
                    }
                    else {
                        MessageBox.Show("You are not authorized");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                   
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    if (!userManager.IsManager(textUserName.Text))
                    {
                      
                        var result = client.GetAsync($"Users/GetLogin?username={textUserName.Text}&password={textPassword.Text}&type={1}").Result;

                        if (result.IsSuccessStatusCode)
                        {

                            EmployeeForm form = new EmployeeForm();
                            form.Show();

                        }
                        else
                        {
                            MessageBox.Show("Somthing went wrong");

                        }
                    }
                    else
                    {
                        MessageBox.Show("You are not authorized");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //public void Login(int roleType) {

        //            try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri("https://localhost:44352/api/");

        //            var result = client.GetAsync($"users?username ={textUserName.Text}?password={textPassword.Text}type?={roleType}").Result;

        //            if (result.IsSuccessStatusCode)
        //            {
        //                if ( roleType == 0) {
        //                    ManagerForm form = new ManagerForm();
        //                    form.Show();
        //                }
        //                else if (roleType == 1){

        //                    EmployeeForm form = new EmployeeForm();
        //                    form.Show();
        //                }

        //            }
        //            else
        //            {
        //                MessageBox.Show("Somthing went wrong");

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
 

