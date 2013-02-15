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
    public partial class FormRiddle4 : Form
    {
        public FormRiddle4()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        bool isAnswered = false;
        string corrAns1;
        string corrAns2;
        Random r = new Random();
        int numberRiddle;

        // Do when game is over
        public void deActivate()
        {
            isAnswered = true;
            labelSkip.Text = "НАПРЕД";
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
            if (ans == corrAns1 || ans == corrAns2)
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

        private void FormRiddle4_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            this.AcceptButton = buttonOk;

            // Apply font
            labelQ1.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelQ2.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelQ3.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelQ4.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);

            Forms.formGameMessage.labelGameMessage.Text = @"Целта на играта е да отговорите на загадката.
При вярно решение, получавате 100 жълтици!";
        }

        // Skip the game
        private void labelSkip_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                textBoxAns.Text = corrAns1;
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

        private void FormRiddle4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormRiddle4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormRiddle4_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                labelQ1.Visible = false;
                labelQ2.Visible = false;
                labelQ3.Visible = false;
                labelQ4.Visible = false;

                numberRiddle = r.Next(1, 5);

                // Show a random riddle
                switch (numberRiddle)
                {
                    case 1:
                        {
                            corrAns1 = "5";
                            corrAns2 = "пет";
                            labelQ1.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            corrAns1 = "0";
                            corrAns2 = "нула";
                            labelQ2.Visible = true;
                            break;
                        }

                    case 3:
                        {
                            corrAns1 = "името";
                            corrAns2 = "името ми";
                            labelQ3.Visible = true;
                            break;
                        }

                    case 4:
                        {
                            corrAns1 = "снежен";
                            corrAns2 = "снежен човек";
                            labelQ4.Visible = true;
                            break;
                        }
                }
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Answer(textBoxAns.Text);
            }
        }
    }
}
