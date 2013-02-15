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
    public partial class FormPuzzle : Form
    {
        public FormPuzzle()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        Random randomNumber = new Random();
        int numberPuzzle;
        PictureBox correctAns;

        private void FormPuzzle_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
        }

        // Handle any clicked answer
        private void pictureA_Click(object sender, EventArgs e)
        {
            if ((Control)sender == correctAns)
            {
                if (numberPuzzle == 10)
                {
                    Forms.formPuzzleMessage.labelPuzzleMessage.Text =
                        "Прислужницата е излъгала - пощата не идва в неделя! Печелите 50 жълтици!";
                }
                else if (numberPuzzle == 11)
                {
                    Forms.formPuzzleMessage.labelPuzzleMessage.Text =
                        "Щом не са яли от 6 месеца, лъвовете са умрели! Печелите 50 жълтици!";
                }
                else
                {
                    Forms.formPuzzleMessage.labelPuzzleMessage.Text =
                       "Браво! Отговорихте правилно на загадката и печелите 50 жълтици!";
                }
                GlobalVars.coins += 50;
            }
            else
            {
                Forms.formPuzzleMessage.labelPuzzleMessage.Text =
                         "За съжаление дадохте грешен отговор и не спечелихте никакви жълтици.";

            }
            Forms.formPuzzleMessage.ShowDialog();
        }

        private void FormPuzzle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormPuzzle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            Forms.formGameMessage.ShowDialog();
        }

        private void FormPuzzle_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Apply font
                labelA.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
                labelB.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
                labelC.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
                labelD.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
                labelQ10.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
                labelQ11.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
                labelQ12.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);

                numberPuzzle = randomNumber.Next(1, 13);

                // Set default controls
                pictureQ.Visible = true;
                labelQ10.Visible = false;
                labelQ11.Visible = false;
                labelQ12.Visible = false;
                pictureD.Location = new Point(554, 487);
                labelA.Visible = true;
                labelB.Visible = true;
                labelC.Visible = true;
                labelD.Visible = true;

                // Show random puzzle
                switch (numberPuzzle)
                {
                    case 1:
                        {
                            pictureQ.Image = Properties.Resources.puzzle1Q;
                            pictureA.Image = Properties.Resources.puzzle1A;
                            pictureB.Image = Properties.Resources.puzzle1B;
                            pictureC.Image = Properties.Resources.puzzle1C;
                            pictureD.Image = Properties.Resources.puzzle1D;
                            correctAns = pictureD;
                            break;
                        }
                    case 2:
                        {
                            pictureQ.Image = Properties.Resources.puzzle2Q;
                            pictureA.Image = Properties.Resources.puzzle2A;
                            pictureB.Image = Properties.Resources.puzzle2B;
                            pictureC.Image = Properties.Resources.puzzle2C;
                            pictureD.Image = Properties.Resources.puzzle2D;
                            correctAns = pictureD;
                            break;
                        }

                    case 3:
                        {
                            pictureQ.Image = Properties.Resources.puzzle3Q;
                            pictureA.Image = Properties.Resources.puzzle3A;
                            pictureB.Image = Properties.Resources.puzzle3B;
                            pictureC.Image = Properties.Resources.puzzle3C;
                            pictureD.Image = Properties.Resources.puzzle3D;
                            correctAns = pictureA;
                            break;
                        }

                    case 4:
                        {
                            pictureQ.Image = Properties.Resources.puzzle4Q;
                            pictureA.Image = Properties.Resources.puzzle4A;
                            pictureB.Image = Properties.Resources.puzzle4B;
                            pictureC.Image = Properties.Resources.puzzle4C;
                            pictureD.Image = Properties.Resources.puzzle4D;
                            correctAns = pictureB;
                            break;
                        }

                    case 5:
                        {
                            pictureQ.Image = Properties.Resources.puzzle5Q;
                            pictureA.Image = Properties.Resources.puzzle5A;
                            pictureB.Image = Properties.Resources.puzzle5B;
                            pictureC.Image = Properties.Resources.puzzle5C;
                            pictureD.Image = Properties.Resources.puzzle5D;
                            correctAns = pictureD;
                            break;
                        }

                    case 6:
                        {
                            pictureQ.Image = Properties.Resources.puzzle6Q;
                            pictureA.Image = Properties.Resources.puzzle6A;
                            pictureB.Image = Properties.Resources.puzzle6B;
                            pictureC.Image = Properties.Resources.puzzle6C;
                            pictureD.Image = Properties.Resources.puzzle6D;
                            correctAns = pictureD;
                            break;
                        }

                    case 7:
                        {
                            pictureQ.Image = Properties.Resources.puzzle7Q;
                            pictureA.Image = Properties.Resources.puzzle7A;
                            pictureB.Image = Properties.Resources.puzzle7B;
                            pictureC.Image = Properties.Resources.puzzle7C;
                            pictureD.Image = Properties.Resources.puzzle7D;
                            correctAns = pictureB;
                            break;
                        }

                    case 8:
                        {
                            pictureQ.Image = Properties.Resources.puzzle8Q;
                            pictureA.Image = Properties.Resources.puzzle8A;
                            pictureB.Image = Properties.Resources.puzzle8B;
                            pictureC.Image = Properties.Resources.puzzle8C;
                            pictureD.Image = Properties.Resources.puzzle8D;
                            correctAns = pictureA;
                            break;
                        }

                    case 9:
                        {
                            pictureQ.Image = Properties.Resources.puzzle9Q;
                            pictureA.Image = Properties.Resources.puzzle9A;
                            pictureB.Image = Properties.Resources.puzzle9B;
                            pictureC.Image = Properties.Resources.puzzle9C;
                            pictureD.Image = Properties.Resources.puzzle9D;
                            correctAns = pictureA;
                            break;
                        }

                    case 10:
                        {
                            Forms.formGameMessage.labelGameMessage.Text =
    @"Предстои логическа загадка. Отговорете правилно и ще спечелите 50 жълтици.";
                            pictureQ.Visible = false;
                            labelQ10.Visible = true;
                            pictureA.Image = Properties.Resources.wife;
                            pictureB.Image = Properties.Resources.cook;
                            pictureC.Image = Properties.Resources.gardener;
                            pictureD.Image = Properties.Resources.maid;
                            labelA.Text = "Съпругата";
                            labelB.Text = "Готвачът";
                            labelC.Text = "Градинарят";
                            labelD.Text = "Прислужницата";
                            labelA.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
                            labelB.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
                            labelC.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
                            labelD.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
                            correctAns = pictureD;
                            break;
                        }

                    case 11:
                        {
                            Forms.formGameMessage.labelGameMessage.Text =
    @"Предстои логическа загадка. Отговорете правилно и ще спечелите 50 жълтици.";
                            pictureQ.Visible = false;
                            labelQ11.Visible = true;
                            pictureA.Image = Properties.Resources.fire;
                            pictureB.Image = Properties.Resources.killer;
                            pictureC.Image = Properties.Resources.lion;
                            pictureD.Image = Properties.Resources.shark;
                            labelA.Text = "Пожари";
                            labelB.Text = "Убийци";
                            labelC.Text = "Лъвове";
                            labelD.Text = "Акули";
                            labelA.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Regular);
                            labelB.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Regular);
                            labelC.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Regular);
                            labelD.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Regular);
                            correctAns = pictureC;
                            break;
                        }

                    case 12:
                        {
                            Forms.formGameMessage.labelGameMessage.Text =
    @"Предстои логическа загадка. Отговорете правилно и ще спечелите 50 жълтици.";
                            pictureQ.Visible = false;
                            labelQ12.Visible = true;
                            pictureA.Image = Properties.Resources.candle;
                            pictureB.Image = Properties.Resources.lamp;
                            pictureC.Image = Properties.Resources.fireplace;
                            pictureD.Image = Properties.Resources.matchP;
                            labelA.Visible = false;
                            labelB.Visible = false;
                            labelC.Visible = false;
                            labelD.Visible = false;
                            pictureD.Location = new Point(638, 206);
                            //labelA.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Regular);
                            //labelB.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Regular);
                            //labelC.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Regular);
                            //labelD.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Regular);
                            correctAns = pictureD;
                            break;
                        }                }
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
