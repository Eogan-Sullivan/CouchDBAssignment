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
    public partial class weatherApp : Form
       
    {
        inputWeather myInputForm;
        viewWeather myViewForm;

        public weatherApp()
        {
            InitializeComponent();
            myInputForm = new inputWeather();
            myViewForm = new viewWeather();
        }

        private void btnViewWeather_Click(object sender, EventArgs e)
        {
            myViewForm.Show();
            Visible = false;
    ;
        }

        private void btnInputWeather_Click(object sender, EventArgs e)
        {
            myInputForm.Show();
            Visible = false;
        }
    }
}
