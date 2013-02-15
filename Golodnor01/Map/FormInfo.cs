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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        // Show bonus question or map
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (GlobalVars.isBonusQuestion)
            {
                Forms.formQuestion.Hide();
                Forms.formQuestion.Show();
            }
            else
            {
                Forms.formMap.Show();
                Forms.formQuestion.Hide();
            }
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            // Apply font
            labelInfo1.Font = new Font(methods.myFont.Families[0], 15, FontStyle.Bold);
            labelInfo2.Font = new Font(methods.myFont.Families[0], 15, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
