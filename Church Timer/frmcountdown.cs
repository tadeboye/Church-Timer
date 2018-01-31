using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Church_Timer
{
    public partial class frmcountdown : Form 
    {
        public frmcountdown()
        {
            InitializeComponent();
            tmrCountdown.Enabled = true;
            tmrCountdown.Interval = (1000);             // Timer will tick every second
            tmrCountdown.Start();


            //tmrCountdownSeconds.Enabled = true;
            //tmrCountdownSeconds.Interval = 1000;             // Timer will tick every second
            //tmrCountdownSeconds.Start();
     
         }

        int seconds = 60;

        public void ChangeBgColorToRed()
        {
            this.BackColor = System.Drawing.Color.Red;
            lblCountdown.BackColor = Color.Red;
        }

        public void ChangeBgColorToWhite()
        {
            this.BackColor = System.Drawing.Color.White;
            lblCountdown.BackColor = Color.White;
        }

        public void ChangeBgColorToYellow()
        {
            this.BackColor = System.Drawing.Color.Yellow;
            lblCountdown.BackColor = Color.Yellow;
        }
        
        public void tmrCountdown_Tick(object sender, EventArgs e)
        {
            seconds--;
            lblSeconds.Text = seconds.ToString("00");


            string thecurrent_time = lblCountdown.Text.ToString();
            string stradded_hour = thecurrent_time.Substring(0, 2);
            string stradded_minutes = thecurrent_time.Substring(3);

            int addedhour = Convert.ToInt16(stradded_hour);
            int addedminutes = Convert.ToInt16(stradded_minutes);
            int warning_time = (Convert.ToInt16(lblWarning_time.Text))-1;
            int critical_time = (Convert.ToInt16(lblCritical_time.Text))-1;
            int added_time = ((addedhour * 60) + addedminutes);
            


            //changing background color during warning and critical times
            if (added_time <= warning_time && added_time > critical_time )
            {
                if ((seconds % 6) == 5)
                {
                    ChangeBgColorToYellow();
                }
                else if ((seconds % 6) == 2)
                {
                    ChangeBgColorToWhite();
                }
            }
            else if (added_time <= critical_time )//&& added_time > 0)
            {
                if ((seconds % 2) == 1)
                {
                    ChangeBgColorToRed();
                }
                else
                    this.BackColor = System.Drawing.Color.White;
                lblCountdown.BackColor = Color.Transparent;
            }

            //decrease the minutes after seconds count down to -1
           if (seconds < 0 && added_time>=0)
            {
              if (added_time > 0)
                {
                    added_time--;
                    addedhour = (added_time / 60);
                    addedminutes = added_time % 60;

                    string the_hour = String.Format("{0:d2}", addedhour);
                    string the_minutes = String.Format("{0:d2}", addedminutes);// String.Format("{0:HH:mm:ss}", added_time);

                    frmChurchTimer homeform = new frmChurchTimer();
                    homeform.lblcontrollerTime.Text = the_hour + ":" + the_minutes + ":" + seconds.ToString("00");




                    lblCountdown.Text = the_hour + ":" + the_minutes;
                    seconds = 59;
                    lblSeconds.Text = "59";
              


                 }

                else if (added_time == 0)
                {
                    //this.BackColor = System.Drawing.Color.Red;
                    lblCountdown.BackColor = Color.Red;
                    lblCountdown.Visible = false;
                    lblSeconds.Visible = false;
                    lblTimeUp.Visible = true;
                   // lblTimeUp.ForeColor = Color.Red;
                    var timer = new Timer() { Interval = 2000, Enabled = true, };
                    timer.Tick += (s, ex) =>
                        this.BackColor =
                                this.BackColor == Color.Red ? Color.Yellow : Color.Red;
                    
                    //tmrCountdown.Tick += 10000;
                    //lblTimeUp.ForeColor = Color.Blue;
                    
                }

                

                
                
            }
           else if (seconds < 0 && added_time < 0)
           {
               lblSeconds.Text = "00";
           }

            
        }
        
        
        public void frmcountdown_Load(object sender, EventArgs e)
        {
          
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseCountdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrCountdownSeconds_Tick(object sender, EventArgs e)
        {

        }         

      
    }
}
