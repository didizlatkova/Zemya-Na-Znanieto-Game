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
    public partial class FormHangMan : Form
    {
        public FormHangMan()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();
        List<Control> listOfLetters = new List<Control>();
        List<Control> listOfBlanks = new List<Control>();
        List<Control> SortedListOfBlanks = new List<Control>();
        List<string[,]> listGeo = new List<string[,]>();
        List<string[,]> listHist = new List<string[,]>();
        List<string[,]> listShow = new List<string[,]>();
        List<string[,]> listBio = new List<string[,]>();
        List<string[,]> listLit = new List<string[,]>();
        List<string[,]> listSport = new List<string[,]>();
        List<string[,]> listChem = new List<string[,]>();
        List<string[,]> listMyth = new List<string[,]>();
        List<string[,]> listOther = new List<string[,]>();
        List<List<string[,]>> listCategories = new List<List<string[,]>>();

        int firstBlank = 0;
        int numberMistakes = 0;
        bool isActive = true;
        string currentWord;
        string currentSubCat;
        char[] currentWordChar;
        int wordIndex;
        int SubIndex;
        int CatIndex;
        Random randomNumber = new Random();
        bool isWordFound = false;
        public int numberTries = 3;
        public bool isOver = false;
        int lettersGuessed = 0;
        bool isLetterFound = false;
        int numberLetters = 0;
        string twoTries = "За съжаление не познахте думата. Имате още два опита!";
        string oneTry = "За съжаление не познахте думата. Имате още един опит!";
        string noTries = "За съжаление не познахте думата. Нямате повече опити!";
        string correct = "Браво! Познахте думата и печелите 20 жълтици!";

        // Remove previous output
        private void Refreshment()
        {
            foreach (var blank in SortedListOfBlanks)
            {
                blank.Visible = false;
                blank.Text = "";
            }

            foreach (var letter in listOfLetters)
            {
                letter.Visible = true;
            }

            numberLetters = 0;
            lettersGuessed = 0;
            pictureHangman.Image = Properties.Resources.hangman0;
            numberMistakes = 0;
        }

        // Show appropriate message when game is finished
        private void ShowMessage(string message)
        {
            Forms.formHangmanMessage.labelMessage.Text = message;
            Forms.formHangmanMessage.ShowDialog();
        }

        // Show correct word
        private void ShowWord()
        {
            for (int i = 0; i < currentWordChar.Length; i++)
            {
                if (SortedListOfBlanks[i + firstBlank].Visible == true)
                {
                    SortedListOfBlanks[i + firstBlank].Text = currentWordChar[i].ToString();
                }
            }
        }

        //
        private void PickWord(List<string[,]> list)
        {
            isWordFound = false;
            do
            {
                wordIndex = randomNumber.Next(0, 120);
                SubIndex = randomNumber.Next(0, 7);

                if (list.Count > SubIndex)
                {
                    if ((list[SubIndex].Length / 2) > wordIndex)
                    {
                        currentWord = list[SubIndex][wordIndex, 1].Trim();
                        currentSubCat = list[SubIndex][wordIndex, 0];
                        currentWordChar = currentWord.ToCharArray();
                        if (currentWordChar.Length <= 20)
                        {
                            isWordFound = true;
                        }
                    }
                }
            }
            while (!isWordFound);
        }

        // Get words from .txt file in Properties and put them in list
        private void GetWords(string path, string name, List<string[,]> list)
        {
            string[] arr = path.Split(new char[] { '\n' });
            string[,] matrix = new string[arr.Length, 2];
            for (int i = 0; i < arr.Length; i++)
            {
                matrix[i, 0] = name;
                matrix[i, 1] = arr[i];
            }
            list.Add(matrix);
        }

        private void FormHangMan_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Add labels of blanks and letters to lists
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Label && this.Controls[i].Name.StartsWith("labelBlank"))
                {
                    listOfBlanks.Add(this.Controls[i]);
                }
                else if (this.Controls[i] is Button && this.Controls[i].Name.StartsWith("buttonLetter"))
                {
                    listOfLetters.Add(this.Controls[i]);
                }
            }

            // Sort the list of blanks
            var sortedBlanks =
                listOfBlanks.OrderBy(label => label.Name);
            foreach (var control in sortedBlanks)
            {
                SortedListOfBlanks.Add(control);
            }

            // Apply font
            labelSubCat.Font = new Font(methods.myFont.Families[0], 24, FontStyle.Underline);

            // OTHER

            GetWords(Properties.Resources.currency, "Валута", listOther);
            GetWords(Properties.Resources.dances, "Танци", listOther);
            GetWords(Properties.Resources.vegies, "Зеленчуци", listOther);
            GetWords(Properties.Resources.fruits, "Плодове", listOther);
            GetWords(Properties.Resources.jobs, "Професии", listOther);

            // MYTH

            GetWords(Properties.Resources.greekGods, "Гръцки богове", listMyth);
            GetWords(Properties.Resources.romeGods, "Римски богове", listMyth);
            GetWords(Properties.Resources.egyptGods, "Египетски богове", listMyth);

            // CHEM

            GetWords(Properties.Resources.chemElements, "Химични елементи", listChem);
            GetWords(Properties.Resources.chemists, "Химици", listChem);

            // SPORT

            GetWords(Properties.Resources.sports, "Спортове", listSport);
            GetWords(Properties.Resources.footballBg, "Български футболисти", listSport);
            GetWords(Properties.Resources.footballTeams, "Футболни отбори", listSport);
            GetWords(Properties.Resources.footballWorld, "Световни футболисти", listSport);

            // LIT

            GetWords(Properties.Resources.poemsBg, "Български стихотворения", listLit);
            GetWords(Properties.Resources.writersBg, "Български писатели и поети", listLit);
            GetWords(Properties.Resources.novelsBg, "Български романи", listLit);
            GetWords(Properties.Resources.storiesBg, "Български разкази", listLit);


            // BIO

            GetWords(Properties.Resources.dogTypes, "Породи кучета", listBio);
            GetWords(Properties.Resources.birds, "Птици", listBio);
            GetWords(Properties.Resources.mammals, "Бозайници", listBio);
            GetWords(Properties.Resources.amphibians, "Земноводни", listBio);
            GetWords(Properties.Resources.reptiles, "Влечуги", listBio);
            GetWords(Properties.Resources.fish, "Риби", listBio);

            // SHOW

            GetWords(Properties.Resources.actorsBg, "Български актьори и актриси", listShow);
            GetWords(Properties.Resources.actorsWorld, "Световни актьори и актриси", listShow);
            GetWords(Properties.Resources.singersBg, "Български изпълнители", listShow);
            GetWords(Properties.Resources.singersWorld, "Световни изпълнители", listShow);
            GetWords(Properties.Resources.musicBands, "Музикални групи", listShow);

            // GEO

            GetWords(Properties.Resources.riversBg, "Реки в България", listGeo);
            GetWords(Properties.Resources.mountBg, "Планини в България", listGeo);
            GetWords(Properties.Resources.sightsWorld, "Световни забележителности", listGeo);
            GetWords(Properties.Resources.townsBg, "Градове в България", listGeo);
            GetWords(Properties.Resources.sightsBg, "Български забележителности", listGeo);

            // HIST

            GetWords(Properties.Resources.historyWorld, "Световни личности", listHist);
            GetWords(Properties.Resources.historyBg, "Български личности", listHist);
            GetWords(Properties.Resources.nobelLaur, "Нобелови лауреати", listHist);
            GetWords(Properties.Resources.presUSA, "Президенти на САЩ", listHist);
        }

        // Check if letter is found
        private void letterClicked(Control button)
        {
            isLetterFound = false;
            button.Visible = false;

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i].ToString() == button.Text)
                {
                    SortedListOfBlanks[i + firstBlank].Text = button.Text;
                    isLetterFound = true;
                    lettersGuessed++;
                    if (lettersGuessed == numberLetters)
                    {
                        GlobalVars.coins += 20;
                        ShowMessage(correct);                        
                    }
                }
            }
            if (!isLetterFound)
            {
                numberMistakes++;
                switch (numberMistakes)
                {
                    case 1:
                        {
                            pictureHangman.Image = Properties.Resources.hangman1;
                            break;
                        }
                    case 2:
                        {
                            pictureHangman.Image = Properties.Resources.hangman2;
                            break;
                        }
                    case 3:
                        {
                            pictureHangman.Image = Properties.Resources.hangman3;
                            break;
                        }
                    case 4:
                        {
                            pictureHangman.Image = Properties.Resources.hangman4;
                            break;
                        }
                    case 5:
                        {
                            pictureHangman.Image = Properties.Resources.hangman5;
                            break;
                        }
                    case 6:
                        {
                            pictureHangman.Image = Properties.Resources.hangman6dead;
                            ShowWord();
                            numberTries--;
                            switch (numberTries)
                            {
                                case 2:
                                    {
                                        pictureStickman1.Image = Properties.Resources.stickmanDead;
                                        ShowMessage(twoTries);
                                        break;
                                    }
                                case 1:
                                    {
                                        pictureStickman2.Image = Properties.Resources.stickmanDead;
                                        ShowMessage(oneTry);
                                        break;
                                    }
                                case 0:
                                    {
                                        pictureStickman3.Image = Properties.Resources.stickmanDead;
                                        isOver = true;
                                        ShowMessage(noTries);
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }

        }

        private void buttonLetterA_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                letterClicked((Control)sender);
            }
        }
        
        private void FormHangMan_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Refreshment();
                if (!GlobalVars.isNotHangmanFirstLoad)
                {
                    pictureStickman1.Image = Properties.Resources.stickman;
                    pictureStickman2.Image = Properties.Resources.stickman;
                    pictureStickman3.Image = Properties.Resources.stickman;
                    numberTries = 3;
                    isOver = false;
                    GlobalVars.isNotHangmanFirstLoad = true;

                }
                // Pick a word
                switch (GlobalVars.numberCat)
                {
                    case 0:
                        {
                            // Pick a random category
                            listCategories.Add(listGeo);
                            listCategories.Add(listHist);
                            listCategories.Add(listShow);
                            listCategories.Add(listBio);
                            listCategories.Add(listLit);
                            listCategories.Add(listMyth);
                            listCategories.Add(listSport);
                            listCategories.Add(listChem);
                            listCategories.Add(listOther);
                            CatIndex = randomNumber.Next(0, 9);
                            PickWord(listCategories[CatIndex]);
                            break;
                        }

                    case 1:
                        {
                            PickWord(listGeo);
                            break;
                        }

                    case 2:
                        {
                            PickWord(listHist);
                            break;
                        }

                    case 3:
                        {
                            PickWord(listBio);
                            break;
                        }

                    case 4:
                        {
                            PickWord(listChem);
                            break;
                        }

                    case 5:
                        {
                            PickWord(listLit);
                            break;
                        }

                    case 6:
                        {
                            PickWord(listMyth);
                            break;
                        }

                    case 7:
                        {
                            PickWord(listSport);
                            break;
                        }

                    case 8:
                        {
                            PickWord(listShow);
                            break;
                        }

                    case 9:
                        {
                            PickWord(listOther);
                            break;
                        }
                }

                //Place number of blanks
                labelSubCat.Text = currentSubCat;
                firstBlank = (int)(10 - (currentWord.Length / 2));
                for (int i = firstBlank; i < (currentWord.Length + firstBlank); i++)
                {
                    if (currentWordChar[i - firstBlank] != ' ')
                    {
                        SortedListOfBlanks[i].Visible = true;
                        numberLetters++;
                    }
                }
            }
        }

        private void FormHangMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormHangMan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }      
    }
}
