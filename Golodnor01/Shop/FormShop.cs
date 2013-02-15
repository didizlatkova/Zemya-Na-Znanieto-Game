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
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        private string messageBought = "Вече притежавате жокер от този вид!";
        private string messageCoins = "Нямате достатъчно жълтици, за да купите този жокер!";

        private void FormShop_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelMap.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);            
        }
        
        private void pictureJ1_MouseEnter(object sender, EventArgs e)
        {
            pictureJump.Visible = true;
        }
        
        private void pictureJ1_MouseLeave(object sender, EventArgs e)
        {
            pictureJump.Visible = false;
        }
        
        private void pictureF1_MouseEnter(object sender, EventArgs e)
        {
            pictureFifty.Visible = true;
        }
        
        private void pictureF1_MouseLeave(object sender, EventArgs e)
        {
            pictureFifty.Visible = false;
        }
        
        private void pictureM1_MouseEnter(object sender, EventArgs e)
        {
            pictureMinusOne.Visible = true;
        }
        
        private void pictureM1_MouseLeave(object sender, EventArgs e)
        {
            pictureMinusOne.Visible = false;
        }
        
        private void pictureH1_MouseEnter(object sender, EventArgs e)
        {
            pictureHeart.Visible = true;
        }
        
        private void pictureH1_MouseLeave(object sender, EventArgs e)
        {
            pictureHeart.Visible = false;
        }

        private void FormShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void labelMap_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void pictureArrowMap_Click(object sender, EventArgs e)
        {
            Forms.formMap.Show();
            this.Hide();
        }

        private void FormShop_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                labelCoins.Text = GlobalVars.coins.ToString();

                if (!GlobalVars.isNotShopFirstLoad)
                {
                    // Apply tooltip to hint pictures
                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is PictureBox
                            && this.Controls[i] != pictureArrowMap && this.Controls[i] != pictureCoins)
                        {
                            ToolTip1.SetToolTip(this.Controls[i], "Купи");
                            this.Controls[i].Visible = true;
                        }
                    }
                    GlobalVars.isNotShopFirstLoad = true;
                }
            }
        }

        // Buy a minus one
        private void pictureM1_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.isHintOneBought)
            {
                if (GlobalVars.coins >= 30)
                {
                    if (methods.isBuying())
                    {
                        methods.Buy((Control)sender, Forms.formQuestion.pictureHintOne, 30);
                        GlobalVars.isHintOneBought = true;
                        
                    }
                }
                else
                {
                    methods.ShowMessage(messageCoins);
                }
            }
            else
            {
                methods.ShowMessage(messageBought);
            }
        }

        // Buy a fifty-fifty
        private void pictureF1_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.isHintFiftyBought)
            {
                if (GlobalVars.coins >= 60)
                {
                    if (methods.isBuying())
                    {
                        methods.Buy((Control)sender, Forms.formQuestion.pictureHint50, 60);
                        GlobalVars.isHintFiftyBought = true;                        
                    }
                }
                else
                {
                    methods.ShowMessage(messageCoins);
                }
            }
            else
            {
                methods.ShowMessage(messageBought);
            }
        }

        // Buy a jump
        private void pictureJ1_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.isHintJumpBought)
            {
                if (GlobalVars.coins >= 120)
                {
                    if (methods.isBuying())
                    {
                        methods.Buy((Control)sender, Forms.formQuestion.pictureHintJump, 120);
                        GlobalVars.isHintJumpBought = true;
                    }
                }
                else
                {
                    methods.ShowMessage(messageCoins);
                }
            }
            else
            {
                methods.ShowMessage(messageBought);
            }
        }

        // Buy a heart
        private void pictureH1_Click(object sender, EventArgs e)
        {
            if (GlobalVars.numberHearts<3)
            {
                if (GlobalVars.coins >= 100)
                {
                    if (methods.isBuying())
                    {
                        GlobalVars.numberHearts++;
                        ((Control)sender).Visible = false;
                        GlobalVars.coins -= 100;
                        labelCoins.Text = GlobalVars.coins.ToString();                                               
                    }
                }
                else
                {
                    methods.ShowMessage(messageCoins);
                }
            }

            else
            {
                methods.ShowMessage(messageBought);
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}

