namespace Golodnor01
{
    partial class FormRiddle3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.labelH3 = new System.Windows.Forms.Label();
            this.labelH2 = new System.Windows.Forms.Label();
            this.labelH1 = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.pictureQuestion = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.pictureCoins = new System.Windows.Forms.PictureBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelSkip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(184, 52);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(456, 277);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Кое е това нещо, което е в началото на еволюцията, намира се в центъра на Вселена" +
                "та, но в същото време е последно при видовете?";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAns
            // 
            this.textBoxAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAns.Location = new System.Drawing.Point(274, 330);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(128, 62);
            this.textBoxAns.TabIndex = 1;
            this.textBoxAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelH3
            // 
            this.labelH3.BackColor = System.Drawing.Color.Transparent;
            this.labelH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelH3.Location = new System.Drawing.Point(81, 576);
            this.labelH3.Name = "labelH3";
            this.labelH3.Size = new System.Drawing.Size(537, 37);
            this.labelH3.TabIndex = 28;
            this.labelH3.Text = "3) Отговорът е буква от азбуката.";
            this.labelH3.Visible = false;
            // 
            // labelH2
            // 
            this.labelH2.BackColor = System.Drawing.Color.Transparent;
            this.labelH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelH2.Location = new System.Drawing.Point(83, 534);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(535, 42);
            this.labelH2.TabIndex = 27;
            this.labelH2.Text = "2) Отговорът е само един символ.";
            this.labelH2.Visible = false;
            // 
            // labelH1
            // 
            this.labelH1.BackColor = System.Drawing.Color.Transparent;
            this.labelH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelH1.Location = new System.Drawing.Point(83, 467);
            this.labelH1.Name = "labelH1";
            this.labelH1.Size = new System.Drawing.Size(573, 59);
            this.labelH1.TabIndex = 26;
            this.labelH1.Text = "1) Не осмисляйте изречението, а се вгледайте в думите по-внимателно.";
            this.labelH1.Visible = false;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHint.Location = new System.Drawing.Point(104, 431);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(369, 37);
            this.labelHint.TabIndex = 22;
            this.labelHint.Text = "подсказка: 20 жълтици";
            this.labelHint.Click += new System.EventHandler(this.labelHint1_Click);
            // 
            // pictureQuestion
            // 
            this.pictureQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pictureQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureQuestion.Image = global::Golodnor01.Properties.Resources.questionMark;
            this.pictureQuestion.Location = new System.Drawing.Point(709, 82);
            this.pictureQuestion.Name = "pictureQuestion";
            this.pictureQuestion.Size = new System.Drawing.Size(55, 53);
            this.pictureQuestion.TabIndex = 29;
            this.pictureQuestion.TabStop = false;
            this.pictureQuestion.Click += new System.EventHandler(this.pictureQuestion_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelCoins.Location = new System.Drawing.Point(31, 39);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(102, 70);
            this.labelCoins.TabIndex = 39;
            this.labelCoins.Text = "100";
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCoins
            // 
            this.pictureCoins.BackColor = System.Drawing.Color.Transparent;
            this.pictureCoins.Image = global::Golodnor01.Properties.Resources.coins;
            this.pictureCoins.Location = new System.Drawing.Point(126, 39);
            this.pictureCoins.Name = "pictureCoins";
            this.pictureCoins.Size = new System.Drawing.Size(68, 70);
            this.pictureCoins.TabIndex = 38;
            this.pictureCoins.TabStop = false;
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.Color.Transparent;
            this.buttonMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMusic.FlatAppearance.BorderSize = 2;
            this.buttonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusic.Image = global::Golodnor01.Properties.Resources.Notes;
            this.buttonMusic.Location = new System.Drawing.Point(711, 30);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(46, 46);
            this.buttonMusic.TabIndex = 40;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonGraycircle;
            this.buttonOk.Location = new System.Drawing.Point(442, 327);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 84);
            this.buttonOk.TabIndex = 41;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(523, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 80);
            this.label14.TabIndex = 112;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(439, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 10);
            this.label15.TabIndex = 111;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(441, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 10);
            this.label16.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(436, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 90);
            this.label13.TabIndex = 113;
            // 
            // labelSkip
            // 
            this.labelSkip.BackColor = System.Drawing.Color.Transparent;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.Image = global::Golodnor01.Properties.Resources.buttonGrayBigger;
            this.labelSkip.Location = new System.Drawing.Point(624, 550);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(140, 63);
            this.labelSkip.TabIndex = 121;
            this.labelSkip.Text = "пропусни играта";
            this.labelSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSkip.Click += new System.EventHandler(this.labelSkip_Click);
            // 
            // FormRiddle3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperRiddle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.labelSkip);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.pictureCoins);
            this.Controls.Add(this.pictureQuestion);
            this.Controls.Add(this.labelH3);
            this.Controls.Add(this.labelH2);
            this.Controls.Add(this.labelH1);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.labelQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormRiddle3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRiddle3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRiddle3_FormClosed);
            this.Load += new System.EventHandler(this.FormRiddle3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label labelH3;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.PictureBox pictureQuestion;
        public System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox pictureCoins;
        private System.Windows.Forms.Button buttonMusic;
        public System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label labelSkip;
    }
}

