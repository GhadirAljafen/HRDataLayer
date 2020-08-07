using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace HR
{
    public partial class ManagerForm : Form
    {

        // UserManager userManager = new UserManager();
        string ApiUrl;
        HttpClient httpClient;
        public ManagerForm()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApiUrl);
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            form.Show();

        }

        private void btnDisplayVacation_Click(object sender, EventArgs e)
        {
            try
            {
                    var result = httpClient.GetAsync("vacations").Result;
                   
                    if (result.IsSuccessStatusCode)
                    {

                        var vacations = result.Content.ReadAsAsync<VacationData[]>().Result;
                        foreach (var vacation in vacations)
                        {
                            dataGrid.DataSource = vacations;
                        }
                    }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btnDisplayEmployee_Click(object sender, EventArgs e)
        {

            try
            {
                    //HTTP GET
                    var result = httpClient.GetAsync("users").Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var users = result.Content.ReadAsAsync<UserData[]>().Result;
                        foreach (var user in users)
                        {
                           
                            dataGrid.DataSource = users;
                        }
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                //HTTP delete
             var result = httpClient.DeleteAsync($"users/{textIdToDelete.Text}").Result;
            if (result.IsSuccessStatusCode)
            {
                MessageBox.Show($"User with ID = {textIdToDelete.Text} deleted successfully");
            }
        }
    }
}


//using (HRContext context = new HRContext())
//{
//    // var vacations =( from v in context.Vacations select v).ToList();
//    // dataGrid.DataSource = vacations;
//    var innerJoinQuery = (
// from v in context.Vacations
// join u in context.Users on v.EmployeeID equals u.UserID
// select new { u.Name, v.VacationID, v.Type, v.Status, v.StartDate, v.EndDate, v.Description, v.Attatchment }).ToList();
//    dataGrid.DataSource = innerJoinQuery;


//}