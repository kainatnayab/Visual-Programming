namespace Notepad_Windows_Form
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
            this.rchnotepad = new System.Windows.Forms.RichTextBox();
            this.chkbold = new System.Windows.Forms.CheckBox();
            this.chbfont = new System.Windows.Forms.CheckBox();
            this.chbcolor = new System.Windows.Forms.CheckBox();
            this.chbsave = new System.Windows.Forms.CheckBox();
            this.chbopen = new System.Windows.Forms.CheckBox();
            this.chbnew = new System.Windows.Forms.CheckBox();
            this.chbRedo = new System.Windows.Forms.CheckBox();
            this.chbUndo = new System.Windows.Forms.CheckBox();
            this.chbpaste = new System.Windows.Forms.CheckBox();
            this.chbcopy = new System.Windows.Forms.CheckBox();
            this.chbCut = new System.Windows.Forms.CheckBox();
            this.chbExit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchnotepad
            // 
            this.rchnotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchnotepad.Location = new System.Drawing.Point(-3, 60);
            this.rchnotepad.Name = "rchnotepad";
            this.rchnotepad.Size = new System.Drawing.Size(1379, 680);
            this.rchnotepad.TabIndex = 0;
            this.rchnotepad.Text = "";
            // 
            // chkbold
            // 
            this.chkbold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbold.AutoSize = true;
            this.chkbold.BackColor = System.Drawing.SystemColors.Menu;
            this.chkbold.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkbold.FlatAppearance.BorderSize = 2;
            this.chkbold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbold.Location = new System.Drawing.Point(432, 29);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(62, 34);
            this.chkbold.TabIndex = 1;
            this.chkbold.Text = "Bold";
            this.chkbold.UseVisualStyleBackColor = false;
            this.chkbold.CheckedChanged += new System.EventHandler(this.chkbold_CheckedChanged);
            // 
            // chbfont
            // 
            this.chbfont.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbfont.AutoSize = true;
            this.chbfont.BackColor = System.Drawing.SystemColors.Menu;
            this.chbfont.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbfont.FlatAppearance.BorderSize = 2;
            this.chbfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbfont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbfont.Location = new System.Drawing.Point(556, 29);
            this.chbfont.Name = "chbfont";
            this.chbfont.Size = new System.Drawing.Size(62, 34);
            this.chbfont.TabIndex = 2;
            this.chbfont.Text = "Font";
            this.chbfont.UseVisualStyleBackColor = false;
            this.chbfont.CheckedChanged += new System.EventHandler(this.chbfont_CheckedChanged);
            // 
            // chbcolor
            // 
            this.chbcolor.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbcolor.AutoSize = true;
            this.chbcolor.BackColor = System.Drawing.SystemColors.Menu;
            this.chbcolor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbcolor.FlatAppearance.BorderSize = 2;
            this.chbcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbcolor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbcolor.Location = new System.Drawing.Point(490, 29);
            this.chbcolor.Name = "chbcolor";
            this.chbcolor.Size = new System.Drawing.Size(70, 34);
            this.chbcolor.TabIndex = 3;
            this.chbcolor.Text = "Color";
            this.chbcolor.UseVisualStyleBackColor = false;
            this.chbcolor.CheckedChanged += new System.EventHandler(this.chbcolor_CheckedChanged);
            // 
            // chbsave
            // 
            this.chbsave.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbsave.AutoSize = true;
            this.chbsave.BackColor = System.Drawing.SystemColors.Menu;
            this.chbsave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbsave.FlatAppearance.BorderSize = 2;
            this.chbsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbsave.Location = new System.Drawing.Point(66, 29);
            this.chbsave.Name = "chbsave";
            this.chbsave.Size = new System.Drawing.Size(66, 34);
            this.chbsave.TabIndex = 4;
            this.chbsave.Text = "Save";
            this.chbsave.UseVisualStyleBackColor = false;
            this.chbsave.CheckedChanged += new System.EventHandler(this.chbsave_CheckedChanged);
            // 
            // chbopen
            // 
            this.chbopen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbopen.AutoSize = true;
            this.chbopen.BackColor = System.Drawing.SystemColors.Menu;
            this.chbopen.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbopen.FlatAppearance.BorderSize = 2;
            this.chbopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbopen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbopen.Location = new System.Drawing.Point(-3, 29);
            this.chbopen.Name = "chbopen";
            this.chbopen.Size = new System.Drawing.Size(72, 34);
            this.chbopen.TabIndex = 5;
            this.chbopen.Text = "Open";
            this.chbopen.UseVisualStyleBackColor = false;
            this.chbopen.CheckedChanged += new System.EventHandler(this.chbopen_CheckedChanged);
            // 
            // chbnew
            // 
            this.chbnew.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbnew.AutoSize = true;
            this.chbnew.BackColor = System.Drawing.SystemColors.Menu;
            this.chbnew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbnew.FlatAppearance.BorderSize = 2;
            this.chbnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbnew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbnew.Location = new System.Drawing.Point(-3, -1);
            this.chbnew.Name = "chbnew";
            this.chbnew.Size = new System.Drawing.Size(42, 23);
            this.chbnew.TabIndex = 6;
            this.chbnew.Text = "New";
            this.chbnew.UseVisualStyleBackColor = false;
            this.chbnew.CheckedChanged += new System.EventHandler(this.chbnew_CheckedChanged);
            // 
            // chbRedo
            // 
            this.chbRedo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbRedo.AutoSize = true;
            this.chbRedo.BackColor = System.Drawing.SystemColors.Menu;
            this.chbRedo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbRedo.FlatAppearance.BorderSize = 2;
            this.chbRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRedo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbRedo.Location = new System.Drawing.Point(191, 29);
            this.chbRedo.Name = "chbRedo";
            this.chbRedo.Size = new System.Drawing.Size(70, 34);
            this.chbRedo.TabIndex = 10;
            this.chbRedo.Text = "Redo";
            this.chbRedo.UseVisualStyleBackColor = false;
            this.chbRedo.CheckedChanged += new System.EventHandler(this.chbRedo_CheckedChanged);
            // 
            // chbUndo
            // 
            this.chbUndo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbUndo.AutoSize = true;
            this.chbUndo.BackColor = System.Drawing.SystemColors.Menu;
            this.chbUndo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbUndo.FlatAppearance.BorderSize = 2;
            this.chbUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUndo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbUndo.Location = new System.Drawing.Point(124, 29);
            this.chbUndo.Name = "chbUndo";
            this.chbUndo.Size = new System.Drawing.Size(70, 34);
            this.chbUndo.TabIndex = 9;
            this.chbUndo.Text = "Undo";
            this.chbUndo.UseVisualStyleBackColor = false;
            this.chbUndo.CheckedChanged += new System.EventHandler(this.chbUndo_CheckedChanged);
            // 
            // chbpaste
            // 
            this.chbpaste.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbpaste.AutoSize = true;
            this.chbpaste.BackColor = System.Drawing.SystemColors.Menu;
            this.chbpaste.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbpaste.FlatAppearance.BorderSize = 2;
            this.chbpaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbpaste.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbpaste.Location = new System.Drawing.Point(322, 29);
            this.chbpaste.Name = "chbpaste";
            this.chbpaste.Size = new System.Drawing.Size(71, 34);
            this.chbpaste.TabIndex = 8;
            this.chbpaste.Text = "Paste";
            this.chbpaste.UseVisualStyleBackColor = false;
            this.chbpaste.CheckedChanged += new System.EventHandler(this.chbpaste_CheckedChanged);
            // 
            // chbcopy
            // 
            this.chbcopy.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbcopy.AutoSize = true;
            this.chbcopy.BackColor = System.Drawing.SystemColors.Menu;
            this.chbcopy.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbcopy.FlatAppearance.BorderSize = 2;
            this.chbcopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbcopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbcopy.Location = new System.Drawing.Point(257, 29);
            this.chbcopy.Name = "chbcopy";
            this.chbcopy.Size = new System.Drawing.Size(68, 34);
            this.chbcopy.TabIndex = 7;
            this.chbcopy.Text = "Copy";
            this.chbcopy.UseVisualStyleBackColor = false;
            this.chbcopy.CheckedChanged += new System.EventHandler(this.chbcopy_CheckedChanged);
            // 
            // chbCut
            // 
            this.chbCut.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbCut.AutoSize = true;
            this.chbCut.BackColor = System.Drawing.SystemColors.Menu;
            this.chbCut.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbCut.FlatAppearance.BorderSize = 2;
            this.chbCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbCut.Location = new System.Drawing.Point(384, 29);
            this.chbCut.Name = "chbCut";
            this.chbCut.Size = new System.Drawing.Size(51, 34);
            this.chbCut.TabIndex = 11;
            this.chbCut.Text = "Cut";
            this.chbCut.UseVisualStyleBackColor = false;
            this.chbCut.CheckedChanged += new System.EventHandler(this.chbCut_CheckedChanged);
            // 
            // chbExit
            // 
            this.chbExit.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbExit.BackColor = System.Drawing.SystemColors.Menu;
            this.chbExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chbExit.FlatAppearance.BorderSize = 2;
            this.chbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbExit.Location = new System.Drawing.Point(1206, -1);
            this.chbExit.Name = "chbExit";
            this.chbExit.Size = new System.Drawing.Size(55, 23);
            this.chbExit.TabIndex = 12;
            this.chbExit.Text = "Exit";
            this.chbExit.UseVisualStyleBackColor = false;
            this.chbExit.CheckedChanged += new System.EventHandler(this.chbExit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1172, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "simple notepad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbExit);
            this.Controls.Add(this.chbCut);
            this.Controls.Add(this.chbRedo);
            this.Controls.Add(this.chbUndo);
            this.Controls.Add(this.chbpaste);
            this.Controls.Add(this.chbcopy);
            this.Controls.Add(this.chbnew);
            this.Controls.Add(this.chbopen);
            this.Controls.Add(this.chbsave);
            this.Controls.Add(this.chbcolor);
            this.Controls.Add(this.chbfont);
            this.Controls.Add(this.chkbold);
            this.Controls.Add(this.rchnotepad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchnotepad;
        private System.Windows.Forms.CheckBox chkbold;
        private System.Windows.Forms.CheckBox chbfont;
        private System.Windows.Forms.CheckBox chbcolor;
        private System.Windows.Forms.CheckBox chbsave;
        private System.Windows.Forms.CheckBox chbopen;
        private System.Windows.Forms.CheckBox chbnew;
        private System.Windows.Forms.CheckBox chbRedo;
        private System.Windows.Forms.CheckBox chbUndo;
        private System.Windows.Forms.CheckBox chbpaste;
        private System.Windows.Forms.CheckBox chbcopy;
        private System.Windows.Forms.CheckBox chbCut;
        private System.Windows.Forms.CheckBox chbExit;
        private System.Windows.Forms.Label label1;
    }
}

