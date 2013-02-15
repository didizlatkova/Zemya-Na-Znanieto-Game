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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        DataSet ds = new DataSet();
        DataSetTableAdapters.UserTableTableAdapter userTa;
        DataSetTableAdapters.QuestionsTableTableAdapter ta;
        Dictionary<int, int> dictDelQ = new Dictionary<int, int>();
        bool isRowSelected = false;

        // Refresh the panel for adding questions
        private void RefreshAdd()
        {
            this.ActiveControl = textQuestion;
            textQuestion.Clear();
            textAnsA.Clear();
            textAnsB.Clear();
            textAnsC.Clear();
            textAnsD.Clear();
            textCorrAns.Clear();
            textLevel.Clear();
        }
        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Set panel locations
            panelDel.Location = new Point(203, 155);
            panelDelQ.Location = new Point(30, 141);
            panelPsw.Location = new Point(184, 168);
            panelAddQuestion.Location = new Point(30, 141);

            // Set icon
            this.Icon = Forms.formMain.Icon;

            // TODO: This line of code loads data into the 'dataSet.QuestionsTable' table. You can move, or remove it, as needed.
            //this.questionsTableTableAdapter.Fill(this.dataSet.QuestionsTable);

            // Apply font
            labelAdd.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelDel.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelDelQ.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelPsw.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            labelMain.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelA.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelB.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelC.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelCorr.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelD.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelInfo1.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelInfo2.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelExpl.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelLevel.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelNew.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelOld.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelQ.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            listBoxPlayers.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            textBoxNewPsw.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            textBoxOldPsw.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Bold);
            textInfo1.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            textInfo2.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            textSearch.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

            buttonOkDel.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonCancelDel.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOkPsw.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonCancelPsw.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOkAdd.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonCancelAdd.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonOkDelQ.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonCancelDelQ.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
            buttonSearch.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);

        }
        
        private void labelAdd_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void labelAdd_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).Font = new Font(((Control)sender).Font, FontStyle.Bold);
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        // Show main form, close admin form
        private void labelMain_Click(object sender, EventArgs e)
        {
            buttonCancelAdd_Click(sender, e);
            buttonCancelDel_Click(sender, e);
            buttonCancelPsw_Click(sender, e);
            buttonCancelDelQ_Click(sender, e);
            Forms.formMain.Show();
            this.Hide();
        }

        // Show panel for changing password
        private void labelPsw_Click(object sender, EventArgs e)
        {
            HideLabels();
            textBoxOldPsw.Clear();
            textBoxNewPsw.Clear();
            panelPsw.Visible = true;
            this.AcceptButton = buttonOkPsw;
            this.ActiveControl = textBoxOldPsw;
        }

        private void buttonCancelPsw_Click(object sender, EventArgs e)
        {
            panelPsw.Visible = false;
            ShowLabels();
        }

        // Change password
        private void buttonOkPsw_Click(object sender, EventArgs e)
        {
            if (textBoxNewPsw.Text.ToCharArray().Length >= 2)
            {
                if (textBoxOldPsw.Text == Properties.Settings.Default.adminPsw)
                {
                    Properties.Settings.Default.adminPsw = textBoxNewPsw.Text;
                    Properties.Settings.Default.Save();
                    panelPsw.Visible = false;
                    Forms.formPlayerMessage.labelPlayerMessage.Text = "Паролата е променена успешно!";
                    Forms.formPlayerMessage.ShowDialog();
                    ShowLabels();
                }
                else
                {
                    textBoxOldPsw.SelectAll();
                    this.ActiveControl = textBoxOldPsw;
                    Forms.formPlayerMessage.labelPlayerMessage.Text = "Грешна стара парола!";
                    Forms.formPlayerMessage.ShowDialog();
                }
            }
            else
            {
                textBoxNewPsw.SelectAll();
                this.ActiveControl = textBoxNewPsw;
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Новата парола трябва да съдържа поне 2 символа!";
                Forms.formPlayerMessage.ShowDialog();
            }
        }

        // Show panel for deleting players
        private void labelDel_Click(object sender, EventArgs e)
        {
            HideLabels();
            userTa = new DataSetTableAdapters.UserTableTableAdapter();
            userTa.Fill(ds.UserTable);

            listBoxPlayers.Items.Clear();
            for (int i = 1; i < ds.UserTable.Rows.Count; i++)
            {
                listBoxPlayers.Items.Add(ds.UserTable.Rows[i][0].ToString());
            }
            panelDel.Visible = true;
        }

        private void buttonCancelDel_Click(object sender, EventArgs e)
        {
            panelDel.Visible = false;
            ShowLabels();
        }

        // Delete a player
        private void buttonOkDel_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex >= 0)
            {
                Forms.formDelMessage.labelExitMessage.Text = "Сигурни ли сте, че искате да изтриете играчa " + listBoxPlayers.SelectedItem + '?';
                if (Forms.formDelMessage.ShowDialog() == DialogResult.Yes)
                {
                    userTa = new DataSetTableAdapters.UserTableTableAdapter();
                    userTa.Fill(ds.UserTable);

                    ds.UserTable.Rows[listBoxPlayers.SelectedIndex + 1].Delete();
                    userTa.Update(ds.UserTable);
                    ds.AcceptChanges();

                    listBoxPlayers.Items.Clear();
                    for (int i = 1; i < ds.UserTable.Rows.Count; i++)
                    {
                        listBoxPlayers.Items.Add(ds.UserTable.Rows[i][0].ToString());
                    }
                    listBoxPlayers.Refresh();

                    Properties.Settings.Default.currentPlayer = 0;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void HideLabels()
        {
            labelAdd.Visible = false;
            labelDel.Visible = false;
            labelDelQ.Visible = false;
            labelPsw.Visible = false;
        }

        private void ShowLabels()
        {
            labelAdd.Visible = true;
            labelDel.Visible = true;
            labelDelQ.Visible = true;
            labelPsw.Visible = true;
        }

        // Show panel for adding questions
        private void labelAdd_Click(object sender, EventArgs e)
        {
            this.AcceptButton = buttonOkAdd;
            panelAddQuestion.Visible = true;
            RefreshAdd();
            HideLabels();
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            panelAddQuestion.Visible = false;
            ShowLabels();
        }

        // Add a question
        private void buttonOkAdd_Click(object sender, EventArgs e)
        {
            if (textQuestion.Text.ToCharArray().Length > 5)
            {
                if (textAnsA.Text != textAnsB.Text && textAnsA.Text != textAnsC.Text && textAnsA.Text != textAnsD.Text &&
                    textAnsB.Text != textAnsC.Text && textAnsB.Text != textAnsD.Text &&
                    textAnsC.Text != textAnsD.Text)
                {
                    if (textCorrAns.Text == textAnsA.Text || textCorrAns.Text == textAnsB.Text ||
                        textCorrAns.Text == textAnsC.Text || textCorrAns.Text == textAnsD.Text)
                    {
                        if (textLevel.Text == "1" || textLevel.Text == "2" || textLevel.Text == "3" || textLevel.Text == "4")
                        {
                            DataSet ds = new DataSet();
                            DataSetTableAdapters.QuestionsTableTableAdapter ta;
                            ta = new DataSetTableAdapters.QuestionsTableTableAdapter();
                            ta.Fill(ds.QuestionsTable);

                            DataRow newRow = ds.QuestionsTable.NewRow();
                            string question = textQuestion.Text;
                            if (!question.EndsWith("?") && !question.EndsWith(":"))
                            {
                                question = question + '?';
                            }
                            newRow[0] = question;
                            newRow[1] = textAnsA.Text;
                            newRow[2] = textAnsB.Text;
                            newRow[3] = textAnsC.Text;
                            newRow[4] = textAnsD.Text;
                            newRow[5] = textCorrAns.Text;
                            newRow[6] = textLevel.Text;
                            newRow[8] = false;
                            newRow[11] = false;
                            ds.QuestionsTable.Rows.Add(newRow);

                            ta.Update(ds.QuestionsTable);
                            ds.AcceptChanges();
                            RefreshAdd();
                            Forms.formPlayerMessage.labelPlayerMessage.Text = "Въпросът е добавен успешно!";
                            Forms.formPlayerMessage.ShowDialog();

                        }
                        else
                        {
                            textLevel.SelectAll();
                            this.ActiveControl = textLevel;
                            Forms.formPlayerMessage.labelPlayerMessage.Text = "Нивото трябва да е от 1 до 4!";
                            Forms.formPlayerMessage.ShowDialog();
                        }
                    }
                    else
                    {
                        textCorrAns.SelectAll();
                        this.ActiveControl = textCorrAns;
                        Forms.formPlayerMessage.labelPlayerMessage.Text = "Верният отговор трябва да съвпада с някой от възможните!";
                        Forms.formPlayerMessage.ShowDialog();
                    }
                }
                else
                {
                    if (textAnsA.Text == textAnsB.Text)
                    {
                        textAnsB.SelectAll();
                        this.ActiveControl = textAnsB;
                    }
                    else if (textAnsB.Text == textAnsC.Text)
                    {
                        textAnsC.SelectAll();
                        this.ActiveControl = textAnsC;
                    }
                    else if (textAnsA.Text == textAnsC.Text)
                    {
                        textAnsC.SelectAll();
                        this.ActiveControl = textAnsC;
                    }
                    else if (textAnsC.Text == textAnsD.Text)
                    {
                        textAnsD.SelectAll();
                        this.ActiveControl = textAnsD;
                    }
                    else if (textAnsB.Text == textAnsD.Text)
                    {
                        textAnsD.SelectAll();
                        this.ActiveControl = textAnsD;
                    }
                    else if (textAnsA.Text == textAnsD.Text)
                    {
                        textAnsD.SelectAll();
                        this.ActiveControl = textAnsD;
                    }

                    Forms.formPlayerMessage.labelPlayerMessage.Text = "Възможните отговори трябва да са различни!";
                    Forms.formPlayerMessage.ShowDialog();
                }

            }
            else
            {
                textQuestion.SelectAll();
                this.ActiveControl = textQuestion;
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Въпросът трябва да съдържа повече от 5 символа!";
                Forms.formPlayerMessage.ShowDialog();
            }
        }

        // Show panel for deleting questions
        private void labelDelQ_Click(object sender, EventArgs e)
        {
            HideLabels();
            panelDelQ.Visible = true;
            this.AcceptButton = buttonSearch;
            this.ActiveControl = textSearch;
            dataGridView.Height = 25;
        }

        private void buttonCancelDelQ_Click(object sender, EventArgs e)
        {
            panelDelQ.Visible = false;
            RefreshDelQ();
            ShowLabels();
        }

        // Clear search results in panel for deleting questions
        private void RefreshDelQ()
        {
            this.ActiveControl = textSearch;
            textSearch.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Height = 25;
            dictDelQ.Clear();
            isRowSelected = false;
        }

        // Add a search result to the dataGrid by database result index
        private void AddRow(int index)
        {
            ta = new DataSetTableAdapters.QuestionsTableTableAdapter();
            ta.Fill(ds.QuestionsTable);

            // Add dataGrid index and database index to dictionary
            dictDelQ.Add(dataGridView.Rows.Count, index);

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView);
            newRow.Cells[0].Value = ds.QuestionsTable.Rows[index][0];
            newRow.Cells[1].Value = ds.QuestionsTable.Rows[index][1];
            newRow.Cells[2].Value = ds.QuestionsTable.Rows[index][2];
            newRow.Cells[3].Value = ds.QuestionsTable.Rows[index][3];
            newRow.Cells[4].Value = ds.QuestionsTable.Rows[index][4];
            dataGridView.Rows.Add(newRow);
        }

        // Search for questions by key word or phrase
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dictDelQ.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Height = 25;

            ta = new DataSetTableAdapters.QuestionsTableTableAdapter();
            ta.Fill(ds.QuestionsTable);

            int resultsFound = 0;
            string textSearched = textSearch.Text.ToLower();
            if (textSearched.Length > 3)
            {
                for (int i = 0; i < ds.QuestionsTable.Rows.Count; i++)
                {
                    if (resultsFound < 7)
                    {
                        if (ds.QuestionsTable.Rows[i][0].ToString().ToLower().Contains(textSearched) ||
                            ds.QuestionsTable.Rows[i][1].ToString().ToLower().Contains(textSearched) ||
                            ds.QuestionsTable.Rows[i][2].ToString().ToLower().Contains(textSearched) ||
                            ds.QuestionsTable.Rows[i][3].ToString().ToLower().Contains(textSearched) ||
                            ds.QuestionsTable.Rows[i][4].ToString().ToLower().Contains(textSearched))
                        {
                            AddRow(i);
                            resultsFound++;
                        }
                    }
                    else
                    {
                        Forms.formPlayerMessage.labelPlayerMessage.Text = "Ключовата дума не е достатъчно конкретна!";
                        Forms.formPlayerMessage.ShowDialog();
                        textSearch.SelectAll();
                        RefreshDelQ();
                        break;
                    }
                }
                if (resultsFound == 0)
                {
                    Forms.formPlayerMessage.labelPlayerMessage.Text = "Няма намерени резултати!";
                    Forms.formPlayerMessage.ShowDialog();
                    textSearch.SelectAll();
                    this.ActiveControl = textSearch;
                }
                else if (resultsFound < 7)
                {
                    for (int j = 0; j < dataGridView.Rows.Count - 1; j++)
                    {
                        dataGridView.Rows[j].Height = 25;
                    }
                    dataGridView.Height = (dataGridView.Rows.Count + 1) * 25;
                }
            }
            else
            {
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Ключовата дума трябва да съдържа повече от 3 символа!";
                Forms.formPlayerMessage.ShowDialog();
                textSearch.SelectAll();
                this.ActiveControl = textSearch;
            }
        }

        // Delete selected question in dataGrid from database
        private void buttonDelQ_Click(object sender, EventArgs e)
        {
            if (isRowSelected)
            {
                Forms.formDelMessage.labelExitMessage.Text = "Сигурни ли сте, че искате да изтриете този въпрос?";
                if (Forms.formDelMessage.ShowDialog() == DialogResult.Yes)
                {
                    foreach (var pair in dictDelQ)
                    {
                        if (pair.Key == dataGridView.CurrentRow.Index)
                        {
                            ta = new DataSetTableAdapters.QuestionsTableTableAdapter();
                            ta.Fill(ds.QuestionsTable);

                            ds.QuestionsTable.Rows[pair.Value].Delete();
                            ta.Update(ds.QuestionsTable);
                            ds.AcceptChanges();

                            RefreshDelQ();
                            Forms.formPlayerMessage.labelPlayerMessage.Text = "Въпросът е изтрит успешно!";
                            Forms.formPlayerMessage.ShowDialog();
                            break;
                        }
                    }
                }
            }
            else
            {
                Forms.formPlayerMessage.labelPlayerMessage.Text = "Първо изберете въпрос!";
                Forms.formPlayerMessage.ShowDialog();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                isRowSelected = true;
                dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = true;
            }
            this.AcceptButton = buttonOkDelQ;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonSearch;
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
