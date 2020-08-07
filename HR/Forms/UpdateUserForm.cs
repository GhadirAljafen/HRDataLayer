using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace HR
{
    public partial class UpdateUserForm : Form
    {

        HttpClient httpClient;
        string ApiUrl;
        
        public UpdateUserForm()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApiUrl);
        }

        private void btnSaveNewInfo_Click(object sender, EventArgs e)
        {
            try
            {
               
                var user = new UserData()
                {
                    UserID = int.Parse(textUserID.Text),
                    Email = textNewEmail.Text,
                    Mobile = textNewMobile.Text,
                };

                var result = httpClient.PutAsJsonAsync<UserData>($"users/{textUserID.Text}",user).Result;

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    // not found?? // 
                    string respons = result.StatusCode.ToString();
                    MessageBox.Show(respons);

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"{ex.Message} or make sure to enter all fildes");
            }
            Program.ClearTextBoxes(this);
        }
    }
}
    

