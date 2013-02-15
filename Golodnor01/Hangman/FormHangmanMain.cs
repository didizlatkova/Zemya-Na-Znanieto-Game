using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Golodnor01
{
    public partial class FormHangmanMain : Form
    {
        public FormHangmanMain()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void ShowHangMan(int cat)
        {
            if (GlobalVars.coins < 10)
            {
                Forms.formHangmanMessage.labelMessage.Text = 
                    "Нямате достатъчно жълтици! Играйте в произволна категория.";
                Forms.formHangmanMessage.ShowDialog();
            }
            else
            {
                GlobalVars.coins -= 10;
                GlobalVars.numberCat = cat;
                Forms.formHangMan.Show();
                this.Hide();
            }
        }

        private void labelGeo_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Underline);
        }

        private void labelGeo_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Regular);
        }

        private void labelRandom_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void labelRandom_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Bold);
        }

        private void labelRandom_Click(object sender, EventArgs e)
        {
            GlobalVars.numberCat = 0;
            Forms.formHangMan.Show();
            this.Hide();
        }

        private void labelGeo_Click(object sender, EventArgs e)
        {
            ShowHangMan(1);

        }

        private void labelHist_Click(object sender, EventArgs e)
        {
            ShowHangMan(2);
        }

        private void labelShow_Click(object sender, EventArgs e)
        {
            ShowHangMan(8);
        }

        private void labelBio_Click(object sender, EventArgs e)
        {
            ShowHangMan(3);
        }

        private void labelLit_Click(object sender, EventArgs e)
        {
            ShowHangMan(5);
        }

        private void labelSport_Click(object sender, EventArgs e)
        {
            ShowHangMan(7);
        }

        private void labelChem_Click(object sender, EventArgs e)
        {
            ShowHangMan(4);
        }

        private void labelMyth_Click(object sender, EventArgs e)
        {
            ShowHangMan(6);
        }

        private void labelOther_Click(object sender, EventArgs e)
        {
            ShowHangMan(9);
        }

        private void FormHangmanMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                labelCoins.Text = GlobalVars.coins.ToString();

                if(!GlobalVars.isNotHangmanFirstLoad)
                {
                    Forms.formHangMan.numberTries = 3;
                    pictureStickman1.Image = Properties.Resources.stickman;
                    pictureStickman2.Image = Properties.Resources.stickman;
                    pictureStickman3.Image = Properties.Resources.stickman;
                }
                switch (Forms.formHangMan.numberTries)
                {
                    case 3:
                        {
                            pictureStickman1.Image = Properties.Resources.stickman;
                            pictureStickman2.Image = Properties.Resources.stickman;
                            pictureStickman3.Image = Properties.Resources.stickman;
                            break;
                        }
                    case 2:
                        {
                            pictureStickman1.Image = Properties.Resources.stickmanDead;
                            break;
                        }
                    case 1:
                        {
                            pictureStickman2.Image = Properties.Resources.stickmanDead;
                            break;
                        }
                }
            }
        }

        private void FormHangmanMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormHangmanMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormHangmanMain_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelChoose.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Bold);
            labelTenCoins.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelGeo.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelGeo.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelBio.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelSport.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelShow.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelOther.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelMyth.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelLit.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelHist.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelChem.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);
            labelRandom.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
        }

        private void labelSkip_Click(object sender, EventArgs e)
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
