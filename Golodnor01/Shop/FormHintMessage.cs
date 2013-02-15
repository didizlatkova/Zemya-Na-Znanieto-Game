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
    public partial class FormHintMessage : Form
    {
        public FormHintMessage()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormHintMessage_Load(object sender, EventArgs e)
        {
            // Apply font
            labelHintMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
        }
    }
}
