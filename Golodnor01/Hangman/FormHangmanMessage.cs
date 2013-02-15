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
    public partial class FormHangmanMessage : Form
    {
        public FormHangmanMessage()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!Forms.formHangMan.isOver)
            {
                Forms.formHangmanMain.Show();
            }
            else
            {
                Forms.formMap.Show();
            }            
            Forms.formHangMan.Hide();            
        }

        private void FormHangmanMessage_Load(object sender, EventArgs e)
        {
            // Apply font
            labelMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
        }
    }
}
