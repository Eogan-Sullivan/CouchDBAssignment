using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherApp
{
    public partial class viewWeather : Form
    {
      
        string docId;
        string dbConnect = "http://127.0.0.1:5984/";
        private weatherApp weatherApp;

        public viewWeather()
        {
            InitializeComponent();
 
            
        }

        public viewWeather(weatherApp weatherApp)
        {
            this.weatherApp = weatherApp;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           docId = txtLoc.Text.ToString();
           viewWeatherAction(docId);
            setVisibleOnForm();
                    
        }

        private void setVisibleOnForm()
        {
            txtPercip.Visible = true;
            txtSummary.Visible = true;
            txtTemp.Visible = true;
            labPercip.Visible = true;
            labSkies.Visible = true;
            labTemp.Visible = true;
        }

        private async void viewWeatherAction(string docId)
        {
     
            //conection to database
            using (var client = new MyCouchClient(dbConnect, "weatherapp"))
            {
                //gets document with the id passed into the method
                var document = client.Documents.GetAsync(docId);
                // converts the json file to an array
                dynamic array = JsonConvert.DeserializeObject<Dictionary<string, string>>(document.Result.Content);
                // sets the text in the summary to the skies 
                txtSummary.Text = array["Skies"];
                txtPercip.Text = array["percipitation"];
                txtTemp.Text = array["temperature"];
                
            }             
        }
        private void txtLoc_Enter(object sender, EventArgs e)
        {
             txtLoc.Clear();
        }


        private void btnViewAll_Click(object sender, EventArgs e)
        {
            viewTempsAsync();
        }

        private async Task viewTempsAsync()
        {
            using (var client = new MyCouchClient(dbConnect, "weatherapp"))
            {
                var query = new QueryViewRequest("_design/viewAllTemp");
                ViewQueryResponse<string> response = await client.Views.QueryAsync(query);                          
                MessageBox.Show(response.ToString());

            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            weatherApp.Visible = true;
            this.Close();
        }
    }


}
