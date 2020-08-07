using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Web.Security;
using System.Windows.Forms;

namespace HR
{
    public partial class AddEmployee : Form
    {
        // UserManager userManager = new UserManager();
        //static HttpClient client = new HttpClient();
        string ApiUrl;
        HttpClient httpClient;
        public AddEmployee()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApiUrl);
        }

        private void btnAddEmployee_ClickAsync(object sender, EventArgs e)
        { 
            try
            {  
                // to randomly generate password for the new user
                    string password = Membership.GeneratePassword(12, 1);
                    var user = new UserData()
                    {
                        Name = textFirstName.Text,
                        LastName = textLastName.Text,
                        JobTitle = textJobTitle.Text,
                        Email = textEmail.Text,
                        Mobile = textMobile.Text,
                        Password = password,
                        ManagerID = int.Parse(textManagerID.Text),
                        Role = HRDataLayer.Enums.Roles.Employee,
                        Username = textUserName.Text
                    };

                    var result = httpClient.PostAsJsonAsync<UserData>("users", user).Result;   

                    if (result.IsSuccessStatusCode)
                    {
                        //var readTask = result.Content.ReadAsAsync<UserData>();
                        //readTask.Wait();
                        //var insertedUser = readTask.Result;

                         MessageBox.Show($"{textFirstName.Text} added successfully");
                    }
                    else
                    {
                        // not found?? // 
                        string respons = result.StatusCode.ToString();
                        MessageBox.Show(respons);

                    }
            }
         
            catch (AggregateException ex)
            { //MessageBox.Show(ex.Message); 
                foreach (var errInner in ex.InnerExceptions)
                {
                    Debug.WriteLine(errInner);
                }
             
            }
            catch (Exception ex)
            { //MessageBox.Show(ex.Message); 
                MessageBox.Show($"{ex.Message} or make sure to enter all fildes");

            }
            Program.ClearTextBoxes(this);
        }
    }
}
            
          
      
 