using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Create_a_result_of_new_student
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RollNo", typeof(Int32));
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Matric Obtain Marks", typeof(double));
            dt.Columns.Add("Matric Total Marks", typeof(double));
            dt.Columns.Add("Grade", typeof(string));

            dt.Rows.Add("1", "laiba", "Ijaz", "9/10th","715", "1100","B");
            dt.Rows.Add("2", "Maryam", "Riyaz", "9/10th", "845","1100","B");
            dt.Rows.Add("3", "Fatima", "Ali", "9/10th","900","1100","A");
            dt.Rows.Add("4", "Aliza", "Tariq", "9/10th","504","1100" ,"C");
            dt.Rows.Add("5", "Muqadas", "Shakeel","9/10th","589","1100", "C");
            dt.Rows.Add("6", "Noor", "Ahmad","9/10th","889","1100","B+");
            dt.Rows.Add("7", "Alia", "Riyaz","9/10th","1024","1100","A");
            dt.Rows.Add("8", "Alina", "Munawar", "9/10th", "903", "1100", "A");
            dt.Rows.Add("9", "Laiba", "Mustafa", "9/10th", "1024", "1100", "A+");
            dt.Rows.Add("10", "Aresha", "Ahmad", "9/10th", "1020", "1100", "A+");

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = row["RollNo"].ToString();
                item.SubItems.Add(row["Student Name"].ToString());
                item.SubItems.Add(row["Father Name"].ToString());
                item.SubItems.Add(row["Class"].ToString());
                item.SubItems.Add(row["Matric Obtain Marks"].ToString());
                item.SubItems.Add(row["Matric Total Marks"].ToString());
                item.SubItems.Add(row["Grade"].ToString());
              

                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                txtRollno.Text = itm.Text;
                txtstudentname.Text = itm.SubItems[1].Text;
                txtfathername.Text = itm.SubItems[2].Text;
                txtclass.Text = itm.SubItems[3].Text;
                txtObtMarks.Text = itm.SubItems[4].Text;
                txtTotalMarks.Text = itm.SubItems[5].Text; 
                txtGrade.Text = itm.SubItems[6].Text;
            }
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            item.Text = txtRollno.Text;
            item.SubItems.Add(txtstudentname.Text);
            item.SubItems.Add(txtfathername.Text);
            item.SubItems.Add(txtclass.Text);
            item.SubItems.Add(txtObtMarks.Text);
            item.SubItems.Add(txtTotalMarks.Text);
            item.SubItems.Add(txtGrade.Text);
            listView1.Items.Add(item);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRollno.ReadOnly = false;
            txtstudentname.ReadOnly = false;
            txtfathername.ReadOnly = false;
            txtclass.ReadOnly = false;
            txtObtMarks.ReadOnly = false;
            txtTotalMarks.ReadOnly = false;
            txtGrade.ReadOnly = false;
            txtRollno.Clear();
            txtstudentname.Clear();
            txtfathername.Clear();
            txtclass.Clear();
            txtObtMarks.Clear();
            txtTotalMarks.Clear();
            txtGrade.Clear();
        }


        private void rdolist_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rdbt = (RadioButton)sender;
            switch (rdbt.Name)
            {
                case "rdoLargeicon":
                    listView1.View = View.LargeIcon;
                    break;
                case "rdoSmallicon":
                    listView1.View = View.SmallIcon;
                    break;
                case "rdodetails":
                    listView1.View = View.Details;
                    break;
                case "rdoTile":
                    listView1.View = View.Tile;
                    break;
                case "rdoList":
                    listView1.View = View.List;
                    break;
            }
        }
    }
    
}
