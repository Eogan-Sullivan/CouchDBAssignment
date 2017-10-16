using MyCouch;
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
        DateTime d;
        string dbConnect = "http://127.0.0.1:5984/";
        public viewWeather()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           docId = txtLoc.Text.ToString();
           viewWeatherAction(docId);
            d = DateTime.Now;
            txtSysTime.Text= d.ToString(format: "HH:mm:ss");
            setVisibleOnForm();
                    
        }

        private void setVisibleOnForm()
        {
            txtPercip.Visible = true;
            txtSummary.Visible = true;
            txtSysTime.Visible = true;
            txtTemp.Visible = true;
            labPercip.Visible = true;
            labSkies.Visible = true;
            labTemp.Visible = true;
            labTime.Visible = true;
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
    }


}
