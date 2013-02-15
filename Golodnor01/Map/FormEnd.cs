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
    public partial class FormEnd : Form
    {
        public FormEnd()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        DataSet ds = new DataSet();
        DataSetTableAdapters.UserTableTableAdapter userTa;
        int level = 0;
        int coins = -10;
        int result;
        int count = 1;

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormEnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }
        
        private void FormEnd_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Apply font          
            dataGridView1.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            labelEnd.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelResult.Font = new Font(methods.myFont.Families[0], 26, FontStyle.Regular);
            labelFinalResult.Font = new Font(methods.myFont.Families[0], 32, FontStyle.Bold);
            labelLevel.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Regular);
            labelMultiply.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Regular);
            label100.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Regular);
            labelPlus.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Regular);
            labelCoins.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Regular);
            labelChart.Font = new Font(methods.myFont.Families[0], 28, FontStyle.Bold);
            labelExpl.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Regular);
        }

        // Show labels one by one
        private void timerResult_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    {
                        labelResult.Visible = true;
                        count++;
                        break;
                    }
                case 2:
                    {
                        labelExpl.Visible = true;
                        timerResult.Interval = 500;
                        count++;
                        break;
                    }
                case 3:
                    {
                        if (labelLevel.Text != (GlobalVars.numberQuestion-1).ToString())
                        {
                            level++;
                            labelLevel.Text = level.ToString();
                            labelLevel.Visible = true;
                            if (level == GlobalVars.numberQuestion-1)
                            {
                                timerResult.Interval = 1000;
                                count++;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        labelMultiply.Visible = true;
                        count++;
                        break;
                    }
                case 5:
                    {
                        label100.Visible = true;
                        count++;
                        break;
                    }
                case 6:
                    {
                        labelPlus.Visible = true;
                        timerResult.Interval = 500;
                        count++;
                        break;
                    }
                case 7:
                    {
                        coins += 10;
                        labelCoins.Text = coins.ToString();
                        labelCoins.Visible = true;
                        if (coins == GlobalVars.coins)
                        {
                            timerResult.Interval = 1000;
                            count++;
                        }
                        break;
                    }
                case 8:
                    {
                        pictureLine.Visible = true;
                        count++;
                        break;
                    }
                case 9:
                    {
                        result = level * 100 + coins;
                        labelFinalResult.Text = result.ToString();
                        labelFinalResult.Visible = true;
                        labelExit.Visible = true;
                        labelNewGame.Visible = true;
                        timerResult.Stop();

                        userTa = new DataSetTableAdapters.UserTableTableAdapter();
                        userTa.Fill(ds.UserTable);
                        if (result > (int)ds.UserTable.Rows[Properties.Settings.Default.currentPlayer][1])
                        {
                            ds.UserTable.Rows[Properties.Settings.Default.currentPlayer][1] = result;
                            userTa.Update(ds.UserTable);
                            ds.AcceptChanges();
                        }

                        // TODO: This line of code loads data into the 'dataSet.UserTable' table. You can move, or remove it, as needed.
                        this.userTableTableAdapter.Fill(this.dataSet.UserTable);

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.CurrentCell = null;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Visible = false;
                        dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);

                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            dataGridView1.Rows[i].Height = 35;
                        }
                        dataGridView1.Height = dataGridView1.Rows.Count * 35;
                        dataGridView1.Enabled = false;  
                        labelChart.Visible = true;
                        dataGridView1.Visible = true;                        
                        break;
                    }
            }
        }

        // Start a new game
        private void labelNewGame_Click(object sender, EventArgs e)
        {
            // Stop music
            if (Forms.formMusic.trackBarMusic.Value != 0)
            {
                if (GlobalVars.is1Playing)
                {
                    Forms.formMusic.axLevel1.Ctlcontrols.stop();
                    GlobalVars.is1Playing = false;
                }
                else if (GlobalVars.is2Playing)
                {
                    Forms.formMusic.axLevel2.Ctlcontrols.stop();
                    GlobalVars.is2Playing = false;
                }
                else if (GlobalVars.is3Playing)
                {
                    Forms.formMusic.axLevel3.Ctlcontrols.stop();
                    GlobalVars.is3Playing = false;
                }
                else
                {
                    Forms.formMusic.axLevel4.Ctlcontrols.stop();
                    GlobalVars.is4Playing = false;
                }
            }
            methods.Restart();
            Forms.formMain.Show();
            this.Hide();
        }

        // Show all labels
        private void FormEnd_DoubleClick(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            labelExpl.Visible = true;
            labelLevel.Text = (GlobalVars.numberQuestion - 1).ToString();
            labelLevel.Visible = true;
            labelMultiply.Visible = true;
            labelPlus.Visible = true;
            label100.Visible = true;
            labelCoins.Text = (GlobalVars.coins).ToString();
            labelCoins.Visible = true;
            pictureLine.Visible = true;
            coins = GlobalVars.coins;
            level = GlobalVars.numberQuestion - 1;
            count = 9;
        }

        private void FormEnd_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                // Reset form controls
                labelChart.Visible = false;
                labelFinalResult.Visible = false;
                labelResult.Visible = false;
                labelExpl.Visible = false;
                labelLevel.Visible = false;
                labelMultiply.Visible = false;
                labelPlus.Visible = false;
                label100.Visible = false;
                labelCoins.Visible = false;
                pictureLine.Visible = false;
                labelNewGame.Visible = false;
                labelExit.Visible = false;
                dataGridView1.Visible = false;

                count = 1;
                level = 0;
                coins = -10;
                timerResult.Start();                
            }
        }   
    }
}
