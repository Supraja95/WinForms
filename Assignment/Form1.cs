using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnGetEmployees_Click(object sender, EventArgs e)
        {
            var val = TxtEmpID.Text;
            if (!string.IsNullOrEmpty(val))
            {
                string url = $"https://localhost:44362/weatherforecast/GetEmployee/{val}";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var fileJsonString = await response.Content.ReadAsStringAsync();
                            if (fileJsonString.Length>2)
                            {
                                dataGridView1.DataSource = JsonConvert.DeserializeObject<Employee[]>(fileJsonString).ToList();
                            }
                            else
                            {
                                MessageBox.Show("Employee Details Not Found", "Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter EmployeeID","Error",MessageBoxButtons.OK);
            }
           
        }

        private async void BtnGetAllEmployees_Click(object sender, EventArgs e)
        {
            var val = TxtEmpID.Text;
            string url = "https://localhost:44362/weatherforecast/GetAllEmployee";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var fileJsonString = await response.Content.ReadAsStringAsync();
                        dataGridView1.DataSource = JsonConvert.DeserializeObject<Employee[]>(fileJsonString).ToList();
                    }
                }
            }
        }
        private async void BtnCreateEmployee_Click_1Async(object sender, EventArgs e)
        {
            //validations
            bool result=Validations();
            if (result)
            {
                Employee employee = new Employee();
                employee.FirstName = TxtEmpFName.Text;
                employee.LastName = TxtEmpLName.Text;
                employee.EmailID = TxtEmpEmailID.Text;
                //string url = "https://localhost:44362/";

                using (var client = new HttpClient())
                {                    
                    client.BaseAddress = new Uri("https://localhost:44362/weatherforecast/");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Accept.Clear();
                    HttpResponseMessage response = client.PostAsJsonAsync("InsertEmployee", employee).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Employee Created Successfully","Success",MessageBoxButtons.OK);
                        TxtEmpID.Text=TxtEmpLName.Text=TxtEmpFName.Text =TxtEmpEmailID.Text ="";
                    }
                }
                
            }
        }
        public bool Validations()
        {
            bool result;
            if (string.IsNullOrEmpty(TxtEmpFName.Text) || string.IsNullOrEmpty(TxtEmpLName.Text) || string.IsNullOrEmpty(TxtEmpEmailID.Text))
            {
                MessageBox.Show("Please enter the Employee FirstName,Last Name,Email ID","Error",MessageBoxButtons.OK);                
                result = false;
            }
            else
            {                
                result = true;
            }            
            return result;
        }
        private async void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string empID = TxtEmpID.Text;
            if (!string.IsNullOrEmpty(empID))
            {
                string url = $"https://localhost:44362/weatherforecast/DeleteEmployee/{empID}";

                using (var client = new HttpClient())
                {
                    using (var response = await client.DeleteAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Employee Deleted Successfully", "Delete", MessageBoxButtons.OK);
                            TxtEmpID.Text=TxtEmpEmailID.Text = TxtEmpLName.Text = TxtEmpFName.Text = TxtEmpEmailID.Text = "";
                        }
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Employee details not Found", "Delete", MessageBoxButtons.OK);
                            TxtEmpID.Text=TxtEmpEmailID.Text = TxtEmpLName.Text = TxtEmpFName.Text = TxtEmpEmailID.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter EmpID", "Error", MessageBoxButtons.OK);
            }
        }
        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string empID = TxtEmpID.Text;
            if (!string.IsNullOrEmpty(empID))
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(empID);
                if (TxtEmpFName.Text != "" || TxtEmpLName.Text != "" || TxtEmpEmailID.Text != "")
                {
                    if (!string.IsNullOrEmpty(TxtEmpFName.Text))
                    {
                        employee.FirstName = TxtEmpFName.Text;
                    }
                    if (!string.IsNullOrEmpty(TxtEmpLName.Text))
                    {
                        employee.LastName = TxtEmpLName.Text;
                    }
                    if (!string.IsNullOrEmpty(TxtEmpEmailID.Text))
                    {
                        employee.EmailID = TxtEmpEmailID.Text;
                    }
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:44362/weatherforecast/");
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Accept.Clear();
                        HttpResponseMessage response = client.PutAsJsonAsync("UpdateEmployee", employee).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Employee Updated Successfully", "Success", MessageBoxButtons.OK);
                            TxtEmpID.Text=TxtEmpLName.Text = TxtEmpFName.Text = TxtEmpEmailID.Text = "";
                        }
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Employee details not Found", "Update", MessageBoxButtons.OK);
                            TxtEmpID.Text=TxtEmpEmailID.Text = TxtEmpLName.Text = TxtEmpFName.Text = TxtEmpEmailID.Text = "";
                        }
                    }
                }
                else { MessageBox.Show("Kindly Enter employee details to update", "Update", MessageBoxButtons.OK); }

            }
            else
            {
                MessageBox.Show("Please enter EmpID", "Error", MessageBoxButtons.OK);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            TxtEmpID.Text = string.Empty;
            TxtEmpFName.Text = string.Empty;
            TxtEmpLName.Text = string.Empty;
            TxtEmpEmailID.Text = string.Empty;
        }

        
    }
}
