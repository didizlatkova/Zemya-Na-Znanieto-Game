using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Golodnor01
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        DataSet ds = new DataSet();
        DataSetTableAdapters.UserTableTableAdapter userTa;
        bool isNameSame = false;

        public void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if form is closed
            if (!GlobalVars.isClosed)
            {
                if (!methods.Exit())
                {
                    // Prevent form from closing
                    e.Cancel = true;
                }
                else
                {
                    GlobalVars.isClosed = true;
                }
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Start the game
        private void labelStart_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.currentPlayer == 0)
            {
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Първо трябва да изберете играч!";
                Forms.formPlayerMessage.ShowDialog();
            }
            else
            {
                if (!GlobalVars.isGameStarted)
                {
                    Forms.formInstr1.Show();
                }
                else
                {
                    Forms.formMap.Show();
                }
                this.Hide();
            }
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                listBoxPlayers.Visible = false;
                textBoxPlayer.Visible = false;
                buttonOk.Visible = false;

                // Try to fill SQL table, if failed - show error message
                try
                {
                    userTa = new DataSetTableAdapters.UserTableTableAdapter();
                    userTa.Fill(ds.UserTable);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Стартирането на играта не беше направено до 30 секунди, което предизвика SQL Timeout Expired грешка! Моля, опитайте да стартирате отново! Ако виждате това съобщение за втори път, проверете настройките на SQL!",
                        "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GlobalVars.isClosed = true;
                    Application.Exit();
                }

                // Check if UserTable has players
                if (ds.UserTable.Rows.Count == 1)
                {
                    Properties.Settings.Default.currentPlayer = 0;
                    Properties.Settings.Default.Save();
                }

                // Check if there is a current player
                if (Properties.Settings.Default.currentPlayer != 0)
                {
                    labelPlayer.Text = ds.UserTable.Rows[Properties.Settings.Default.currentPlayer][0].ToString();
                }
                else
                {
                    labelPlayer.Text = "Играч";
                }

                // Check if first time loading the form
                if (!GlobalVars.isNotMainFirstLoad)
                {
                    // Set music urls
                    Forms.formMusic.axIntro.URL = "Music/Intro.MP3";
                    Forms.formMusic.axLevel1.URL = "Music/Level1.MP3";
                    Forms.formMusic.axLevel2.URL = "Music/Level2.MP3";
                    Forms.formMusic.axLevel3.URL = "Music/Level3.MP3";
                    Forms.formMusic.axLevel4.URL = "Music/Level4.MP3";

                    // Make global vars default
                    GlobalVars.isNotMainFirstLoad = true;
                    GlobalVars.numberGame = 0;
                    GlobalVars.numberQuestion = 0;
                    GlobalVars.numberLevel = 1;
                    GlobalVars.isQuestion = true;
                    GlobalVars.numberHearts = 3;
                    GlobalVars.coins = 0;

                    // Play intro music                    
                    if (Forms.formMusic.trackBarMusic.Value != 0)
                    {
                        Forms.formMusic.axIntro.Ctlcontrols.play();
                    }
                    (Forms.formMusic.axIntro.settings as WMPLib.IWMPSettings).setMode("loop", true);
                    Forms.formMusic.axIntro.settings.volume = Forms.formMusic.trackBarMusic.Value;
                    GlobalVars.isIntroPlaying = true;
                }

                if (Properties.Settings.Default.currentPlayer != 0)
                {
                    labelPlayer.Text = ds.UserTable.Rows[Properties.Settings.Default.currentPlayer][0].ToString();
                }

                listBoxPlayers.Items.Clear();
                for (int i = 0; i < ds.UserTable.Rows.Count; i++)
                {
                    listBoxPlayers.Items.Add(ds.UserTable.Rows[i][0].ToString());
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Apply font
            labelStart.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelPlayer.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelMe.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelExit.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelChart.Font = new Font(methods.myFont.Families[0], 22, FontStyle.Bold);
            labelAdmin.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            buttonOk.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            listBoxPlayers.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Regular);
            textBoxPlayer.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Regular);

            this.AcceptButton = buttonOk;
        }

        // Add a new player
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text.Trim() != "")
            {
                userTa = new DataSetTableAdapters.UserTableTableAdapter();
                userTa.Fill(ds.UserTable);

                for (int i = 1; i < ds.UserTable.Rows.Count; i++)
                {
                    if (ds.UserTable.Rows[i][0].ToString() == textBoxPlayer.Text)
                    {
                        isNameSame = true;
                        break;
                    }
                    else
                    {
                        isNameSame = false;
                    }
                }

                // Check if name exists
                if (!isNameSame)
                {
                    DataRow newRow = ds.UserTable.NewRow();
                    newRow[0] = textBoxPlayer.Text;
                    newRow[1] = 0;
                    ds.UserTable.Rows.Add(newRow);

                    userTa.Update(ds.UserTable);
                    ds.AcceptChanges();

                    listBoxPlayers.Items.Insert(listBoxPlayers.Items.Count, textBoxPlayer.Text);
                    listBoxPlayers.Refresh();
                    textBoxPlayer.Clear();
                    textBoxPlayer.Visible = false;
                    buttonOk.Visible = false;
                }
                else
                {
                    textBoxPlayer.Clear();
                    Forms.formPlayerMessage.labelPlayerMessage.Text = "Вече има играч със същото име!";
                    Forms.formPlayerMessage.ShowDialog();
                }
            }
        }

        // Show list of players
        private void labelPlayer_Click(object sender, EventArgs e)
        {
            if (GlobalVars.isGameStarted)
            {
                Forms.formChangePlayerMessage.ShowDialog();
            }
            else
            {
                if (listBoxPlayers.Visible == false)
                {
                    listBoxPlayers.Visible = true;
                }
                else
                {
                    listBoxPlayers.Visible = false;
                    textBoxPlayer.Visible = false;
                    buttonOk.Visible = false;
                }
            }
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTa = new DataSetTableAdapters.UserTableTableAdapter();
            userTa.Fill(ds.UserTable);
            if (listBoxPlayers.SelectedIndex != -1)
            {
                textBoxPlayer.Clear();
                textBoxPlayer.Visible = false;
                buttonOk.Visible = false;

                if (listBoxPlayers.SelectedIndex != 0)
                {
                    Properties.Settings.Default.currentPlayer = listBoxPlayers.SelectedIndex;
                    Properties.Settings.Default.Save();
                    labelPlayer.Text = ds.UserTable.Rows[Properties.Settings.Default.currentPlayer][0].ToString();
                    listBoxPlayers.Visible = false;
                }
                else
                {
                    // Check if players are under 11
                    if (ds.UserTable.Rows.Count < 11)
                    {
                        textBoxPlayer.Visible = true;
                        buttonOk.Visible = true;
                        textBoxPlayer.Focus();
                    }
                    else
                    {
                        Forms.formPlayerMessage.labelPlayerMessage.Text = "Играчите могат да бъдат максимум 10!";
                        Forms.formPlayerMessage.ShowDialog();
                    }
                }
            }
        }


        private void labelChart_Click(object sender, EventArgs e)
        {
            Forms.formChart.Show();
            this.Hide();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            if (Forms.formAdminLog.ShowDialog() == DialogResult.Yes)
            {
                Forms.formAdmin.Show();
                this.Hide();
            }

            Forms.formAdminLog.textBoxPsw.Clear();
            Forms.formAdminLog.textBoxPsw.Focus();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
        
        private void labelMe_Click(object sender, EventArgs e)
        {
            Forms.formMe.Show();
            this.Hide();
        }
    }
}
