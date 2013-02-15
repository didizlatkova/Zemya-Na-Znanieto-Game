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
    public partial class FormExit : Form
    {
        public FormExit()
        {
            InitializeComponent();
            methods.EmbedFont();
        }
        
        Methods methods = new Methods();        

        private void pictureYes_Click(object sender, EventArgs e)
        {
            GlobalVars.isClosed = true;
            this.Hide();

        }

        private void pictureNo_Click(object sender, EventArgs e)
        {
            GlobalVars.isClosed = false;
            this.Hide();
        }

        private void FormExit_Load(object sender, EventArgs e)
        {
            // Apply font
            labelExitMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonNo.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            buttonYes.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            GlobalVars.isClosed = true;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            GlobalVars.isClosed = false;
        }

       
        

    }
}
