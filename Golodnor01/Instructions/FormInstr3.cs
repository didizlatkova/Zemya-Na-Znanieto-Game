using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Golodnor01
{
    public partial class FormInstr3 : Form
    {
        public FormInstr3()
        {
            InitializeComponent();
            methods.EmbedFont();
        }              
      
        Methods methods = new Methods();


        private void FormInstr3_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelInstr1.Font = new Font(methods.myFont.Families[0], 19, FontStyle.Bold);
            labelInstr3.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelStart.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold); 
        }

        private void pictureArrowLeft_Click(object sender, EventArgs e)
        {
            Forms.formInstr2.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void pictureArrowStart_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void FormInstr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 37)
            {
                pictureArrowLeft_Click(sender, e);
            }
            else if (e.KeyChar == 13)
            {
                labelStart_Click(sender, e);
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
     
    }
}
