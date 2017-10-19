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
    public partial class inputWeather : Form
    {
        string docId;
        Weather inputs;
        string dbConnect = "http://127.0.0.1:5984/";
        private weatherApp weatherApp;

        public inputWeather(weatherApp weatherApp)
        {
            InitializeComponent();
            inputs = new Weather();
            this.weatherApp = weatherApp;

        }

        private async Task WriteToCouchAsync(string docId)
        {
            using (var client = new MyCouchClient(dbConnect, "weatherapp"))
            {

                //updates pre exsisiting document
                var document = client.Documents.GetAsync(docId);
                if (document.Result.Content != null)
                {
                    dynamic array = JsonConvert.DeserializeObject<Dictionary<string, string>>(document.Result.Content);
                    inputs.Rev = array["_rev"];
                    inputs.Id = array["_id"];
                    await client.Documents.PutAsync(inputs.Id, inputs.Rev, "{\"temperature\":\"" + txtTemp.Text + 
                                                    "\",\"percipitation\":\"" + txtPercip.Text + "\",\"Skies\":\"" 
                                                    + txtSummary.Text + "\"}");
                    MessageBox.Show(inputs.Id + " : Updated");
                }

                //creates new document
                else
                {
                    string createdObject = "{\"_id\":\"" + txtLoc.Text + "\",\"temperature\":\""
                                          + txtTemp.Text.ToString() + "\",\"percipitation\":\"" + txtPercip.Text.ToString() +
                                          "\",\"Skies\":\"" + txtSummary.Text + "\"}";

                    await client.Documents.PostAsync(createdObject);
                    MessageBox.Show(txtLoc.Text + " : Created");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            docId = txtLoc.Text;
            WriteToCouchAsync(docId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            docId = txtLoc.Text;

            DeleteDb(docId);
        }

        private async void DeleteDb(string id)
        {
            using (var client = new MyCouchClient(dbConnect, "weatherapp"))
            {
                var document = client.Documents.GetAsync(docId);
                if (document.Result.Content != null)
                {
                    dynamic array = JsonConvert.DeserializeObject<Dictionary<string, string>>(document.Result.Content);
                    inputs.Rev = array["_rev"];
                    inputs.Id = array["_id"];
                    await client.Documents.DeleteAsync(inputs.Id,inputs.Rev);
                    MessageBox.Show(inputs.Id + ": Deleted");

                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            weatherApp.Visible = true;
            this.Close();
        }
    }
}
