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
    public partial class FormMe : Form
    {
        public FormMe()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormMe_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Apply font
            labelMain.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelInfo.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelInfo2.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
        }

        private void labelMain_Click(object sender, EventArgs e)
        {
            Forms.formMain.Show();
            this.Hide();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

        private void FormMe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }
    }
}
