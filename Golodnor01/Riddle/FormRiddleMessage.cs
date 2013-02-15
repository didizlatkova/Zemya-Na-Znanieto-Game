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
    public partial class FormRiddleMessage : Form
    {
        public FormRiddleMessage()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormRiddleMessage_Load(object sender, EventArgs e)
        {
            // Apply font
            labelRiddleMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
        }
    }
}
