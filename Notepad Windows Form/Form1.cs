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

namespace Notepad_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbnew_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Clear();
        }
        private void chbopen_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog opnfidilg = new OpenFileDialog();
            opnfidilg.Filter = "Rich Text Format|*.ntp";
            if (opnfidilg.ShowDialog() == DialogResult.OK)
            {
                rchnotepad.Text = File.ReadAllText(opnfidilg.FileName);
            }
        }

        private void chbsave_CheckedChanged(object sender, EventArgs e)
        {
            SaveFileDialog svfildilg = new SaveFileDialog();
            svfildilg.Filter = "*.ntp|Rich Text Format";
            svfildilg.DefaultExt = "ntp";
            if (svfildilg.ShowDialog() == DialogResult.OK)
            {
                rchnotepad.SaveFile(svfildilg.FileName, RichTextBoxStreamType.RichText);
            }
        }
        private void chbUndo_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Undo();
        }

        private void chbRedo_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Redo();
        }

        private void chbcopy_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Copy();
        }

        private void chbpaste_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Paste();
        }



        private void chbCut_CheckedChanged(object sender, EventArgs e)
        {
            rchnotepad.Cut();
        }

        private void chkbold_CheckedChanged(object sender, EventArgs e)
        {
            Font font = rchnotepad.SelectionFont;
            font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
            rchnotepad.SelectionFont = font;
        }
        private void chbcolor_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog clrdilg = new ColorDialog();
            if (clrdilg.ShowDialog() == DialogResult.OK)
            {
                rchnotepad.SelectionColor = clrdilg.Color;
            }
        }
        private void chbfont_CheckedChanged(object sender, EventArgs e)
        {
            FontDialog fontdilg = new FontDialog();
            if (fontdilg.ShowDialog() == DialogResult.OK)
            {
                rchnotepad.SelectionFont = fontdilg.Font;
            }
        }
        private void chbExit_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
