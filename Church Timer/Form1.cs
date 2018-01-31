using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Church_Timer
{
    public partial class frmChurchTimer : Form
    {
        public frmChurchTimer()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            lblCurrent_time.Text = DateTime.Now.ToString();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string time_given(string txtMinutes)
        {
            int added_time = Convert.ToInt32(txtMinutes); // Convert entered minutes to Integer so it can be converted to Hours and minutes
            int added_hour = (added_time / 60);
            int added_minutes = ((added_time - (added_hour * 60)) - 1);
            string the_inital_hour = String.Format("{0:d2}", added_hour);
            string the_initial_minutes = String.Format("{0:d2}", added_minutes);// String.Format("{0:HH:mm:ss}", added_time);

            string time_given = the_inital_hour + ":" + the_initial_minutes;
            return time_given;
        }


        public void btnAddMinutes_Click(object sender, EventArgs e)
        {

            if (txtCritical_time.Text == "")
            {
                txtCritical_time.Text = "0";
            }
            if (txtWarning_time.Text == "")
            {
                txtWarning_time.Text = "0";
            }
            int warning_time = (Convert.ToInt32(txtWarning_time.Text)) - 1;
            int critical_time = (Convert.ToInt32(txtCritical_time.Text)) - 1;

            frmcountdown countdownForm = new frmcountdown(); //declaring next form
            countdownForm.lblCountdown.Text = time_given(txtMinutes.Text); //assigning value to the label on next form
            countdownForm.lblWarning_time.Text =  txtWarning_time.Text;
            countdownForm.lblCritical_time.Text =  txtCritical_time.Text;
            
            Screen[] sc;
            sc = Screen.AllScreens;
            //get all the screen width and heights 

            countdownForm.FormBorderStyle = FormBorderStyle.None;

            Rectangle bounds = sc[0].Bounds;
            countdownForm.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            countdownForm.StartPosition = FormStartPosition.Manual;
            countdownForm.tmrCountdown.Start(); //Start Time on next form
            countdownForm.Show();
     }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtWarning_time_TextChanged(object sender, EventArgs e)
        {
            sbyte a;
            if (!sbyte.TryParse(txtWarning_time.Text, out a))
            {
                // If Not Integer Clear Textbox text or you can also Undo() Last Operation :)
                txtWarning_time.Clear();
            }


        }

        private void txtCritical_time_TextChanged(object sender, EventArgs e)
        {
            sbyte a;
            if (!sbyte.TryParse(txtCritical_time.Text, out a))
            {
                // If Not Integer Clear Textbox text or you can also Undo() Last Operation :)
                txtCritical_time.Clear();
            }
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            byte a;
            if (!byte.TryParse(txtMinutes.Text, out a))
            {
                // If Not Integer Clear Textbox text or you can also Undo() Last Operation :)
                txtMinutes.Clear();
            }
        }

        private void lblcontrollerTime_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_time_Click(object sender, EventArgs e)
        {

        }
  }
}
