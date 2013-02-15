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
    public partial class FormHintBuy : Form
    {
        public FormHintBuy()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void buttonYes_Click(object sender, EventArgs e)
        {
            GlobalVars.isBuying = true;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            GlobalVars.isBuying = false;
        }

        private void FormHintBuy_Load(object sender, EventArgs e)
        {
            // Apply font
            labelBuy.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonNo.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            buttonYes.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
        }
    }
}
