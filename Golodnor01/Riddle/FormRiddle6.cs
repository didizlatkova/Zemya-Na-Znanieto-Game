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
    public partial class FormRiddle6 : Form
    {
        public FormRiddle6()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        bool isAnswered = false;

        // Do when game is over
        public void deActivate()
        {
            isAnswered = true;
            labelSkip.Text="НАПРЕД";
            textBoxAns.Enabled = false;
            deCursor();
            Forms.formRiddleMessage.ShowDialog();
        }

        public void deCursor()
        {
            buttonOk.Cursor = Cursors.Arrow;
            pictureQuestion.Cursor = Cursors.Arrow;
        }

        // Handle any answer given
        public void Answer(string ans)
        {
            if (ans == "4" || ans=="четири")
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Поздравления! Спечелихте 100 жълтици от тази игра!";
                GlobalVars.coins += 100;
                deActivate();
            }
            else
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Грешен отговор, опитай пак!";
                Forms.formRiddleMessage.ShowDialog();
            }
        }

        private void FormRiddle6_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Set font
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);

            this.AcceptButton = buttonOk;
            
            Forms.formGameMessage.labelGameMessage.Text = @"Целта на играта е да отговорите на следната загадка: 
Дадени са три везни, като първите две са уравновесени. 
Колко на брой кари трябва да се сложат на теглилката от третата везна, за да се уравновеси и тя?
При вярно решение, получавате 100 жълтици!";
        }

        // Skip the game
        private void labelSkip_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                textBoxAns.Text = "4";
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "За съжаление не получавате нито една жълтица от тази игра.";
                deActivate();
            }
            else
            {
                Forms.formMap.Show();
                this.Hide();
            }
        }

        private void pictureOk_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Answer(textBoxAns.Text);
            }
        }
        
        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Forms.formGameMessage.ShowDialog();
            }
        }

        private void FormRiddle6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormRiddle6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Answer(textBoxAns.Text);
            }
        }
    }
}
