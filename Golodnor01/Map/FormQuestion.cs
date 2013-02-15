using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace Golodnor01
{
    public partial class FormQuestion : Form
    {
        public FormQuestion()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();        
        Label labelans;
        int count = 0;
        Random randomNumber = new Random();
        int questionIndex;
        bool hasUsedHint = false;
        bool isAnswered = false;
        string question;
        string ansA;
        string ansB;
        string ansC;
        string ansD;
        string ansCorrect;
        bool isInfoPassed = false;
        List<int> questionsPassed = new List<int>();
        List<Control> listLabelAnswers = new List<Control>();
        List<Control> listHints = new List<Control>();
        Dictionary<string, object> dictImages = new Dictionary<string, object>();          

        // Gain 10 coins
        private void GainTenCoins()
        {
            labelGain10Coins.Visible=true;
            GlobalVars.coins += 10;
        }

        // Control visibility of hearts
        private void ControlHearts()
        {
            if (!GlobalVars.isBonusQuestion)
            {
                switch (GlobalVars.numberHearts)
                {
                    case 0:
                        {
                            pictureHeart1.Visible = false;
                            pictureHeart2.Visible = false;
                            pictureHeart3.Visible = false;
                            break;
                        }

                    case 1:
                        {
                            pictureHeart1.Visible = true;
                            pictureHeart2.Visible = false;
                            pictureHeart3.Visible = false;
                            GlobalVars.isHintHeartBought = false;
                            break;
                        }
                    case 2:
                        {
                            pictureHeart1.Visible = true;
                            pictureHeart2.Visible = true;
                            pictureHeart3.Visible = false;
                            GlobalVars.isHintHeartBought = false;
                            break;
                        }
                    case 3:
                        {
                            pictureHeart1.Visible = true;
                            pictureHeart2.Visible = true;
                            pictureHeart3.Visible = true; ;
                            break;
                        }
                }
            }
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;
            
            // Apply font
            labelNumberQuestion.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            labelGain10Coins.Font = new Font(methods.myFont.Families[0], 20, FontStyle.Bold);
            labelBonus.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelCoins.Font = new Font(methods.myFont.Families[0], 30, FontStyle.Bold);
            labelQuestion.Font = new Font(methods.myFont.Families[0], 20, FontStyle.Bold);
            labelAnswerA.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelAnswerB.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelAnswerC.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);
            labelAnswerD.Font = new Font(methods.myFont.Families[0], 18, FontStyle.Bold);

            // Put labels with answers in a list
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Label && this.Controls[i].Name.StartsWith("labelAnswer"))
                {
                    listLabelAnswers.Add(this.Controls[i]);
                }
            }

            // Put pictures with hints in a list
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox && this.Controls[i].Name.StartsWith("pictureHint"))
                {
                    listHints.Add(this.Controls[i]);
                }
            }

            // Make a dictionary of info images
            foreach (PropertyInfo property in typeof(Properties.Resources).GetProperties
    (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (property.Name.StartsWith("info"))
                {
                    dictImages.Add(property.Name, property.GetValue(null, null));
                }
            }
        }

        // Check if question is already passed
        private bool IsPassed(int index)
        {
            bool ispassed = false;
            foreach (var question in questionsPassed)
            {
                if (question == index)
                {
                    ispassed = true;
                    break;
                }
            }
            return ispassed;
        }
        
        // Clear items from previous question
        private void Clear()
        {
            pictureTimer.Image = Properties.Resources.chart_piew0;
            count = 0;
            isAnswered = false;
            timerCountdown.Start();
            labelGain10Coins.Visible = false;
            pictureArrow.Visible = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is PictureBox
                    && this.Controls[i].Name.StartsWith("pictureRed") ||
                    this.Controls[i].Name.StartsWith("pictureGreen"))
                {
                    this.Controls[i].Visible = false;
                }
            }

            // Make all labels with answers visible
            foreach (var labelAns in listLabelAnswers)
            {
                labelAns.Visible = true;
            }
        }

        // Define DataSet
        DataSet ds = new DataSet();
        DataSetTableAdapters.QuestionsTableTableAdapter ta;

        // Make selected answer orange
        public void Answered(Label labelAns)
        {
            if (!isAnswered)
            {
                isAnswered = true;
                if (labelAns == labelAnswerA)
                {
                    pictureOrangeA.Visible = true;
                }
                else if (labelAns == labelAnswerB)
                {
                    pictureOrangeB.Visible = true;
                }
                else if (labelAns == labelAnswerC)
                {
                    pictureOrangeC.Visible = true;
                }
                else if (labelAns == labelAnswerD)
                {
                    pictureOrangeD.Visible = true;
                }
                labelans = labelAns;
                timerPause.Start();
                deCursor();
                deCursorHints();
            }
        }

        private void CorrectAnswerRevealed()
        {
            pictureArrow.Visible = true;
            deCursor();

            if (labelAnswerA.Text == ansCorrect)
            {
                pictureGreenA.Visible = true;
            }
            else if (labelAnswerB.Text == ansCorrect)
            {
                pictureGreenB.Visible = true;
            }
            else if (labelAnswerC.Text == ansCorrect)
            {
                pictureGreenC.Visible = true;
            }
            else
            {
                pictureGreenD.Visible = true;
            }            
        }

        // Make selected answer red (incorrect) or green (correct); reveal correct answer
        public void AnswerRevealed(Label labelAns)
        {
            pictureArrow.Visible = true;
            if (labelAns == labelAnswerA)
            {
                pictureOrangeA.Visible = false;

                if (labelAnswerA.Text == ansCorrect)
                {
                    pictureGreenA.Visible = true;
                    GainTenCoins();
                }
                else
                {
                    if (!GlobalVars.isBonusQuestion)
                    {
                        // Lose a heart
                        GlobalVars.numberHearts--;
                        ControlHearts();
                    }
                    pictureRedA.Visible = true;
                    if (labelAnswerB.Text == ansCorrect)
                    {
                        pictureGreenB.Visible = true;
                    }
                    else if (labelAnswerC.Text == ansCorrect)
                    {
                        pictureGreenC.Visible = true;
                    }
                    else
                    {
                        pictureGreenD.Visible = true;
                    }
                }
            }
            else if (labelAns == labelAnswerB)
            {
                pictureOrangeB.Visible = false;

                if (labelAnswerB.Text == ansCorrect)
                {
                    pictureGreenB.Visible = true;
                    GainTenCoins();
                }
                else
                {
                    if (!GlobalVars.isBonusQuestion)
                    {
                        // Lose a heart
                        GlobalVars.numberHearts--;
                        ControlHearts();
                    }
                    pictureRedB.Visible = true;
                    if (labelAnswerA.Text == ansCorrect)
                    {
                        pictureGreenA.Visible = true;
                    }
                    else if (labelAnswerC.Text == ansCorrect)
                    {
                        pictureGreenC.Visible = true;
                    }
                    else
                    {
                        pictureGreenD.Visible = true;
                    }
                }
            }

            else if (labelAns == labelAnswerC)
            {
                pictureOrangeC.Visible = false;

                if (labelAnswerC.Text == ansCorrect)
                {
                    pictureGreenC.Visible = true;
                    GainTenCoins();
                }
                else
                {
                    if (!GlobalVars.isBonusQuestion)
                    {
                        // Lose a heart
                        GlobalVars.numberHearts--;
                        ControlHearts();
                    }
                    pictureRedC.Visible = true;
                    if (labelAnswerB.Text == ansCorrect)
                    {
                        pictureGreenB.Visible = true;
                    }
                    else if (labelAnswerA.Text == ansCorrect)
                    {
                        pictureGreenA.Visible = true;
                    }
                    else
                    {
                        pictureGreenD.Visible = true;
                    }
                }
            }
            else
            {
                pictureOrangeD.Visible = false;

                if (labelAnswerD.Text == ansCorrect)
                {
                    pictureGreenD.Visible = true;
                    GainTenCoins();
                }
                else
                {
                    if (!GlobalVars.isBonusQuestion)
                    {
                        // Lose a heart
                        GlobalVars.numberHearts--;
                        ControlHearts();
                    }
                    pictureRedD.Visible = true;
                    if (labelAnswerB.Text == ansCorrect)
                    {
                        pictureGreenB.Visible = true;
                    }
                    else if (labelAnswerC.Text == ansCorrect)
                    {
                        pictureGreenC.Visible = true;
                    }
                    else
                    {
                        pictureGreenA.Visible = true;
                    }
                }
            }            
        }

        // Make the cursor for answers default
        public void deCursor()
        {
            foreach (var labelAns in listLabelAnswers)
            {
                labelAns.Cursor = Cursors.Arrow;
            }            
        }

        // Make the cursor for hints default
        private void deCursorHints()
        {
            foreach (var hint in listHints)
            {
                hint.Cursor = Cursors.Arrow;
            }
        }

        // Make the cursor hand
        public void Cursoring()
        {
            foreach (var labelAns in listLabelAnswers)
            {
                labelAns.Cursor = Cursors.Hand;
            }

            foreach (var hint in listHints)
            {
                hint.Cursor = Cursors.Hand;
            }
        }
        
        private void FormQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void FormQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void pictureArrow_Click(object sender, EventArgs e)
        {
            if (GlobalVars.numberHearts == 0 || GlobalVars.numberQuestion == 20)
            {
                if (GlobalVars.numberQuestion == 20)
                {
                    GlobalVars.numberQuestion++;
                    Forms.formMap.Show();
                    this.Hide();
                }
                else if (GlobalVars.numberHearts == 0)
                {
                    Forms.formEnd.Show();
                    this.Hide();
                }
            }
            else
            {
                if (GlobalVars.isBonusQuestion)
                {
                    GlobalVars.isBonusQuestion = false;
                }
                else
                {
                    if ((Boolean)ds.QuestionsTable.Rows[questionIndex][11] == true)
                    {
                        GlobalVars.isBonusQuestion = true;
                    }
                    else
                    {
                        GlobalVars.isBonusQuestion = false;
                    }
                }

                if ((Boolean)ds.QuestionsTable.Rows[questionIndex][8] == true)
                {
                    if (!isInfoPassed)
                    {
                        Forms.formInfo.labelInfo1.Text = ds.QuestionsTable.Rows[questionIndex][9].ToString();
                        Forms.formInfo.labelInfo2.Text = ds.QuestionsTable.Rows[questionIndex][10].ToString();

                        foreach (var pair in dictImages)
                        {
                            if (pair.Key == "info" + questionIndex + "_" + 1)
                            {
                                Forms.formInfo.labelImg1.Image = (Image)pair.Value;
                            }
                            else if (pair.Key == "info" + questionIndex + "_" + 2)
                            {
                                Forms.formInfo.labelImg2.Image = (Image)pair.Value;
                            }
                        }

                        Forms.formInfo.ShowDialog();
                    }
                    else
                    {
                        isInfoPassed = false;
                        Forms.formMap.Show();
                        this.Hide();
                    }
                }
                else
                {
                    isInfoPassed = false;
                    Forms.formMap.Show();
                    this.Hide();
                }
            } 
        }

        private void labelAnswerA_Click(object sender, EventArgs e)
        {
            Answered(labelAnswerA);
            timerCountdown.Stop();
        }

        private void labelAnswerB_Click(object sender, EventArgs e)
        {
            Answered(labelAnswerB);
            timerCountdown.Stop();
        }

        private void labelAnswerC_Click(object sender, EventArgs e)
        {
            Answered(labelAnswerC);
            timerCountdown.Stop();
        }

        private void labelAnswerD_Click(object sender, EventArgs e)
        {
            Answered(labelAnswerD);
            timerCountdown.Stop();
        }

        private void timerPause_Tick(object sender, EventArgs e)
        {
            AnswerRevealed(labelans);
            timerPause.Stop();
        }
        
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            count++;
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
                case 6:
                    pictureTimer.Image = Properties.Resources.chart_piew6;
                    CorrectAnswerRevealed();

                    if (!GlobalVars.isBonusQuestion)
                    {
                        // Lose a heart
                        GlobalVars.numberHearts--;
                        ControlHearts();
                    }
                    isAnswered = true;
                    break;
            }
        }

        private void FormQuestion_VisibleChanged(object sender, EventArgs e)
        {           
            if (Forms.formQuestion.Visible)
            {
                if (!GlobalVars.isNotQuestionFirstLoad)
                {
                    GlobalVars.isGameStarted = true;
                    questionsPassed.Clear();
                    GlobalVars.isNotQuestionFirstLoad = true;
                }

                ta = new DataSetTableAdapters.QuestionsTableTableAdapter();
                ta.Fill(ds.QuestionsTable);

                if (GlobalVars.isBonusQuestion)
                {
                    isInfoPassed = true;
                    pictureHint50.Visible = false;
                    pictureHintJump.Visible = false;
                    pictureHintOne.Visible = false;
                    pictureHeart1.Visible = false;
                    pictureHeart2.Visible = false;
                    pictureHeart3.Visible = false;
                    labelNumberQuestion.Visible = false;
                    labelBonus.Visible = true;

                    // Set question and answers
                    question = ds.QuestionsTable.Rows[questionIndex][12].ToString();
                    ansA = ds.QuestionsTable.Rows[questionIndex][13].ToString();
                    ansB = ds.QuestionsTable.Rows[questionIndex][14].ToString();
                    ansC = ds.QuestionsTable.Rows[questionIndex][15].ToString();
                    ansD = ds.QuestionsTable.Rows[questionIndex][16].ToString();
                    ansCorrect = ds.QuestionsTable.Rows[questionIndex][17].ToString();
                }
                else
                {
                    ControlHearts();
                    if (GlobalVars.isHintFiftyBought)
                    {
                        this.pictureHint50.Visible = true;
                    }
                    else
                    {
                        this.pictureHint50.Visible = false;
                    }

                    if (GlobalVars.isHintJumpBought)
                    {
                        this.pictureHintJump.Visible = true;
                    }
                    else
                    {
                        this.pictureHintJump.Visible = false;
                    }

                    if (GlobalVars.isHintOneBought)
                    {
                        this.pictureHintOne.Visible = true;
                    }
                    else
                    {
                        this.pictureHintOne.Visible = false;
                    }

                    labelNumberQuestion.Visible = true;
                    labelBonus.Visible = false;
                    labelNumberQuestion.Text = GlobalVars.numberQuestion.ToString();
                    
                        // Randomize questions until the selected question is according to the level and not passed
                        do
                        {
                            questionIndex = randomNumber.Next(0, ds.QuestionsTable.Rows.Count);
                        }
                        while (IsPassed(questionIndex)
                            || GlobalVars.numberLevel != (int)ds.QuestionsTable.Rows[questionIndex][6]);
                    
                    // Add current question to the list of passed questions
                    questionsPassed.Add(questionIndex);

                    // Set question and answers
                    question = ds.QuestionsTable.Rows[questionIndex][0].ToString();
                    ansA = ds.QuestionsTable.Rows[questionIndex][1].ToString();
                    ansB = ds.QuestionsTable.Rows[questionIndex][2].ToString();
                    ansC = ds.QuestionsTable.Rows[questionIndex][3].ToString();
                    ansD = ds.QuestionsTable.Rows[questionIndex][4].ToString();
                    ansCorrect = ds.QuestionsTable.Rows[questionIndex][5].ToString();
                }

                labelCoins.Text = GlobalVars.coins.ToString();
                hasUsedHint = false;                                             
                Clear();                
                Cursoring();                

                // Put the question and the answers into labels
                labelQuestion.Text = question;
                labelAnswerA.Text = ansA;
                labelAnswerB.Text = ansB;
                labelAnswerC.Text = ansC;
                labelAnswerD.Text = ansD;
            }
        }

        private void pictureJump_Click(object sender, EventArgs e)
        {
            if (!hasUsedHint && !isAnswered)
            {
                GlobalVars.isHintJumpBought = false;
                CorrectAnswerRevealed();
                GainTenCoins();
                timerCountdown.Stop();
                pictureHintJump.Visible = false;
                hasUsedHint = true;
                isAnswered = true;
                deCursorHints();
            }
        }

        private void pictureOne_Click(object sender, EventArgs e)
        {
            if (!hasUsedHint && !isAnswered)
            {
                GlobalVars.isHintOneBought = false;
                string ansCorrect = ds.QuestionsTable.Rows[questionIndex][5].ToString();
                ansCorrect = ansCorrect.Trim();
                int answer;

                //Randomize labels with answers until the selected label is not the correct answer
                do
                {
                    answer = randomNumber.Next(0, 4);
                }
                while (listLabelAnswers[answer].Text == ansCorrect);

                listLabelAnswers[answer].Visible = false;
                pictureHintOne.Visible = false;
                hasUsedHint = true;
                deCursorHints();
            }
        }

        private void picture50_Click(object sender, EventArgs e)
        {
            if (!hasUsedHint && !isAnswered)
            {
                GlobalVars.isHintFiftyBought = false;
                string ansCorrect = ds.QuestionsTable.Rows[questionIndex][5].ToString();
                ansCorrect = ansCorrect.Trim();
                int answer;
                int answer2;

                //Randomize labels with answers until the selected label is not the correct answer
                do
                {
                    answer = randomNumber.Next(0, 4);
                }
                while (listLabelAnswers[answer].Text == ansCorrect);

                // Randomize labels with answers until the selected label is not the correct answer nor the previous
                // selected answer
                do
                {
                    answer2 = randomNumber.Next(0, 4);
                }
                while (listLabelAnswers[answer2].Text == ansCorrect
                    || listLabelAnswers[answer2] == listLabelAnswers[answer]);

                listLabelAnswers[answer].Visible = false;
                listLabelAnswers[answer2].Visible = false;

                pictureHint50.Visible = false;
                hasUsedHint = true;
                deCursorHints();
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
