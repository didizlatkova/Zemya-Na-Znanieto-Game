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
    public partial class FormAdminLog : Form
    {
        public FormAdminLog()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPsw.Text != Properties.Settings.Default.adminPsw)
            {
                this.DialogResult = DialogResult.None;
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Грешна парола!";
                Forms.formPlayerMessage.ShowDialog();
                textBoxPsw.SelectAll();
            }
            else
            {
                buttonOk.DialogResult = DialogResult.Yes;                
            }
        }

        private void FormAdminLog_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                textBoxPsw.Clear();
                this.ActiveControl = textBoxPsw;
            }
        }

        private void FormAdminLog_Load(object sender, EventArgs e)
        {
            // Apply font
            labelExpl.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            textBoxPsw.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            buttonOk.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonCancel.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            this.AcceptButton = buttonOk;
        }
    }
}
