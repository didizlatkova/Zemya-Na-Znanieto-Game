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
    public partial class FormPuzzleMessage : Form
    {
        public FormPuzzleMessage()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormMusic_Load(object sender, EventArgs e)
        {
            labelPuzzleMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            Forms.formPuzzle.Hide();
        }
    }
}
