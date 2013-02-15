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
    public partial class FormEscape : Form
    {
        public FormEscape()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        bool isBinClicked = false;
        bool isToolSelected = false;
        Control selectedTool = null;

        // Put found tool in toolbox
        private void PutInTools(Image img, string name)
        {
            if (pictureTool1.Cursor == Cursors.Hand)
            {
                if (pictureTool2.Cursor == Cursors.Hand)
                {
                    pictureTool3.BackgroundImage = img;
                    pictureTool3.Cursor = Cursors.Hand;
                    pictureTool3.Name = name;
                }
                else
                {
                    pictureTool2.BackgroundImage = img;
                    pictureTool2.Cursor = Cursors.Hand;
                    pictureTool2.Name = name;
                }
            }
            else
            {
                pictureTool1.BackgroundImage = img;
                pictureTool1.Cursor = Cursors.Hand;
                pictureTool1.Name = name;
            }
        }

        // Push bin
        private void pictureBin_Click(object sender, EventArgs e)
        {
            if (!isBinClicked && !isToolSelected)
            {
                pictureBin.Image = Properties.Resources.binDown;
                pictureScrew.Visible = true;
                isBinClicked = true;
            }
        }

        // Take screw
        private void pictureScrew_Click(object sender, EventArgs e)
        {
            pictureScrew.Visible = false;
            PutInTools(Properties.Resources.screwTool, "pictureToolScrew");
        }

        // Take glass
        private void pictureGlass_Click(object sender, EventArgs e)
        {
            if (!isToolSelected)
            {
                pictureGlass.Visible = false;
                pictureDesk.Image = Properties.Resources.desk;
                PutInTools(Properties.Resources.glassEmptyTool, "pictureToolGlassEmpty");
            }
        }

        // Show message from book
        private void pictureBook_Click(object sender, EventArgs e)
        {
            if (!isToolSelected)
            {
                Forms.formEscapePaper.ShowDialog();
            }
        }

        private void ToolClicked(Control tool)
        {
            if (tool.BackgroundImage != null)
            {
                if (isToolSelected)
                {
                    if (selectedTool == tool)
                    {
                        tool.BackColor = Color.Transparent;
                        isToolSelected = false;
                    }
                    else
                    {
                        pictureTool1.BackColor = Color.Transparent;
                        pictureTool2.BackColor = Color.Transparent;
                        pictureTool3.BackColor = Color.Transparent;
                        selectedTool = tool;
                        tool.BackColor = Color.Maroon;
                    }
                }
                else
                {
                    isToolSelected = true;
                    selectedTool = tool;
                    tool.BackColor = Color.Maroon;
                }
            }

        }

        private void pictureTool1_Click(object sender, EventArgs e)
        {
            ToolClicked((Control)sender);
        }

        // Fill glass w/ water
        private void pictureBowl_Click(object sender, EventArgs e)
        {
            if (isToolSelected)
            {
                if (selectedTool.Name.EndsWith("GlassEmpty"))
                {
                    selectedTool.Cursor = Cursors.Arrow;
                    PutInTools(Properties.Resources.glassFullTool, "pictureToolGlassFull");
                    selectedTool.BackColor = Color.Transparent;
                    isToolSelected = false;
                }
            }
        }

        // Open doors w/ screw
        private void pictureDoors_Click(object sender, EventArgs e)
        {
            if (isToolSelected && selectedTool.Name.EndsWith("Screw"))
            {
                pictureDoors.Visible = false;
                pictureFireplace.Image = Properties.Resources.fireplaceNoDoors;
                pictureFire.Visible = true;
                selectedTool.BackColor = Color.Transparent;
                isToolSelected = false;
            }
            else
            {
                labelMessageFireplace.Visible = true;
            }

        }

        // Hide messages
        private void FormEscape_MouseEnter(object sender, EventArgs e)
        {
            labelMessageFireplace.Visible = false;
            labelMessageDoor.Visible = false;
            labelMessageWindow.Visible = false;
        }
        
        // Kill fire
        private void pictureFire_Click(object sender, EventArgs e)
        {
            if (isToolSelected)
            {
                if (selectedTool.Name.EndsWith("GlassFull"))
                {
                    pictureFire.Visible = false;
                    pictureFireplace.Image = Properties.Resources.fireplaceKey;
                    pictureKey.Visible = true;
                    selectedTool.BackColor = Color.Transparent;
                    isToolSelected = false;
                }
            }
        }

        // Take key
        private void pictureKey_Click(object sender, EventArgs e)
        {
            pictureKey.Visible = false;
            PutInTools(Properties.Resources.keyTool, "pictureToolKey");
            pictureFireplace.Image = Properties.Resources.fireplaceNoKey;
        }

        private void pictureDoor_Click(object sender, EventArgs e)
        {
            if (!isToolSelected)
            {
                labelMessageDoor.Visible = true;
            }
        }

        // Unlock door
        private void pictureDoorLock_Click(object sender, EventArgs e)
        {

            if (!isToolSelected)
            {
                labelMessageDoor.Visible = true;
            }
            else
            {
                if (selectedTool.Name.EndsWith("Key"))
                {
                    Forms.formEnd.Show();
                    this.Hide();
                }
            }
        }

        private void FormEscape_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormEscape_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormEscape_Load(object sender, EventArgs e)
        {
            // Apply font
            labelMessageDoor.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
            labelMessageFireplace.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
            labelMessageWindow.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
            labelTools.Font = new Font(methods.myFont.Families[0], 14, FontStyle.Regular);
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }

        private void pictureQuestion_Click(object sender, EventArgs e)
        {
            Forms.formGameMessage.ShowDialog();
        }
                
        private void pictureWindow_Click(object sender, EventArgs e)
        {
            if (!isToolSelected)
            {
                labelMessageWindow.Visible = true;
            }
        }

        // Refresh Escape room
        private void FormEscape_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                if (!GlobalVars.isNotEscapeFirstLoad)
                {
                    GlobalVars.isNotEscapeFirstLoad = true;
                    isBinClicked = false;
                    isToolSelected = false;
                    selectedTool = null;

                    pictureTool1.BackgroundImage = null;
                    pictureTool2.BackgroundImage = null;
                    pictureTool3.BackgroundImage = null;
                    pictureTool1.Cursor = Cursors.Arrow;
                    pictureTool2.Cursor = Cursors.Arrow;
                    pictureTool3.Cursor = Cursors.Arrow;
                    pictureTool1.BackColor = Color.Transparent;
                    pictureTool2.BackColor = Color.Transparent;
                    pictureTool3.BackColor = Color.Transparent;
                    pictureBin.Image = Properties.Resources.bin;
                    pictureScrew.Visible = false;
                    pictureDesk.Image = Properties.Resources.deskandsupplies;
                    pictureFireplace.Image = Properties.Resources.fireplaceEsc;
                    pictureDoors.Visible = true;
                    pictureFire.Visible = false;
                    pictureKey.Visible = false;
                    pictureGlass.Visible = true;
                    pictureDoorLock.Visible = true;
                }
            }
        }

    }
}
