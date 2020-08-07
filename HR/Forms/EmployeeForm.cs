using HRDataLayer.Enums;
using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace HR
{
    public partial class EmployeeForm : Form
    {
        string ApiUrl;
        HttpClient httpClient;
        public EmployeeForm()
        {
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"].ToString();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApiUrl);
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            form.Show();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                    var type = Types.Sick;
                    if (radioButtonLeave.Checked) type = Types.Leave;
                    else if (radioButtonExeptional.Checked) type = Types.Exeptional;
                    else if (radioButtonAnnual.Checked) type = Types.Annual;
                    var newVacation = new VacationData
                    {
                        Type = type,
                        Status = Statuses.Pending,
                        Attatchment = textAttatchment.Text,
                        Description = richTextDescription.Text,
                        StartDate = DateTime.Parse(dateTimeStart.Text),
                        EndDate = DateTime.Parse(dateTimeEnd.Text),
                        EmployeeID = int.Parse(textID.Text),
                    };
                    var postTask = httpClient.PostAsJsonAsync<VacationData>("vacations", newVacation);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        var readTask = result.Content.ReadAsAsync<VacationData>();
                        readTask.Wait();
                        var insertedUser = readTask.Result;

                    }
                    else
                    {
                        string respons = result.StatusCode.ToString();
                        MessageBox.Show(respons);

                    }
               
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateUserForm form = new UpdateUserForm();
            form.Show();
        }
    }
}
