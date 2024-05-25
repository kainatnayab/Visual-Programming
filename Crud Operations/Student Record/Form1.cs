using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            nudMaxMarks.Maximum = decimal.MaxValue;
            GetAllData();


        }
        //Create a function GetAllData
        private void GetAllData()
        {
            string q = $@"select * from Student";
            dataGridView1.DataSource = Select(q);

        }

        //Create a function Select

        private DataTable Select(string q)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.; Initial Catalog=College; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int studentId = 0;
            if (!string.IsNullOrEmpty(txtId.Text))
                studentId = Convert.ToInt32(txtId.Text);
            if (studentId == 0)
            {
                string q = $@"insert into Student (StudentName, FatherName, Class, ObtainMatricMarks, MaxMatricMarks, Grade)
                Values('{txtstudentName.Text}','{txtfatherName.Text}','{txtClass.Text}','{nudObtMarks.Value}',
                '{nudMaxMarks.Value}','{txtGrade.Text}')";
                execute(q);
            }
            else
            {
                string q = $@"update Student
                        set StudentName='{txtstudentName.Text}'
                        , FatherName='{txtfatherName.Text}'
                        , Class='{txtClass.Text}'
                       
                        , ObtainMatricMarks='{nudObtMarks.Value}'
                        , MaxMatricMarks='{nudMaxMarks.Value}'
                        , Grade='{txtGrade.Text}'
                        where Id='{studentId}'";
                execute(q);

            }
        }
        //Create a function execute

        private void execute(string q)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.; Initial Catalog=College; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = q;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            GetAllData();

            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtstudentName.Text))
            {
                errorProvider1.SetError(txtstudentName, "Reqiured Field");
                txtstudentName.Focus();
            }

            if (string.IsNullOrEmpty(txtfatherName.Text))
            {
                errorProvider1.SetError(txtfatherName, "Reqiured Field");
                txtfatherName.Focus();
            }
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                 errorProvider1.SetError(txtClass, "Reqiured Field");
                txtClass.Focus();
            }
            if (string.IsNullOrEmpty(nudObtMarks.Text))
            {
                 errorProvider1.SetError(nudObtMarks, "Reqiured Field");
                nudObtMarks.Focus();
            }
            if (string.IsNullOrEmpty(nudMaxMarks.Text))
            {
                 errorProvider1.SetError(nudMaxMarks, "Reqiured Field");
                nudMaxMarks.Focus();
            }
            if (string.IsNullOrEmpty(txtGrade.Text))
            {
                 errorProvider1.SetError(txtGrade, "Reqiured Field");
                txtGrade.Focus();
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string q = $@"select * from Student where Id={studentId}";
                DataTable dt = Select(q);
                txtId.Text = dt.Rows[0][0].ToString();
                txtstudentName.Text = dt.Rows[0][1].ToString();
                txtfatherName.Text = dt.Rows[0][2].ToString();
                txtClass.Text = dt.Rows[0][3].ToString();

                nudObtMarks.Value = Convert.ToDecimal(dt.Rows[0][4]);
                nudMaxMarks.Value = Convert.ToDecimal(dt.Rows[0][5]);
                txtGrade.Text = dt.Rows[0][6].ToString();
                Select(q);
                MessageBox.Show("Data is Edited Successfully.");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string msg = "Are you sure to delete this record?";
                if (MessageBox.Show(msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string q = $"delete from Student where Id={studentId}";
                    execute(q);
                    GetAllData();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)

        {
            NewData();
        }

        private void NewData()
        {
            txtId.Text = "";
            txtstudentName.Text = "";
            txtfatherName.Text = "";
            txtClass.Text = "";
            nudObtMarks.Value = 0;
            nudMaxMarks.Value = 0;
            txtGrade.Text = "";
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int studentId = 0;
            if (!string.IsNullOrEmpty(txtId.Text))
                studentId = Convert.ToInt32(txtId.Text);
            if (studentId == 0)
            {
                string q = $@"insert into Student (StudentName, FatherName, Class, ObtainMatricMarks, MaxMatricMarks, Grade)
                Values('{txtstudentName.Text}','{txtfatherName.Text}','{txtClass.Text}','{nudObtMarks.Value}',
                '{nudMaxMarks.Value}','{txtGrade.Text}')";
                execute(q);
            }
            else
            {
                string q = $@"update Student
                        set StudentName='{txtstudentName.Text}'
                        , FatherName='{txtfatherName.Text}'
                        , Class='{txtClass.Text}'
                       
                        , ObtainMatricMarks='{nudObtMarks.Value}'
                        , MaxMatricMarks='{nudMaxMarks.Value}'
                        , Grade='{txtGrade.Text}'
                        where Id='{studentId}'";
                execute(q);

            }
        }

        private void formatingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string q = $@"select * from Student where Id={studentId}";
                DataTable dt = Select(q);
                txtId.Text = dt.Rows[0][0].ToString();
                txtstudentName.Text = dt.Rows[0][1].ToString();
                txtfatherName.Text = dt.Rows[0][2].ToString();
                txtClass.Text = dt.Rows[0][3].ToString();

                nudObtMarks.Value = Convert.ToDecimal(dt.Rows[0][4]);
                nudMaxMarks.Value = Convert.ToDecimal(dt.Rows[0][5]);
                txtGrade.Text = dt.Rows[0][6].ToString();
                Select(q);
                MessageBox.Show("Data is formated Successfully.");

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string msg = "Are you sure to delete this record?";
                if (MessageBox.Show(msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string q = $"delete from Student where Id={studentId}";
                    execute(q);
                    GetAllData();
                }
            }
        }

      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string q = $@"select * from Student where Id={studentId}";
                DataTable dt = Select(q);
                txtId.Text = dt.Rows[0][0].ToString();
                txtstudentName.Text = dt.Rows[0][1].ToString();
                txtfatherName.Text = dt.Rows[0][2].ToString();
                txtClass.Text = dt.Rows[0][3].ToString();

                nudObtMarks.Value = Convert.ToDecimal(dt.Rows[0][4]);
                nudMaxMarks.Value = Convert.ToDecimal(dt.Rows[0][5]);
                txtGrade.Text = dt.Rows[0][6].ToString();
                Select(q);
                MessageBox.Show("Data is formated Successfully When Double Click EventHandler is generated.");

            }
        }

        
    }
    
}
        
    


