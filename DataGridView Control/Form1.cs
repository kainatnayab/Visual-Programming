using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("RollNo", typeof(Int32));
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Father Name", typeof(string));
            dt.Columns.Add("Class", typeof(string));
            dt.Columns.Add("Test Obtain Marks", typeof(double));
            dt.Columns.Add("Test Total Marks", typeof(double));
            dt.Columns.Add("Grade", typeof(string));
        
            dt.Rows.Add("1", "laiba", "Ijaz","9th", "20", "30", "B");
            dt.Rows.Add("2", "Maryam", "Riyaz","9th", "27", "30", "A");
            dt.Rows.Add("3", "Fatima", "Ali","9th","14", "30", "C");
            dt.Rows.Add("4", "Aliza", "Tariq","9th","29", "30", "A");
            dt.Rows.Add("5", "Muqadas", "Shakeel","10th","19", "30", "C");
            dt.Rows.Add("6", "Noor", "Ahmad", "10th", "18", "30", "C");
            dt.Rows.Add("7", "Alia", "Riyaz", "10th", "29", "30", "A");

            dataGridView1.DataSource = dt;
          
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            style.BackColor = Color.BurlyWood;
            style.ForeColor = Color.White;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle = style;

            //HeaderstyleofAllColumns
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            style1.BackColor = Color.Navy;
            style1.ForeColor = Color.White;
            style1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style = style1;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.Font = new Font("Arial Rounded MT", 20.0f, FontStyle.Regular);
            style2.BackColor = Color.Navy;
            style2.ForeColor = Color.White;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style = style2;
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            style3.Font = new Font("Arial Rounded MT", 20.0f, FontStyle.Regular);
            style3.BackColor = Color.Navy;
            style3.ForeColor = Color.White;
            style3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style = style3;
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            style4.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            style4.BackColor = Color.Navy;
            style4.ForeColor = Color.White;
            style4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style = style4;
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            style5.Font = new Font("Arial Rounded MT", 20.0f, FontStyle.Regular);
            style5.BackColor = Color.Navy;
            style5.ForeColor = Color.White;
            style5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style = style5;
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            style6.Font = new Font("Arial Rounded MT", 20.0f, FontStyle.Regular);
            style6.BackColor = Color.Navy;
            style6.ForeColor = Color.White;
            style6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style = style6;
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            style7.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            style7.BackColor = Color.Navy;
            style7.ForeColor = Color.White;
            style7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderCell.Style = style7;
            
            //All the Cell Style
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewCellStyle s1 = new DataGridViewCellStyle();
            s1.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s1.BackColor = Color.BurlyWood;
            s1.ForeColor = Color.White;
            s1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle = s1;
            DataGridViewCellStyle s2 = new DataGridViewCellStyle();
            s2.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s2.BackColor = Color.BurlyWood;
            s2.ForeColor = Color.White;
            s2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle = s2;
            DataGridViewCellStyle s3 = new DataGridViewCellStyle();
            s3.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s3.BackColor = Color.BurlyWood;
            s3.ForeColor = Color.White;
            s3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle = s3;
            DataGridViewCellStyle s4 = new DataGridViewCellStyle();
            s4.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s4.BackColor = Color.BurlyWood;
            s4.ForeColor = Color.White;
            s4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle = s4;
            DataGridViewCellStyle s5 = new DataGridViewCellStyle();
            s5.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s5.BackColor = Color.BurlyWood;
            s5.ForeColor = Color.White;
            s5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle = s5;
            DataGridViewCellStyle s6 = new DataGridViewCellStyle();
            s6.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s6.BackColor = Color.BurlyWood;
            s6.ForeColor = Color.White;
            s6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle = s6;
            DataGridViewCellStyle s7 = new DataGridViewCellStyle();
            s7.Font = new Font("Arial Rounded MT", 25.0f, FontStyle.Regular);
            s7.BackColor = Color.BurlyWood;
            s7.ForeColor = Color.White;
            s7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle = s7;
        }
       
        private void btnfile_Click(object sender, EventArgs e)
        {
            string path = @"d:/FuelConsumption.csv";
            string[] lines = File.ReadAllLines(path);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("col", "ModelYear");
            dataGridView1.Columns.Add("col1", "Make");
            dataGridView1.Columns.Add("col2", "Model");
            dataGridView1.Columns.Add("col3", "Vehicle");
            dataGridView1.Columns.Add("col4", "Engine");
            dataGridView1.Columns.Add("col5", "Cylinder");
            dataGridView1.Columns.Add("col6", "Transmission");

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                string mdlyear = columns[0];
                string make = columns[1];
                string mdl = columns[2];
                string vhcl = columns[3];
                string engine = columns[4];
                string cylnder = columns[5];
                string trans = columns[6];
                dataGridView1.Rows.Add(mdlyear, make, mdl, vhcl, engine, cylnder, trans);
            }
        }

       
    }
}
