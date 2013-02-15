namespace Golodnor01
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureChart = new System.Windows.Forms.PictureBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.pictureMe = new System.Windows.Forms.PictureBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelMe = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureChart
            // 
            this.pictureChart.BackColor = System.Drawing.Color.Transparent;
            this.pictureChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureChart.Location = new System.Drawing.Point(157, 415);
            this.pictureChart.Name = "pictureChart";
            this.pictureChart.Size = new System.Drawing.Size(227, 57);
            this.pictureChart.TabIndex = 5;
            this.pictureChart.TabStop = false;
            // 
            // labelPlayer
            // 
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlayer.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelPlayer.Location = new System.Drawing.Point(390, 415);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(227, 57);
            this.labelPlayer.TabIndex = 10;
            this.labelPlayer.Text = "Играч";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer.Click += new System.EventHandler(this.labelPlayer_Click);
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.BackColor = System.Drawing.Color.Sienna;
            this.textBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlayer.Location = new System.Drawing.Point(623, 570);
            this.textBoxPlayer.MaxLength = 10;
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(165, 44);
            this.textBoxPlayer.TabIndex = 19;
            this.textBoxPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlayer.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonOk.Location = new System.Drawing.Point(705, 619);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 41);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Visible = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.BackColor = System.Drawing.Color.Sienna;
            this.listBoxPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPlayers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 25;
            this.listBoxPlayers.Location = new System.Drawing.Point(623, 415);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(165, 129);
            this.listBoxPlayers.TabIndex = 18;
            this.listBoxPlayers.Visible = false;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
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
            this.buttonMusic.TabIndex = 23;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // pictureMe
            // 
            this.pictureMe.BackColor = System.Drawing.Color.Transparent;
            this.pictureMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMe.Location = new System.Drawing.Point(390, 490);
            this.pictureMe.Name = "pictureMe";
            this.pictureMe.Size = new System.Drawing.Size(227, 57);
            this.pictureMe.TabIndex = 24;
            this.pictureMe.TabStop = false;
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStart.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Image = global::Golodnor01.Properties.Resources.buttonBrownBig;
            this.labelStart.Location = new System.Drawing.Point(285, 315);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(227, 83);
            this.labelStart.TabIndex = 25;
            this.labelStart.Text = "Започни";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelExit.Location = new System.Drawing.Point(285, 562);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(227, 57);
            this.labelExit.TabIndex = 26;
            this.labelExit.Text = "Изход";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelMe
            // 
            this.labelMe.BackColor = System.Drawing.Color.Transparent;
            this.labelMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMe.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMe.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelMe.Location = new System.Drawing.Point(390, 490);
            this.labelMe.Name = "labelMe";
            this.labelMe.Size = new System.Drawing.Size(227, 57);
            this.labelMe.TabIndex = 27;
            this.labelMe.Text = "За автора";
            this.labelMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMe.Click += new System.EventHandler(this.labelMe_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAdmin.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdmin.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelAdmin.Location = new System.Drawing.Point(157, 487);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(227, 57);
            this.labelAdmin.TabIndex = 28;
            this.labelAdmin.Text = "Администратор";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // labelChart
            // 
            this.labelChart.BackColor = System.Drawing.Color.Transparent;
            this.labelChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChart.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChart.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelChart.Location = new System.Drawing.Point(157, 415);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(227, 57);
            this.labelChart.TabIndex = 29;
            this.labelChart.Text = "Класация";
            this.labelChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChart.Click += new System.EventHandler(this.labelChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelMe);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.pictureMe);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pictureChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureChart;
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.PictureBox pictureMe;
        public System.Windows.Forms.Label labelStart;
        public System.Windows.Forms.Label labelExit;
        public System.Windows.Forms.Label labelMe;
        public System.Windows.Forms.Label labelAdmin;
        public System.Windows.Forms.Label labelChart;
    }
}

