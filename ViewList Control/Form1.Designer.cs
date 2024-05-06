namespace Create_a_result_of_new_student
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagelistlarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListsmall = new System.Windows.Forms.ImageList(this.components);
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtObtMarks = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoLargeicon = new System.Windows.Forms.RadioButton();
            this.rdoSmallicon = new System.Windows.Forms.RadioButton();
            this.rdodetails = new System.Windows.Forms.RadioButton();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imagelistlarge;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 324);
            this.listView1.SmallImageList = this.imageListsmall;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Roll No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Father Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Class";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Matric Obtain Marks";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Matric Total Marks";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Grade";
            // 
            // imagelistlarge
            // 
            this.imagelistlarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistlarge.ImageStream")));
            this.imagelistlarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistlarge.Images.SetKeyName(0, "icons8-graduate-48.png");
            // 
            // imageListsmall
            // 
            this.imageListsmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListsmall.ImageStream")));
            this.imageListsmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListsmall.Images.SetKeyName(0, "icons8-graduate-16.png");
            // 
            // txtRollno
            // 
            this.txtRollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollno.Location = new System.Drawing.Point(784, 103);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.ReadOnly = true;
            this.txtRollno.Size = new System.Drawing.Size(272, 31);
            this.txtRollno.TabIndex = 1;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(784, 140);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.ReadOnly = true;
            this.txtstudentname.Size = new System.Drawing.Size(272, 31);
            this.txtstudentname.TabIndex = 2;
            // 
            // txtfathername
            // 
            this.txtfathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfathername.Location = new System.Drawing.Point(784, 177);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.ReadOnly = true;
            this.txtfathername.Size = new System.Drawing.Size(272, 31);
            this.txtfathername.TabIndex = 3;
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.Location = new System.Drawing.Point(784, 214);
            this.txtclass.Name = "txtclass";
            this.txtclass.ReadOnly = true;
            this.txtclass.Size = new System.Drawing.Size(272, 31);
            this.txtclass.TabIndex = 4;
            // 
            // txtObtMarks
            // 
            this.txtObtMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObtMarks.Location = new System.Drawing.Point(784, 251);
            this.txtObtMarks.Name = "txtObtMarks";
            this.txtObtMarks.ReadOnly = true;
            this.txtObtMarks.Size = new System.Drawing.Size(272, 31);
            this.txtObtMarks.TabIndex = 5;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMarks.Location = new System.Drawing.Point(784, 290);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.ReadOnly = true;
            this.txtTotalMarks.Size = new System.Drawing.Size(272, 31);
            this.txtTotalMarks.TabIndex = 6;
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(784, 327);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(272, 31);
            this.txtGrade.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Roll no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Matric Obtain Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Matric Total Marks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(660, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grade";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(909, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 48);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(784, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 48);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoLargeicon
            // 
            this.rdoLargeicon.AutoSize = true;
            this.rdoLargeicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLargeicon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdoLargeicon.Location = new System.Drawing.Point(31, 456);
            this.rdoLargeicon.Name = "rdoLargeicon";
            this.rdoLargeicon.Size = new System.Drawing.Size(170, 35);
            this.rdoLargeicon.TabIndex = 18;
            this.rdoLargeicon.Text = "Large Icon";
            this.rdoLargeicon.UseVisualStyleBackColor = true;
            this.rdoLargeicon.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdoSmallicon
            // 
            this.rdoSmallicon.AutoSize = true;
            this.rdoSmallicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmallicon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdoSmallicon.Location = new System.Drawing.Point(31, 497);
            this.rdoSmallicon.Name = "rdoSmallicon";
            this.rdoSmallicon.Size = new System.Drawing.Size(168, 35);
            this.rdoSmallicon.TabIndex = 19;
            this.rdoSmallicon.Text = "Small Icon";
            this.rdoSmallicon.UseVisualStyleBackColor = true;
            this.rdoSmallicon.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdodetails
            // 
            this.rdodetails.AutoSize = true;
            this.rdodetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdodetails.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdodetails.Location = new System.Drawing.Point(217, 457);
            this.rdodetails.Name = "rdodetails";
            this.rdodetails.Size = new System.Drawing.Size(123, 35);
            this.rdodetails.TabIndex = 20;
            this.rdodetails.Text = "Details";
            this.rdodetails.UseVisualStyleBackColor = true;
            this.rdodetails.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdoTile
            // 
            this.rdoTile.AutoSize = true;
            this.rdoTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdoTile.Location = new System.Drawing.Point(218, 488);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(80, 35);
            this.rdoTile.TabIndex = 21;
            this.rdoTile.Text = "Tile";
            this.rdoTile.UseVisualStyleBackColor = true;
            this.rdoTile.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rdoList.Location = new System.Drawing.Point(376, 457);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(79, 35);
            this.rdoList.TabIndex = 22;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdolist_CheckedChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(175, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(744, 72);
            this.label8.TabIndex = 23;
            this.label8.Text = "Result of New Student";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1099, 641);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.rdoTile);
            this.Controls.Add(this.rdodetails);
            this.Controls.Add(this.rdoSmallicon);
            this.Controls.Add(this.rdoLargeicon);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtObtMarks);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.listView1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtObtMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ImageList imagelistlarge;
        private System.Windows.Forms.ImageList imageListsmall;
        private System.Windows.Forms.RadioButton rdoLargeicon;
        private System.Windows.Forms.RadioButton rdoSmallicon;
        private System.Windows.Forms.RadioButton rdodetails;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.Label label8;
    }
}

