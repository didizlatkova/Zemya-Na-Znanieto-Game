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
    public partial class FormRiddle3 : Form
    {
        public FormRiddle3()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        bool isAnswered = false;
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        // Do when game is over
        public void deActivate()
        {
            isAnswered = true;
            labelSkip.Text = "НАПРЕД";
            textBoxAns.Enabled = false;
            deCursor();
            deTooltip();
            Forms.formRiddleMessage.ShowDialog();
        }

        public void deCursor()
        {
            labelHint.Cursor = Cursors.Arrow;
            buttonOk.Cursor = Cursors.Arrow;
            pictureQuestion.Cursor = Cursors.Arrow;
        }

        public void deTooltip()
        {
            ToolTip1.SetToolTip(this.labelHint, null);
        }

        // Handle any given answer
        public void Answer(string ans)
        {
            if (ans == "e" || ans == "е")
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Поздравления! Спечелихте 100 жълтици от тази игра!";
                GlobalVars.coins += 100;
                labelCoins.Text = GlobalVars.coins.ToString();
                deActivate();
            }
            else
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Грешен отговор, опитай пак!";
                Forms.formRiddleMessage.ShowDialog();
            }
        }

        private void FormRiddle3_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            this.AcceptButton = buttonOk;

            // Apply font
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelQuestion.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelHint.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH1.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH2.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH3.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);

            labelCoins.Text = GlobalVars.coins.ToString();

            ToolTip1.SetToolTip(this.labelHint, "Купи");

            Forms.formGameMessage.labelGameMessage.Text = @"Целта на играта е да отговорите на загадката. 
            Ако се затрудните, използвайте подсказките, но ще трябва да платите 20 жълтици! При вярно решение, получавате 100 жълтици!";
        }

        // Show hint
        private void labelHint1_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                if (GlobalVars.coins >= 20)
                {
                    if (labelH2.Visible == true)
                    {
                        labelHint.Visible = false;
                        labelH3.Visible = true;
                    }
                    else if (labelH1.Visible == true)
                    {
                        labelH2.Visible = true;
                    }
                    else
                    {
                        labelH1.Visible = true;
                    }

                    GlobalVars.coins -= 20;
                    labelCoins.Text = GlobalVars.coins.ToString();
                }
                else
                {
                    Forms.formRiddleMessage.labelRiddleMessage.Text = "Нямате достатъчно жълтици за подсказка!";
                    Forms.formRiddleMessage.ShowDialog();
                }
            }
        }
        
        // Skip the game
        private void labelSkip_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                textBoxAns.Text = "е";
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
        
        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Forms.formGameMessage.ShowDialog();
            }
        }

        private void FormRiddle3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormRiddle3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

        // Give an answer
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Answer(textBoxAns.Text);
            }
        }
    }
}
