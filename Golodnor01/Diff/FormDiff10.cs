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
    public partial class FormDiff10 : Form
    {
        public FormDiff10()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        int diffFound = 0;
        int count = 0;
        int numberClicked = 0;
        bool isOver = false;

        List<Control> listCircles = new List<Control>();

        // Check if all diffs are found
        private void CheckIfOver()
        {
            diffFound++;
            labelOutOfTen.Text = diffFound.ToString() + " / 10";
            if (diffFound == 10)
            {
                timerCountdown.Stop();
                Forms.formDiffMessage.labelMessage.Text =
                    "Поздравления! Получавате всичките 100 жълтици от тази игра!";
                Forms.formDiffMessage.ShowDialog();
                GlobalVars.coins += 100;
                pictureArrow.Visible = true;
                labelNext.Visible = true;
                this.Cursor = Cursors.Arrow;
            }
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        // Make circles visible
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox1.Enabled = false;
                pictureCircle1.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox2.Enabled = false;
                pictureCircle2.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox3.Enabled = false;
                pictureCircle3.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox4.Enabled = false;
                pictureCircle4.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox5.Enabled = false;
                pictureCircle5.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox6.Enabled = false;
                pictureCircle6.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox7.Enabled = false;
                pictureCircle7.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox8.Enabled = false;
                pictureCircle8.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox9.Enabled = false;
                pictureCircle9.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureBox10.Enabled = false;
                pictureCircle10.Visible = true;
                CheckIfOver();
            }
        }

        private void pictureBox0_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pictureBox0_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }


        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            count++;

            // Change image on timer
            switch (count)
            {
                case 1:
                    pictureTimer.Image = Properties.Resources.chart_piew1;
                    break;
                case 2:
                    pictureTimer.Image = Properties.Resources.chart_piew2;
                    break;
                case 3:
                    pictureTimer.Image = Properties.Resources.chart_piew3;
                    break;
                case 4:
                    pictureTimer.Image = Properties.Resources.chart_piew4;
                    break;
                case 5:
                    pictureTimer.Image = Properties.Resources.chart_piew5;
                    timerCountdown.Interval = 5000;
                    break;
            }

            if (count >= 6)
            {
                pictureTimer.Image = Properties.Resources.chart_piew6;
                timerCountdown.Stop();
                isOver = true;
                this.Cursor = Cursors.Arrow;
                if (diffFound == 0)
                {
                    Forms.formDiffMessage.labelMessage.Text =
                        "За съжаление не получавате нито една жълтица от тази игра.";
                }
                else
                {
                    Forms.formDiffMessage.labelMessage.Text =
                         "Поздравления! Получавате " + (diffFound * 10).ToString() + " жълтици от тази игра!";
                    GlobalVars.coins += diffFound * 10;
                }
                foreach (var circle in listCircles)
                {
                    circle.Visible = true;
                }
                pictureArrow.Visible = true;
                labelNext.Visible = true;
                Forms.formDiffMessage.ShowDialog();
            }

        }


        private void FormDiff10_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelMinusTenSeconds.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelOutOfTen.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelNext.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);

            timerCountdown.Start();

            // Put circles in a list
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox
                    && this.Controls[i].Name.StartsWith("pictureCircle"))
                {
                    listCircles.Add(this.Controls[i]);
                }
            }
        }

        private void FormDiff10_Click(object sender, EventArgs e)
        {
            // Take 10 sec of the time for 3 random clicks
            if (!isOver)
            {
                numberClicked++;
                if (numberClicked == 3)
                {
                    numberClicked = 0;
                    labelMinusTenSeconds.Visible = true;
                    timerPause.Start();
                    count += 1;
                }
            }
        }

        private void timerPause_Tick(object sender, EventArgs e)
        {
            // Hide labelMinusTenSeconds
            labelMinusTenSeconds.Visible = false;
            timerPause.Stop();
        }

        private void FormDiff10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormDiff10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void pictureArrow_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

    }
}