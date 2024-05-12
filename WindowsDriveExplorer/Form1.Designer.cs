namespace WindowsFormsApp9
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListsmall = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.colum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListlarge = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdoLargeicon = new System.Windows.Forms.RadioButton();
            this.rdoSmallicon = new System.Windows.Forms.RadioButton();
            this.rdodetails = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.treeView1.Location = new System.Drawing.Point(3, 67);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(469, 751);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageListsmall
            // 
            this.imageListsmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListsmall.ImageStream")));
            this.imageListsmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListsmall.Images.SetKeyName(0, "icons8-folder-16.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colum});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageListlarge;
            this.listView1.Location = new System.Drawing.Point(470, 67);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 751);
            this.listView1.SmallImageList = this.imageListsmall;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colum
            // 
            this.colum.Text = "All Data of Drives";
            this.colum.Width = 707;
            // 
            // imageListlarge
            // 
            this.imageListlarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListlarge.ImageStream")));
            this.imageListlarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListlarge.Images.SetKeyName(0, "icons8-folder-48.png");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "WindowsDriveExplorer\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rdoLargeicon
            // 
            this.rdoLargeicon.AutoSize = true;
            this.rdoLargeicon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLargeicon.Location = new System.Drawing.Point(288, 824);
            this.rdoLargeicon.Name = "rdoLargeicon";
            this.rdoLargeicon.Size = new System.Drawing.Size(107, 26);
            this.rdoLargeicon.TabIndex = 4;
            this.rdoLargeicon.TabStop = true;
            this.rdoLargeicon.Text = "LargeIcon";
            this.rdoLargeicon.UseVisualStyleBackColor = true;
            this.rdoLargeicon.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdoSmallicon
            // 
            this.rdoSmallicon.AutoSize = true;
            this.rdoSmallicon.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmallicon.Location = new System.Drawing.Point(401, 824);
            this.rdoSmallicon.Name = "rdoSmallicon";
            this.rdoSmallicon.Size = new System.Drawing.Size(107, 26);
            this.rdoSmallicon.TabIndex = 5;
            this.rdoSmallicon.TabStop = true;
            this.rdoSmallicon.Text = "SmallIcon";
            this.rdoSmallicon.UseVisualStyleBackColor = true;
            this.rdoSmallicon.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdodetails
            // 
            this.rdodetails.AutoSize = true;
            this.rdodetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdodetails.Location = new System.Drawing.Point(511, 824);
            this.rdodetails.Name = "rdodetails";
            this.rdodetails.Size = new System.Drawing.Size(84, 26);
            this.rdodetails.TabIndex = 6;
            this.rdodetails.TabStop = true;
            this.rdodetails.Text = "Details";
            this.rdodetails.UseVisualStyleBackColor = true;
            this.rdodetails.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoList.Location = new System.Drawing.Point(664, 824);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(57, 26);
            this.rdoList.TabIndex = 7;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdoTile
            // 
            this.rdoTile.AutoSize = true;
            this.rdoTile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTile.Location = new System.Drawing.Point(601, 824);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(57, 26);
            this.rdoTile.TabIndex = 8;
            this.rdoTile.TabStop = true;
            this.rdoTile.Text = "Tile";
            this.rdoTile.UseVisualStyleBackColor = true;
            this.rdoTile.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1191, 862);
            this.Controls.Add(this.rdoTile);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.rdodetails);
            this.Controls.Add(this.rdoSmallicon);
            this.Controls.Add(this.rdoLargeicon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListsmall;
        private System.Windows.Forms.ColumnHeader colum;
        private System.Windows.Forms.ImageList imageListlarge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoLargeicon;
        private System.Windows.Forms.RadioButton rdoSmallicon;
        private System.Windows.Forms.RadioButton rdodetails;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoTile;
    }
}

