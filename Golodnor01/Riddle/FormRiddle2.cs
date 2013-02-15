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
    public partial class FormRiddle2 : Form
    {
        public FormRiddle2()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        int x = 34, y = 389;
        bool isAnswered = false;
        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        // Do when game is over
        public void deActivate()
        {
            isAnswered = true;
            labelSkip.Text = "НАПРЕД";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            deCursor();
            deTooltip();
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

        // Handle any answer given
        public void Answer(string gap1, string gap2, string gap3)
        {
            if ((gap1 == "t" || gap1 == "т") && (gap2 == "d" || gap2 == "д")
                && (gap3 == "e" || gap3 == "е"))
            {
                pictureSecondRocket.Visible = true;
                pictureFirstRocket.Visible = false;
                timerRocket.Start();
                deActivate();
            }
            else
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Грешен отговор, опитай пак!";
                Forms.formRiddleMessage.ShowDialog();
            }
        }
        
        private void FormRiddle2_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            this.AcceptButton = buttonOk;

            // Apply font
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelHint.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH1.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH2.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelH3.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            labelCoins.Text = GlobalVars.coins.ToString();

            ToolTip1.SetToolTip(this.labelHint, "Купи");

            Forms.formGameMessage.labelGameMessage.Text = @"Целта на играта е да изстреляте ракетата. 
Ако се затрудните, използвайте подсказките, но ще трябва да платите 20 жълтици! При вярно решение, получавате 100 жълтици!";
        }

        // Make rocket fly
        private void timerRocket_Tick(object sender, EventArgs e)
        {
            if (y < -262)
            {
                timerRocket.Stop();
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                    "Поздравления! Спечелихте 100 жълтици от тази игра!";
                Forms.formRiddleMessage.ShowDialog();
                deActivate();
                GlobalVars.coins += 100;
                labelCoins.Text = GlobalVars.coins.ToString();
            }
            else
            {
                y -= 80;
                pictureSecondRocket.Location = new Point(x, y);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox3.Focus();
            }
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
                textBox1.Text = "т";
                textBox2.Text = "д";
                textBox3.Text = "е";
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
        
        private void FormRiddle2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormRiddle2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Forms.formGameMessage.ShowDialog();
            }
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
                Answer(textBox1.Text, textBox2.Text, textBox3.Text);
            }
        }
    }
}

