//import MyCouch into project
using MyCouch;
// imports methods for requests to databases
using MyCouch.Requests;
//allows for responses from database
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

/// <summary>
/// Weather App By Eógan Sullivan
/// </summary>
namespace weatherApp
{
    /// <summary>
    /// This form allows users users to view informatiofrom database
    /// </summary>
    public partial class viewWeather : Form
    {
      
      
        string docId; // used for the name of the document
        string dbConnect = "http://127.0.0.1:5984/"; //Http connection for the database
        private weatherApp weatherApp;//home Screen

        /// <summary>
        /// Initializes view Weather Window
        /// </summary>
        public viewWeather()
        {
            InitializeComponent();
 
            
        }

        /// <summary>
        /// Initalises view Weather 
        /// </summary>
        /// <param name="weatherApp"></param>
        public viewWeather(weatherApp weatherApp)
        {
            this.weatherApp = weatherApp;
            InitializeComponent();
        }

        /// <summary>
        /// Initilises passes text in textbox to docId calls  viewWeatherAction(docId) and setVisibleOnForm();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           docId = txtLoc.Text.ToString();
           viewWeatherAction(docId);
            setVisibleOnForm();
                    
        }

        /// <summary>
        /// Sets all textboxes on forms to visible
        /// </summary>
        private void setVisibleOnForm()
        {
            txtPercip.Visible = true;
            txtSummary.Visible = true;
            txtTemp.Visible = true;
            labPercip.Visible = true;
            labSkies.Visible = true;
            labTemp.Visible = true;
        }

        /// <summary>
        /// allows to Read weather options
        /// </summary>
        /// <param name="docId"> name of documnet</param>
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
     

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            viewTempsAsync();
        }

        /// <summary>
        /// Calls Map Reduce
        /// </summary>
        /// <returns></returns>
        private async Task viewTempsAsync()
        {
            using (var client = new MyCouchClient(dbConnect, "weatherapp"))
            {
                var query = new QueryViewRequest("_design/viewAllTemp");
                ViewQueryResponse<string> response = await client.Views.QueryAsync(query);                          
                MessageBox.Show(response.ToString());

            }
        }

        /// <summary>
        /// Goes back to the main Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            weatherApp.Visible = true;
            this.Close();
        }
    }


}
