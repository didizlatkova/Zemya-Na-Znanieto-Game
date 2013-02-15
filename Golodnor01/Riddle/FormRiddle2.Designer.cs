namespace Golodnor01
{
    partial class FormRiddle2
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
            this.components = new System.ComponentModel.Container();
            this.pictureFirstRocket = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerRocket = new System.Windows.Forms.Timer(this.components);
            this.pictureSecondRocket = new System.Windows.Forms.PictureBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelH1 = new System.Windows.Forms.Label();
            this.labelH2 = new System.Windows.Forms.Label();
            this.labelH3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondRocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFirstRocket
            // 
            this.pictureFirstRocket.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirstRocket.Image = global::Golodnor01.Properties.Resources.rocket_golodnor3;
            this.pictureFirstRocket.Location = new System.Drawing.Point(34, 389);
            this.pictureFirstRocket.Name = "pictureFirstRocket";
            this.pictureFirstRocket.Size = new System.Drawing.Size(63, 174);
            this.pictureFirstRocket.TabIndex = 0;
            this.pictureFirstRocket.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(633, 221);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 49);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(699, 221);
            this.textBox3.MaxLength = 1;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 49);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(567, 221);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 49);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timerRocket
            // 
            this.timerRocket.Interval = 500;
            this.timerRocket.Tick += new System.EventHandler(this.timerRocket_Tick);
            // 
            // pictureSecondRocket
            // 
            this.pictureSecondRocket.BackColor = System.Drawing.Color.Transparent;
            this.pictureSecondRocket.Image = global::Golodnor01.Properties.Resources.r_f4;
            this.pictureSecondRocket.Location = new System.Drawing.Point(34, 389);
            this.pictureSecondRocket.Name = "pictureSecondRocket";
            this.pictureSecondRocket.Size = new System.Drawing.Size(67, 261);
            this.pictureSecondRocket.TabIndex = 6;
            this.pictureSecondRocket.TabStop = false;
            this.pictureSecondRocket.Visible = false;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHint.Font = new System.Drawing.Font("Advokat Modern", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHint.Location = new System.Drawing.Point(179, 426);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(314, 37);
            this.labelHint.TabIndex = 14;
            this.labelHint.Text = "подсказка: 20 жълтици";
            this.labelHint.Click += new System.EventHandler(this.labelHint1_Click);
            // 
            // labelH1
            // 
            this.labelH1.BackColor = System.Drawing.Color.Transparent;
            this.labelH1.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelH1.Location = new System.Drawing.Point(105, 459);
            this.labelH1.Name = "labelH1";
            this.labelH1.Size = new System.Drawing.Size(637, 59);
            this.labelH1.TabIndex = 19;
            this.labelH1.Text = "1) Какво е общото между числата от 1 до 10 и ракетите?";
            this.labelH1.Visible = false;
            // 
            // labelH2
            // 
            this.labelH2.BackColor = System.Drawing.Color.Transparent;
            this.labelH2.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelH2.Location = new System.Drawing.Point(105, 520);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(677, 42);
            this.labelH2.TabIndex = 20;
            this.labelH2.Text = "2) За да се изстреля ракетата трябва обратно броене.";
            this.labelH2.Visible = false;
            // 
            // labelH3
            // 
            this.labelH3.BackColor = System.Drawing.Color.Transparent;
            this.labelH3.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelH3.Location = new System.Drawing.Point(105, 562);
            this.labelH3.Name = "labelH3";
            this.labelH3.Size = new System.Drawing.Size(463, 59);
            this.labelH3.TabIndex = 21;
            this.labelH3.Text = "3) число=дума=първа буква\r\n      10   =десет= Д";
            this.labelH3.Visible = false;
            // 
            // pictureQuestion
            // 
            this.pictureQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pictureQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureQuestion.Image = global::Golodnor01.Properties.Resources.questionMark;
            this.pictureQuestion.Location = new System.Drawing.Point(633, 30);
            this.pictureQuestion.Name = "pictureQuestion";
            this.pictureQuestion.Size = new System.Drawing.Size(55, 53);
            this.pictureQuestion.TabIndex = 34;
            this.pictureQuestion.TabStop = false;
            this.pictureQuestion.Click += new System.EventHandler(this.pictureQuestion_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Advokat Modern", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelCoins.Location = new System.Drawing.Point(105, 23);
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
            this.pictureCoins.Location = new System.Drawing.Point(200, 23);
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
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(573, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 172);
            this.label13.TabIndex = 118;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(735, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 158);
            this.label14.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(573, 446);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 13);
            this.label15.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(578, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 10);
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
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.blue_button21;
            this.buttonOk.Location = new System.Drawing.Point(576, 287);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(167, 169);
            this.buttonOk.TabIndex = 114;
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelSkip
            // 
            this.labelSkip.BackColor = System.Drawing.Color.Transparent;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.Image = global::Golodnor01.Properties.Resources.buttonGrayBigger;
            this.labelSkip.Location = new System.Drawing.Point(603, 562);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(140, 63);
            this.labelSkip.TabIndex = 120;
            this.labelSkip.Text = "пропусни играта";
            this.labelSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSkip.Click += new System.EventHandler(this.labelSkip_Click);
            // 
            // FormRiddle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperRocket1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 662);
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
            this.Controls.Add(this.pictureSecondRocket);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureFirstRocket);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormRiddle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRiddle2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRiddle2_FormClosed);
            this.Load += new System.EventHandler(this.FormRiddle2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondRocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFirstRocket;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerRocket;
        private System.Windows.Forms.PictureBox pictureSecondRocket;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label labelH3;
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

