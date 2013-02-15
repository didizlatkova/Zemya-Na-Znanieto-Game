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
    public partial class FormGame7 : Form
    {
        public FormGame7()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        List<Control> listBall = new List<Control>();
        List<Control> listBlank = new List<Control>();
        bool isOver = false;
        Control selectedBall = null;
        int numberTries = 0;

        // Make balls and blanks unclickable
        private void deActivate()
        {
            Forms.formRiddleMessage.ShowDialog();

            foreach (var bally in listBall)
            {
                bally.BackColor = Color.Transparent;
                bally.BackgroundImage = Properties.Resources.football;              

                bally.Cursor = Cursors.Arrow;
            }

            foreach (var blank in listBlank)
            {
                blank.BackColor = Color.Transparent;
                blank.BackgroundImage = null;
                blank.Cursor = Cursors.Arrow;
            }

            labelSkip.Text = "НАПРЕД";
            isOver = true;
            labelRestart.Cursor = Cursors.Arrow;
            pictureQuestion.Cursor = Cursors.Arrow;
        }
        
        // Restart the game from beginning
        private void Restart()
        {
            numberTries = 0;

            listBlank.Clear();
            listBall.Clear();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureBall"))
                {
                    if (this.Controls[i].Name == "pictureBall1" || this.Controls[i].Name == "pictureBall2"
                        || this.Controls[i].Name == "pictureBall3" || this.Controls[i].Name == "pictureBall4"
                        || this.Controls[i].Name == "pictureBall5" || this.Controls[i].Name == "pictureBall6"
                        || this.Controls[i].Name == "pictureBall7" || this.Controls[i].Name == "pictureBall8"
                        || this.Controls[i].Name == "pictureBall9" || this.Controls[i].Name == "pictureBall10")
                    {
                        listBall.Add(this.Controls[i]);
                    }
                    else
                    {
                        listBlank.Add(this.Controls[i]);
                    }
                }
            }

            foreach (var bally in listBall)
            {
                bally.BackColor = Color.Transparent;
                bally.BackgroundImage = Properties.Resources.football;
                bally.Cursor = Cursors.Hand;
            }

            foreach (var blank in listBlank)
            {
                blank.BackColor = Color.Transparent;
                blank.BackgroundImage = null;
                blank.Cursor = Cursors.Arrow;
            }

            selectedBall = null;
        }

        // Handle any clicked object
        private void ClickBall(Control ball)
        {
            if (!isOver && numberTries < 3)
            {
                // Check if object is a ball
                if (listBall.Contains(ball) && (selectedBall == null || selectedBall == ball))
                {
                    // Check if ball is already selected
                    if (ball.BackColor == Color.Maroon)
                    {
                        // Deselect ball
                        ball.BackColor = Color.Transparent;
                        selectedBall = null;
                        foreach (var blank in listBlank)
                        {
                            blank.Cursor = Cursors.Arrow;
                        }
                        foreach (var bally in listBall)
                        {
                            bally.Cursor = Cursors.Hand;
                        }
                    }
                    else
                    {
                        // Select the ball
                        ball.BackColor = Color.Maroon;
                        selectedBall = ball;
                        foreach (var blank in listBlank)
                        {
                            blank.Cursor = Cursors.Hand;
                        }
                        foreach (var bally in listBall)
                        {
                            if (bally != ball)
                            {
                                bally.Cursor = Cursors.Arrow;
                            }
                        }
                    }
                }
                // Check if selected object is a blank
                else if (listBlank.Contains(ball))
                {
                    // Check if a ball is selected
                    if (selectedBall != null)
                    {
                        // Turn blank to ball and ball to blank
                        listBall.Remove(selectedBall);
                        listBlank.Add(selectedBall);

                        numberTries++;
                        ball.BackColor = Color.Transparent;
                        listBlank.Remove(ball);
                        listBall.Add(ball);
                        ball.BackgroundImage = Properties.Resources.football;

                        foreach (var blank in listBlank)
                        {
                            blank.BackgroundImage = null;
                            blank.BackColor = Color.Transparent;
                            blank.Cursor = Cursors.Arrow;
                        }

                        foreach (var bally in listBall)
                        {
                            bally.Cursor = Cursors.Hand;
                        }
                        selectedBall = null;

                        if (numberTries == 3)
                        {
                            if (listBall.Contains(pictureBall2) && listBall.Contains(pictureBall3)
                                && listBall.Contains(pictureBall4) && listBall.Contains(pictureBall5)
                                && listBall.Contains(pictureBall6) && listBall.Contains(pictureBall7)
                                && listBall.Contains(pictureBall8) && listBall.Contains(pictureBall11)
                                && listBall.Contains(pictureBall12) && listBall.Contains(pictureBall13))
                            {
                                Forms.formRiddleMessage.labelRiddleMessage.Text =
                                    "Браво! Подредихте топките правилно и печелите 100 жълтици!";
                                GlobalVars.coins += 100;      
                                deActivate();
                            }
                            else
                            {
                                labelRestart.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Set font
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            Forms.formGameMessage.labelGameMessage.Text = @"Десет футболни топки са подредени така, 
че да образуват триъгълник. Целта на играта е да преместите само три топки така, че триъгълникът да сочи надолу вместо нагоре.";            
            Restart();
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                Restart();
                labelRestart.Visible = false;
            }
        }

        private void labelSkip_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                                  "За съжаление не успяхте да спечелите никакви жълтици.";

                // Show correct answer
                listBlank.Clear();
                listBall.Clear();

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureBall"))
                    {
                        if (this.Controls[i].Name == "pictureBall2" || this.Controls[i].Name == "pictureBall3"
                            || this.Controls[i].Name == "pictureBall4" || this.Controls[i].Name == "pictureBall5"
                            || this.Controls[i].Name == "pictureBall6" || this.Controls[i].Name == "pictureBall7"
                            || this.Controls[i].Name == "pictureBall8" || this.Controls[i].Name == "pictureBall11"
                            || this.Controls[i].Name == "pictureBall12" || this.Controls[i].Name == "pictureBall13")
                        {
                            listBall.Add(this.Controls[i]);
                        }
                        else
                        {
                            listBlank.Add(this.Controls[i]);
                        }
                    }
                }
                deActivate();
            }
            else
            {
                Forms.formMap.Show();
                this.Hide();
            }

        }

        private void pictureBall1_Click(object sender, EventArgs e)
        {
            ClickBall((PictureBox)sender);
        }

        private void FormGame7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormGame7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                Forms.formGameMessage.ShowDialog();
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
