using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Collecting_data_of_a_new_student
{
    public partial class Form1 : Form
    {
        private string selecteddistict;

        public Form1()
        {
            InitializeComponent();

        }
        private void chbfreelancer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbfreelancer.Checked)
                groupBoxfreelancer.Enabled = true;
            else
                groupBoxfreelancer.Enabled = false;
        }

        private void chbsportsplayer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbsportsplayer.Checked)
                groupBoxsportsplayer.Enabled = true;
            else
                groupBoxsportsplayer.Enabled = false;
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            string gender = "";
            if (rdomale.Checked)
                gender = "Male";
            else if (rdofemale.Checked)
                gender = "Female";
            string province = cmbprovince.SelectedItem.ToString();
            string district = cmbdistrict.SelectedItem.ToString();
            string city = cmbcity.SelectedItem.ToString();

            // Retrieve data from checkbox controls
            string activities = "" + Environment.NewLine;
            if (chbhafizequran.Checked)
                activities += "-> Hafiz-e-Quran" + Environment.NewLine;
            if (chbsportsplayer.Checked)
                activities += "-> Sports Player" + Environment.NewLine;
            if (chbartist.Checked)
                activities += "-> Artist" + Environment.NewLine;
            if (chbfreelancer.Checked)
                activities += "-> Freelancer" + Environment.NewLine;

            // Retrieve data from radio button controls
            string sports = "" + Environment.NewLine;
            if (rdocricket.Checked)
                sports = "-> Cricket";
            else if (rdofootball.Checked)
                sports = "-> Football";
            else if (rdobadminton.Checked)
                sports = "-> Badminton";
            else if (rdotabletennis.Checked)
                sports = "-> Table Tennis";

            string freelancer = "" + Environment.NewLine;
            if (rdographics.Checked)
                freelancer = "-> Graphics Designer";
            else if (rdovoiceoverartist.Checked)
                freelancer = "-> Voice Over Artist";
            else if (rdosoftwaredeveloper.Checked)
                freelancer = "-> Software Developer";
            else if (rdovideoeditor.Checked)
                freelancer = "-> Video Editor";

            //caculate numbers
            int matricObtainedMarks = (int)numericUpDownmatricobtmarks.Value;
            int matricMaxMarks = (int)numericUpDownmatricmaxmarks.Value;
            int interObtainedMarks = (int)numericUpDownintermarks.Value;
            int interMaxMarks = (int)numericUpDownintermaxmarks.Value;
            double netPercentage = ((matricObtainedMarks / (double)matricMaxMarks) * 50) + ((interObtainedMarks / (double)interMaxMarks) * 50);
            //Display
            string details = "All Data of New Students";
            details += Environment.NewLine;
            details += $"Student Name: {txtstudentname.Text}" + Environment.NewLine;
            details += $"Father Name: {txtfathername.Text}";
            details += Environment.NewLine;
            details += $"Gender: {gender}" + Environment.NewLine;
            details += $"Province: {province}" + Environment.NewLine;
            details += $"District: {district}" + Environment.NewLine;
            details += $"City: {city}" + Environment.NewLine;
            details += $"Extra Curricular Activities: {activities}" + Environment.NewLine;
            details += $"Sports Player: {sports}" + Environment.NewLine;
            details += $"Freelancer: {freelancer}" + Environment.NewLine;
            details += $"Net percentage: {netPercentage}" + Environment.NewLine;
            txtdetails.Text = details;


        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            txtdetails.Clear();
        }
        private void lblnetpercentagedisplay_Click(object sender, EventArgs e)
        {
            // Calculate and display net percentage 
            int matricObtainedMarks = (int)numericUpDownmatricobtmarks.Value;
            int matricMaxMarks = (int)numericUpDownmatricmaxmarks.Value;
            int interObtainedMarks = (int)numericUpDownintermarks.Value;
            int interMaxMarks = (int)numericUpDownintermaxmarks.Value;
            double netPercentage = ((matricObtainedMarks / (double)matricMaxMarks) * 50) + ((interObtainedMarks / (double)interMaxMarks) * 50);
            txtdetails.Text = $"{netPercentage:F2}%";
        } 
    }
}
