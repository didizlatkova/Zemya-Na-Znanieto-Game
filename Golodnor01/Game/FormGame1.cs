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
    public partial class FormGame1 : Form
    {
        public FormGame1()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        List<Control> listMatch = new List<Control>();
        List<Control> listBlank = new List<Control>();
        bool isOver = false;
        Control selectedMatch = null;
        int numberMoves = 0;

        // Make matches and blanks unclickable
        private void deActivate()
        {
            Forms.formRiddleMessage.ShowDialog();

            foreach (var matchy in listMatch)
            {
                matchy.BackColor = Color.Transparent;
                if (matchy.Name.StartsWith("pictureMatchV"))
                {
                    matchy.BackgroundImage = Properties.Resources.match;
                }
                else
                {
                    matchy.BackgroundImage = Properties.Resources.matchAcross;
                }

                matchy.Cursor = Cursors.Arrow;
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
            numberMoves = 0;

            listBlank.Clear();
            listMatch.Clear();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureMatch"))
                {
                    if (this.Controls[i].Name == "pictureMatchH9" || this.Controls[i].Name == "pictureMatchV8")
                    {
                        listBlank.Add(this.Controls[i]);
                    }
                    else
                    {
                        listMatch.Add(this.Controls[i]);
                    }
                }
            }

            foreach (var matchy in listMatch)
            {
                matchy.BackColor = Color.Transparent;
                if (matchy.Name.StartsWith("pictureMatchV"))
                {
                    matchy.BackgroundImage = Properties.Resources.match;
                }
                else
                {
                    matchy.BackgroundImage = Properties.Resources.matchAcross;
                }

                matchy.Cursor = Cursors.Hand;
            }

            foreach (var blank in listBlank)
            {
                blank.BackColor = Color.Transparent;
                blank.BackgroundImage = null;
                blank.Cursor = Cursors.Arrow;
            }

            selectedMatch = null;
        }

        // Handle any clicked object
        private void ClickMatch(Control match)
        {
            if (!isOver && numberMoves<2)
            {
                // Check if object is a match
                if (listMatch.Contains(match) && (selectedMatch == null || selectedMatch == match))
                {
                    // Check if match is already selected
                    if (match.BackColor == Color.Maroon)
                    {
                        // Deselect match
                        match.BackColor = Color.Transparent;
                        selectedMatch = null;
                        foreach (var blank in listBlank)
                        {
                            blank.Cursor = Cursors.Arrow;
                        }
                        foreach (var matchy in listMatch)
                        {
                            matchy.Cursor = Cursors.Hand;

                        }
                    }
                    else
                    {
                        // Select the match
                        match.BackColor = Color.Maroon;
                        selectedMatch = match;
                        foreach (var blank in listBlank)
                        {
                            blank.Cursor = Cursors.Hand;
                        }
                        foreach (var matchy in listMatch)
                        {
                            if (matchy != match)
                            {
                                matchy.Cursor = Cursors.Arrow;
                            }
                        }
                    }
                }
                // Check if selected object is a blank
                else if (listBlank.Contains(match))
                {
                    // Check if a match is selected
                    if (selectedMatch != null)
                    {
                        // Turn blank to match and match to blank
                        listMatch.Remove(selectedMatch);
                        listBlank.Add(selectedMatch);

                        numberMoves++;

                        match.BackColor = Color.Transparent;
                        listBlank.Remove(match);
                        listMatch.Add(match);
                        if (match.Name.StartsWith("pictureMatchV"))
                        {
                            match.BackgroundImage = Properties.Resources.match;
                        }
                        else
                        {
                            match.BackgroundImage = Properties.Resources.matchAcross;
                        }

                        foreach (var blank in listBlank)
                        {
                            blank.BackgroundImage = null;
                            blank.BackColor = Color.Transparent;
                            blank.Cursor = Cursors.Arrow;
                        }

                        foreach (var matchy in listMatch)
                        {
                            matchy.Cursor = Cursors.Hand;
                        }
                        selectedMatch = null;


                        if (numberMoves == 2)
                        {
                            if (listBlank.Contains(pictureMatchH4) && listBlank.Contains(pictureMatchH6))
                            {
                                Forms.formRiddleMessage.labelRiddleMessage.Text = 
                                    "Браво! Подредихте клечките правилно и печелите 100 жълтици!";
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

        private void FormGame1_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Set font
            labelSkip.Text = "пропусни играта";
            labelSkip.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            
            Forms.formGameMessage.labelGameMessage.Text = @"Петнадесет кибритени клечки са подредени така, че да образуват пет 
еднакви квадрата. Целта на играта е да преместите само две кибритени клечки така, че да се получат четири еднакви квадрата.";            
            Restart();
        }

        // Any match clicked
        private void pictureMatchV1_Click(object sender, EventArgs e)
        {
            ClickMatch((PictureBox)sender);
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                Restart();
                labelRestart.Visible = false;
            }
        }

        // Skip game
        private void labelSkip_Click(object sender, EventArgs e)
        {
            if (!isOver)
            {
                Forms.formRiddleMessage.labelRiddleMessage.Text =
                                  "За съжаление не успяхте да спечелите никакви жълтици.";

                // Show correct answer
                listBlank.Clear();
                listMatch.Clear();

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureMatch"))
                    {
                        if (this.Controls[i].Name == "pictureMatchH4" || this.Controls[i].Name == "pictureMatchH6")
                        {
                            listBlank.Add(this.Controls[i]);
                        }
                        else
                        {
                            listMatch.Add(this.Controls[i]);
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

        private void FormGame1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormGame1_FormClosing(object sender, FormClosingEventArgs e)
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
