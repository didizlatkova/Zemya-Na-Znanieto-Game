namespace Golodnor01
{
    partial class FormRiddle1
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
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.labelH2 = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelH1 = new System.Windows.Forms.Label();
            this.labelH3 = new System.Windows.Forms.PictureBox();
            this.pictureQuestion = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.pictureCoins = new System.Windows.Forms.PictureBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelSkip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labelH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAns
            // 
            this.textBoxAns.Font = new System.Drawing.Font("Advokat Modern", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAns.Location = new System.Drawing.Point(238, 345);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(128, 69);
            this.textBoxAns.TabIndex = 0;
            this.textBoxAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelH2
            // 
            this.labelH2.BackColor = System.Drawing.Color.Transparent;
            this.labelH2.Font = new System.Drawing.Font("Advokat Modern", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH2.ForeColor = System.Drawing.Color.DarkRed;
            this.labelH2.Location = new System.Drawing.Point(63, 501);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(645, 59);
            this.labelH2.TabIndex = 26;
            this.labelH2.Text = "2) Константите, подобно на числата, които определят, също могат да се \"събират\".";
            this.labelH2.Visible = false;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHint.Font = new System.Drawing.Font("Advokat Modern", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHint.Location = new System.Drawing.Point(136, 431);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(318, 37);
            this.labelHint.TabIndex = 22;
            this.labelHint.Text = "подсказка: 20 жълтици";
            this.labelHint.Click += new System.EventHandler(this.labelHint1_Click);
            // 
            // labelH1
            // 
            this.labelH1.BackColor = System.Drawing.Color.Transparent;
            this.labelH1.Font = new System.Drawing.Font("Advokat Modern", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH1.ForeColor = System.Drawing.Color.DarkRed;
            this.labelH1.Location = new System.Drawing.Point(65, 468);
            this.labelH1.Name = "labelH1";
            this.labelH1.Size = new System.Drawing.Size(723, 31);
            this.labelH1.TabIndex = 28;
            this.labelH1.Text = "1) Отговорът не е число, а дума, изписана на латиница.";
            this.labelH1.Visible = false;
            // 
            // labelH3
            // 
            this.labelH3.BackColor = System.Drawing.Color.Transparent;
            this.labelH3.Image = global::Golodnor01.Properties.Resources.Equasion2;
            this.labelH3.Location = new System.Drawing.Point(68, 563);
            this.labelH3.Name = "labelH3";
            this.labelH3.Size = new System.Drawing.Size(150, 93);
            this.labelH3.TabIndex = 29;
            this.labelH3.TabStop = false;
            this.labelH3.Visible = false;
            // 
            // pictureQuestion
            // 
            this.pictureQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pictureQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureQuestion.Image = global::Golodnor01.Properties.Resources.questionMark;
            this.pictureQuestion.Location = new System.Drawing.Point(640, 29);
            this.pictureQuestion.Name = "pictureQuestion";
            this.pictureQuestion.Size = new System.Drawing.Size(55, 53);
            this.pictureQuestion.TabIndex = 33;
            this.pictureQuestion.TabStop = false;
            this.pictureQuestion.Click += new System.EventHandler(this.pictureQuestion_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Advokat Modern", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelCoins.Location = new System.Drawing.Point(11, 29);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(102, 70);
            this.labelCoins.TabIndex = 37;
            this.labelCoins.Text = "100";
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCoins
            // 
            this.pictureCoins.BackColor = System.Drawing.Color.Transparent;
            this.pictureCoins.Image = global::Golodnor01.Properties.Resources.coins;
            this.pictureCoins.Location = new System.Drawing.Point(106, 29);
            this.pictureCoins.Name = "pictureCoins";
            this.pictureCoins.Size = new System.Drawing.Size(68, 70);
            this.pictureCoins.TabIndex = 36;
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
            this.buttonMusic.TabIndex = 38;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(399, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 70);
            this.label13.TabIndex = 118;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(475, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 70);
            this.label14.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(402, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 10);
            this.label15.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(398, 338);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 10);
            this.label16.TabIndex = 115;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonOk2;
            this.buttonOk.Location = new System.Drawing.Point(406, 345);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(71, 67);
            this.buttonOk.TabIndex = 114;
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelSkip
            // 
            this.labelSkip.BackColor = System.Drawing.Color.Transparent;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.Image = global::Golodnor01.Properties.Resources.buttonBrownBigger;
            this.labelSkip.Location = new System.Drawing.Point(606, 582);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(140, 63);
            this.labelSkip.TabIndex = 119;
            this.labelSkip.Text = "пропусни играта";
            this.labelSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSkip.Click += new System.EventHandler(this.labelSkip_Click);
            // 
            // FormRiddle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.Pig4;
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
            this.Controls.Add(this.labelH1);
            this.Controls.Add(this.labelH2);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxAns);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormRiddle1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRiddle1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRiddle1_FormClosed);
            this.Load += new System.EventHandler(this.FormRiddle1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labelH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.PictureBox labelH3;
        private System.Windows.Forms.PictureBox pictureQuestion;
        public System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox pictureCoins;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Label labelSkip;
    }
}

