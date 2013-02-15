using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace Golodnor01
{
    public partial class FormGame6 : Form
    {
        public FormGame6()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        bool isChosen = false;
        bool isOver = false;
        int chosenLiters;
        Label chosenLabel;
        PictureBox chosenPicture;
        int chosenJug;
        int addedLiters;
        Dictionary<string, object> dictImages = new Dictionary<string, object>();

        // Do after game is over
        private void deActivate()
        {
            Forms.formRiddleMessage.ShowDialog();
            pictureJug3.Cursor = Cursors.Arrow;
            pictureJug5.Cursor = Cursors.Arrow;
            pictureJug8.Cursor = Cursors.Arrow;
            pictureQuestion.Cursor = Cursors.Arrow;
            labelRestart.Cursor = Cursors.Arrow;
            labelSkip.Text="НАПРЕД";
            isOver = true;            
        }

        // Check if game is over
        private void CheckIfOver()
        {
            if (labelJug5.Text == "4" && labelJug8.Text == "4")
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                                   "Браво! Успяхте да разделите течността и печелите 100 жълтици!";
                GlobalVars.coins += 100;       
                deActivate();
            }
        }

        // Handle clicked jug
        private void JugClicked(Label labelJug, PictureBox pictureJug, int numberJug)
        {
            if (!isOver)
            {
                if (!isChosen)
                {
                    // Select jug
                    if (int.Parse(labelJug.Text) != 0)
                    {
                        pictureJug.BackColor = Color.RosyBrown;
                        chosenLiters = int.Parse(labelJug.Text);
                        chosenLabel = labelJug;
                        chosenPicture = pictureJug;
                        chosenJug = numberJug;
                        isChosen = true;
                    }
                }
                else if (chosenPicture == pictureJug)
                {
                    // Deselect jug
                    pictureJug.BackColor = Color.Transparent;
                    chosenPicture = null;
                    isChosen = false;
                }
                else
                {
                    // Pour from one jug to another
                    if (int.Parse(labelJug.Text) != numberJug)
                    {
                        if (chosenLiters > (numberJug - int.Parse(labelJug.Text)))
                        {
                            addedLiters = (numberJug - int.Parse(labelJug.Text));
                        }
                        else
                        {
                            addedLiters = chosenLiters;
                        }
                        labelJug.Text = (int.Parse(labelJug.Text) + addedLiters).ToString();

                        foreach (var pair in dictImages)
                        {
                            // Find image of jug in dictionary by jug and number liters
                            if (pair.Key.EndsWith((int.Parse(labelJug.Text).ToString() + "_liters"))
                                && pair.Key.StartsWith("jug" + numberJug.ToString()))
                            {
                                pictureJug.Image = (Image)pair.Value;
                            }
                        }
                        chosenLabel.Text = (chosenLiters - addedLiters).ToString();
                        chosenPicture.BackColor = Color.Transparent;

                        foreach (var pair in dictImages)
                        {
                            // Find image of jug in dictionary by jug and number liters
                            if (pair.Key.EndsWith((chosenLiters - addedLiters).ToString() + "_liters")
                                && pair.Key.StartsWith("jug" + chosenJug.ToString()))
                            {
                                chosenPicture.Image = (Image)pair.Value;
                            }
                        }
                        isChosen = false;
                        CheckIfOver();
                    }
                }
            }
        }

        private void FormGame6_Load(object sender, EventArgs e)
        {
            // Apply font
            labelJug3.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelLiters3.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelJug5.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelLiters5.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelJug8.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelLiters8.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            Forms.formGameMessage.labelGameMessage.Text = @"Съдът с обем 8л е пълен догоре с някаква течност. 
Другите два съда са с обеми 5л и 3л и са празни. Целта на играта е да разпределите течността така, че в двата по-големи съда да има по 4л.";            

            foreach (PropertyInfo property in typeof(Properties.Resources).GetProperties
    (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (property.Name.StartsWith("jug"))
                {
                    // Add all images of jugs from Properties to a dictionary
                    dictImages.Add(property.Name, property.GetValue(null, null));
                }
            }
        }

        private void pictureJug8_Click(object sender, EventArgs e)
        {
            JugClicked(labelJug8, pictureJug8, 8);
        }

        private void pictureJug5_Click(object sender, EventArgs e)
        {
            JugClicked(labelJug5, pictureJug5, 5);
        }

        private void pictureJug3_Click(object sender, EventArgs e)
        {
            JugClicked(labelJug3, pictureJug3, 3);
        }

        // Restart game
        private void labelRestart_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                pictureJug8.Image = Properties.Resources.jug8_8_liters;
                pictureJug5.Image = Properties.Resources.jug5_0_liters;
                pictureJug3.Image = Properties.Resources.jug3_0_liters;
                pictureJug8.BackColor = Color.Transparent;
                pictureJug5.BackColor = Color.Transparent;
                pictureJug3.BackColor = Color.Transparent;
                labelJug8.Text = "8";
                labelJug5.Text = "0";
                labelJug3.Text = "0";
                isChosen = false;
            }
        }

        private void FormGame6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormGame6_FormClosing(object sender, FormClosingEventArgs e)
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
