﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Golodnor01
{
    public partial class FormDelMessage : Form
    {
        public FormDelMessage()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormDelMessage_Load(object sender, EventArgs e)
        {
            // Apply font
            labelExitMessage.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Bold);
            buttonNo.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            buttonYes.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
        }
    }
}
