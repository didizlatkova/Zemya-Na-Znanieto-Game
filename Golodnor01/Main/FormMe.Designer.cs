namespace Golodnor01
{
    partial class FormMe
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
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureArrowMain = new System.Windows.Forms.PictureBox();
            this.pictureMe = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.Black;
            this.labelMain.Location = new System.Drawing.Point(68, 592);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(247, 67);
            this.labelMain.TabIndex = 35;
            this.labelMain.Text = "Начало";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            // 
            // pictureArrowMain
            // 
            this.pictureArrowMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowMain.Image = global::Golodnor01.Properties.Resources.arrowLeft;
            this.pictureArrowMain.Location = new System.Drawing.Point(31, 592);
            this.pictureArrowMain.Name = "pictureArrowMain";
            this.pictureArrowMain.Size = new System.Drawing.Size(38, 67);
            this.pictureArrowMain.TabIndex = 34;
            this.pictureArrowMain.TabStop = false;
            this.pictureArrowMain.Click += new System.EventHandler(this.labelMain_Click);
            // 
            // pictureMe
            // 
            this.pictureMe.BackColor = System.Drawing.Color.Transparent;
            this.pictureMe.BackgroundImage = global::Golodnor01.Properties.Resources.me;
            this.pictureMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMe.Location = new System.Drawing.Point(22, 148);
            this.pictureMe.Name = "pictureMe";
            this.pictureMe.Size = new System.Drawing.Size(229, 284);
            this.pictureMe.TabIndex = 36;
            this.pictureMe.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfo.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(257, 160);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(244, 263);
            this.labelInfo.TabIndex = 37;
            this.labelInfo.Text = "Име:\r\nГодини:\r\nГодина на създаване\r\nна играта:\r\nУчилище:\r\n\r\nГрад:\r\nE-mail за връз" +
    "ка:";
            // 
            // labelInfo2
            // 
            this.labelInfo2.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInfo2.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.ForeColor = System.Drawing.Color.Black;
            this.labelInfo2.Location = new System.Drawing.Point(502, 160);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(276, 263);
            this.labelInfo2.TabIndex = 38;
            this.labelInfo2.Text = "Димитрина Златкова\r\n18\r\n\r\n2012\r\n\r\nПМГ \"Акад. С.П. Корольов\"\r\nБлагоевград\r\ndidi.zl" +
    "atkova93@gmail.com";
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
            this.buttonMusic.TabIndex = 39;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperLoading;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureMe);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.pictureArrowMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMe_FormClosed);
            this.Load += new System.EventHandler(this.FormMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureArrowMain;
        private System.Windows.Forms.PictureBox pictureMe;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button buttonMusic;
    }
}