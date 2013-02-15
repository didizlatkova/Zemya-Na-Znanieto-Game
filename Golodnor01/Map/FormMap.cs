using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Golodnor01
{
    public partial class FormMap : Form
    {

        public FormMap()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        List<Form> listDiffs = new List<Form>();
        List<Control> listCircles = new List<Control>();
        List<Control> sortedListCircles = new List<Control>();
        bool isFirstTimeMap = true;
        int numberRiddle;
        int coinsToGive = 10;

        private void FormMap_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Apply font
            labelMain.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelShop.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelShopMessage.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelArrowMessage.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            // Add pictures of circles to a list
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureQ"))
                {
                    listCircles.Add(this.Controls[i]);
                }
            }

            // Sort the list of circles
            var sortedCircles =
                listCircles.OrderBy(picture => picture.Name);
            foreach (var control in sortedCircles)
            {
                sortedListCircles.Add(control);
            }
        }

        private void pictureArrow_Click(object sender, EventArgs e)
        {
            isFirstTimeMap = false;

            int totalNumber = GlobalVars.numberQuestion + GlobalVars.numberGame;            

            // Check if current item is a question
            if (GlobalVars.isQuestion)
            {
                GlobalVars.numberQuestion++;

                // Check if level needs changing
                switch (GlobalVars.numberQuestion)
                {
                    case 1:
                        {
                            // Change music
                            Forms.formMusic.axIntro.Ctlcontrols.stop();
                            if (Forms.formMusic.trackBarMusic.Value != 0)
                            {
                                Forms.formMusic.axLevel1.Ctlcontrols.play();
                            }
                            (Forms.formMusic.axLevel1.settings as WMPLib.IWMPSettings).setMode("loop", true);
                            Forms.formMusic.axLevel1.settings.volume = Forms.formMusic.trackBarMusic.Value;
                            GlobalVars.isIntroPlaying = false;
                            GlobalVars.is1Playing = true;

                            // Change background
                            Forms.formQuestion.BackgroundImage = Properties.Resources.QBackgroundRed;
                            Forms.formQuestion.labelAnswerA.Image = Properties.Resources.buttonRedQ;
                            Forms.formQuestion.labelAnswerB.Image = Properties.Resources.buttonRedQ;
                            Forms.formQuestion.labelAnswerC.Image = Properties.Resources.buttonRedQ;
                            Forms.formQuestion.labelAnswerD.Image = Properties.Resources.buttonRedQ;
                            break;
                        }
                    case 9:
                        {
                            GlobalVars.numberLevel++;
                            // Change music
                            Forms.formMusic.axLevel1.Ctlcontrols.pause();
                            if (Forms.formMusic.trackBarMusic.Value != 0)
                            {
                                Forms.formMusic.axLevel2.Ctlcontrols.play();
                            }
                            (Forms.formMusic.axLevel2.settings as WMPLib.IWMPSettings).setMode("loop", true);
                            Forms.formMusic.axLevel2.settings.volume = Forms.formMusic.trackBarMusic.Value;
                            GlobalVars.is1Playing = false;
                            GlobalVars.is2Playing = true;

                            // Change background
                            Forms.formQuestion.BackgroundImage = Properties.Resources.QBackgroundBrown;
                            Forms.formQuestion.labelAnswerA.Image = Properties.Resources.buttonBrownQ;
                            Forms.formQuestion.labelAnswerB.Image = Properties.Resources.buttonBrownQ;
                            Forms.formQuestion.labelAnswerC.Image = Properties.Resources.buttonBrownQ;
                            Forms.formQuestion.labelAnswerD.Image = Properties.Resources.buttonBrownQ;
                            break;
                        }

                    case 14:
                        {
                            GlobalVars.numberLevel++;
                            // Change music
                            Forms.formMusic.axLevel2.Ctlcontrols.pause();
                            if (Forms.formMusic.trackBarMusic.Value != 0)
                            {
                                Forms.formMusic.axLevel3.Ctlcontrols.play();
                            }
                            (Forms.formMusic.axLevel3.settings as WMPLib.IWMPSettings).setMode("loop", true);
                            Forms.formMusic.axLevel3.settings.volume = Forms.formMusic.trackBarMusic.Value;
                            GlobalVars.is2Playing = false;
                            GlobalVars.is3Playing = true;

                            // Change background
                            Forms.formQuestion.BackgroundImage = Properties.Resources.QBackgroundGrey;
                            Forms.formQuestion.labelAnswerA.Image = Properties.Resources.buttonGrayQ;
                            Forms.formQuestion.labelAnswerB.Image = Properties.Resources.buttonGrayQ;
                            Forms.formQuestion.labelAnswerC.Image = Properties.Resources.buttonGrayQ;
                            Forms.formQuestion.labelAnswerD.Image = Properties.Resources.buttonGrayQ;
                            break;
                        }

                    case 18:
                        {
                            GlobalVars.numberLevel++;
                            // Change music
                            Forms.formMusic.axLevel3.Ctlcontrols.pause();
                            if (Forms.formMusic.trackBarMusic.Value != 0)
                            {
                                Forms.formMusic.axLevel4.Ctlcontrols.play();
                            }
                            (Forms.formMusic.axLevel4.settings as WMPLib.IWMPSettings).setMode("loop", true);
                            Forms.formMusic.axLevel4.settings.volume = Forms.formMusic.trackBarMusic.Value;
                            GlobalVars.is3Playing = false;
                            GlobalVars.is4Playing = true;

                            // Change background
                            Forms.formQuestion.BackgroundImage = Properties.Resources.QBackgroundGreen;
                            Forms.formQuestion.labelAnswerA.Image = Properties.Resources.buttonGreenQ;
                            Forms.formQuestion.labelAnswerB.Image = Properties.Resources.buttonGreenQ;
                            Forms.formQuestion.labelAnswerC.Image = Properties.Resources.buttonGreenQ;
                            Forms.formQuestion.labelAnswerD.Image = Properties.Resources.buttonGreenQ;
                            break;
                        }
                }

                // Check if next item is a game
                switch (GlobalVars.numberQuestion)
                {
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                    case 15:
                    case 20:
                        {
                            GlobalVars.isQuestion = false;
                            break;
                        }
                }
                
                Forms.formQuestion.Show();

                if (GlobalVars.numberQuestion < 21)
                {
                    // Move arrow
                    pictureArrowDown.Location = new Point(sortedListCircles[totalNumber + 1].Location.X,
                        sortedListCircles[totalNumber + 1].Location.Y - 35);

                    // Make the circle of the previous question visible
                    sortedListCircles[totalNumber].Visible = true;
                }

                this.Hide();
            }
            else
            {
                GlobalVars.numberGame++;
                GlobalVars.isQuestion = true;
                switch (GlobalVars.numberGame)
                {
                        // Escape
                    case 6:
                        {
                            // Set message
                            Forms.formGameMessage.labelGameMessage.Text =
@"Поздравления! Успя да отговориш на всички въпроси и да достигнеш до върха на планината, но, залисан в размишления, 
се озова в къщата на един непознат. Сега трябва да излезеш от нея, за да завършиш играта!";

                            Forms.formEscape.Show();
                            break;
                        }
                    // Game
                    case 5:
                        {
                            Random r = new Random();
                            int num = r.Next(1, 8);
                            string typeName = "Golodnor01.FormGame" + num.ToString(CultureInfo.InvariantCulture);
                            Form f = (Form)Activator.CreateInstance(Type.GetType(typeName));
                            f.Show();
                            break;
                        }
                    // Riddle
                    case 4:
                        {
                            Random r = new Random();
                            int num = r.Next(1, 13);
                            switch (num)
                            {
                                case 1:
                                    {
                                        numberRiddle = 1;
                                        break;
                                    }
                                case 2:
                                    {
                                        numberRiddle = 2;
                                        break;
                                    }
                                case 3:
                                    {
                                        numberRiddle = 3;
                                        break;
                                    }
                                case 4:
                                    {
                                        numberRiddle = 6;
                                        break;
                                    }
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                    {
                                        numberRiddle = 5;
                                        break;
                                    }
                                case 9:
                                case 10:
                                case 11:
                                case 12:
                                    {
                                        numberRiddle = 4;
                                        break;
                                    }
                            }
                            string typeName = "Golodnor01.FormRiddle" + numberRiddle.ToString(CultureInfo.InvariantCulture);
                            Form f = (Form)Activator.CreateInstance(Type.GetType(typeName));
                            f.Show();
                            break;
                        }

                    // Puzzle
                    case 3:
                        {
                            // Set message
                            Forms.formGameMessage.labelGameMessage.Text =
@"Целта на играта е по логически път да откриете кой е следващият символ в редицата. 
Ако го направите, печелите 50 жълтици!";

                            Forms.formPuzzle.Show();
                            break;
                        }

                    // Hangman
                    case 1:
                        {
                            // Set message
                            Forms.formGameMessage.labelGameMessage.Text = @"Предстои игра на бесеница. 
Можете да изберете категория и да платите 10 жълтици или да играете в произволна такава. 
При позната дума печелите 20 жълтици, а при три грешни думи играта приключва.";

                            Forms.formHangmanMain.Show();
                            break;
                        }

                    // Diff
                    case 2:
                        {
                            // Set message
                            Forms.formGameMessage.labelGameMessage.Text =
@"Целта на играта е да откриете 10-те разлики. 
Имате 60 секунди, но ако кликате на произволни места, ще Ви се отнема от времето!";

                            Random r = new Random();
                            int num = r.Next(1, 11);
                            string typeName = "Golodnor01.FormDiff" + num.ToString(CultureInfo.InvariantCulture);
                            Form f = (Form)Activator.CreateInstance(Type.GetType(typeName));
                            f.Show();
                            break;
                        }
                }
                Forms.formGameMessage.ShowDialog();

                if (GlobalVars.numberQuestion < 21)
                {
                    //MessageBox.Show("yes");
                    // Move arrow
                    pictureArrowDown.Location = new Point(sortedListCircles[totalNumber + 1].Location.X,
                        sortedListCircles[totalNumber + 1].Location.Y - 35);

                    // Make the circle of the previous question visible
                    sortedListCircles[totalNumber].Visible = true;
                }
                this.Hide();
            }
        }

        private void FormMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void pictureArrowMain_Click(object sender, EventArgs e)
        {
            Forms.formMain.Show();
            this.Hide();
        }

        private void labelMain_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GlobalVars.isGameStarted.ToString());
            Forms.formMain.Show();
            this.Hide();
        }

        private void labelShop_Click(object sender, EventArgs e)
        {
            Forms.formShop.Show();
            this.Hide();
        }

        private void pictureArrowShop_Click(object sender, EventArgs e)
        {
            Forms.formShop.Show();
            this.Hide();
        }

        private void pictureArrowDown_MouseEnter(object sender, EventArgs e)
        {
            if (isFirstTimeMap)
            {
                labelArrowMessage.Visible = false;
            }
        }

        private void pictureArrowDown_MouseLeave(object sender, EventArgs e)
        {
            if (isFirstTimeMap)
            {
                labelArrowMessage.Visible = true;
            }
        }

        private void FormMap_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                labelCoins.Text = GlobalVars.coins.ToString();

                if (!isFirstTimeMap)
                {
                    labelArrowMessage.Visible = false;
                    labelShopMessage.Visible = false;
                }

                if (!GlobalVars.isNotMapFirstLoad)
                {
                    pictureArrowDown.Location = new Point(16, 359);
                    foreach (var circle in sortedListCircles)
                    {
                        circle.Visible = false;
                    }
                    GlobalVars.isNotMapFirstLoad = true;
                }
            }
        }

        private void labelShop_MouseEnter(object sender, EventArgs e)
        {
            if (isFirstTimeMap)
            {
                labelShopMessage.Visible = false;
            }
        }

        private void labelShop_MouseLeave(object sender, EventArgs e)
        {
            if (isFirstTimeMap)
            {
                labelShopMessage.Visible = true;
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
