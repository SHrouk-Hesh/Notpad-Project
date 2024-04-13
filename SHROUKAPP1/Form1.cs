using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHROUKAPP
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
            path = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                rtx_txt.SaveFile(saveFD.FileName);
                rtx_txt.Clear();
                path = null;

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFD.ShowDialog() == DialogResult.OK)
            {
                rtx_txt.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path==null)
            {
                saveToolStripMenuItem1_Click(null, null);
            }
            else
            {
                rtx_txt.SaveFile(path);
                rtx_txt.Clear();
                path = null;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtx_txt.Text != "")
            {
                if(MessageBox.Show("DO YOU WANT TO SAVE YOUR NOTEPAD FILE?","CONFIRM",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtx_txt.Text != "")
            {
                if (MessageBox.Show("DO YOU WANT TO SAVE YOUR NOTEPAD FILE?", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            path = null;
            rtx_txt.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontD.ShowDialog()== DialogResult.OK) 
            {
                if(rtx_txt.SelectedText !="")
                    rtx_txt.SelectionFont= fontD.Font;
                
                else
                    rtx_txt.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_txt.SelectedText != "")
                    rtx_txt.SelectionColor= colorD.Color;
                else
                    rtx_txt.ForeColor= colorD.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtx_txt.SelectedText != "")
                    rtx_txt.SelectionBackColor = colorD.Color;
                else
                    rtx_txt.BackColor = colorD.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtx_txt.Text != "")
            {
                if (MessageBox.Show("DO YOU WANT TO SAVE YOUR NOTEPAD FILE?", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
        }

        private void rtx_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
