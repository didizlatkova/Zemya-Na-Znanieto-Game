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
    public partial class FormInstr1 : Form
    {
        public FormInstr1()
        {
            InitializeComponent();
            methods.EmbedFont();
        }       
       
        Methods methods = new Methods();

        private void FormInstr1_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelInstr1.Font = new Font(methods.myFont.Families[0], 19, FontStyle.Bold);
            labelSkip.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold | FontStyle.Underline);
        }

        private void pictureArrowRight_Click(object sender, EventArgs e)
        {
            Forms.formInstr2.Show();
            this.Hide();
        }                

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);           
        }       

        private void FormInstr1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void labelSkip_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }  
    }
}
