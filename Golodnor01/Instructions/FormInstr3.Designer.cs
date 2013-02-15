namespace Golodnor01
{
    partial class FormInstr3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstr3));
            this.labelInstr3 = new System.Windows.Forms.Label();
            this.labelInstr1 = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.pictureArrowStart = new System.Windows.Forms.PictureBox();
            this.pictureArrowLeft = new System.Windows.Forms.PictureBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstr3
            // 
            this.labelInstr3.BackColor = System.Drawing.Color.Transparent;
            this.labelInstr3.Font = new System.Drawing.Font("Advokat Modern", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr3.Location = new System.Drawing.Point(285, 441);
            this.labelInstr3.Name = "labelInstr3";
            this.labelInstr3.Size = new System.Drawing.Size(227, 103);
            this.labelInstr3.TabIndex = 18;
            this.labelInstr3.Text = "УСПЕХ!!!";
            this.labelInstr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstr1
            // 
            this.labelInstr1.BackColor = System.Drawing.Color.Transparent;
            this.labelInstr1.Font = new System.Drawing.Font("Advokat Modern", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr1.Location = new System.Drawing.Point(72, 157);
            this.labelInstr1.Name = "labelInstr1";
            this.labelInstr1.Size = new System.Drawing.Size(700, 299);
            this.labelInstr1.TabIndex = 14;
            this.labelInstr1.Text = resources.GetString("labelInstr1.Text");
            this.labelInstr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStart.Font = new System.Drawing.Font("Advokat Modern", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(337, 555);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(359, 79);
            this.labelStart.TabIndex = 20;
            this.labelStart.Text = "към играта";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // pictureArrowStart
            // 
            this.pictureArrowStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureArrowStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowStart.Image = global::Golodnor01.Properties.Resources.arrowRight;
            this.pictureArrowStart.Location = new System.Drawing.Point(692, 563);
            this.pictureArrowStart.Name = "pictureArrowStart";
            this.pictureArrowStart.Size = new System.Drawing.Size(39, 65);
            this.pictureArrowStart.TabIndex = 21;
            this.pictureArrowStart.TabStop = false;
            this.pictureArrowStart.Click += new System.EventHandler(this.pictureArrowStart_Click);
            // 
            // pictureArrowLeft
            // 
            this.pictureArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowLeft.Image = global::Golodnor01.Properties.Resources.arrowLeft;
            this.pictureArrowLeft.Location = new System.Drawing.Point(25, 418);
            this.pictureArrowLeft.Name = "pictureArrowLeft";
            this.pictureArrowLeft.Size = new System.Drawing.Size(46, 65);
            this.pictureArrowLeft.TabIndex = 19;
            this.pictureArrowLeft.TabStop = false;
            this.pictureArrowLeft.Click += new System.EventHandler(this.pictureArrowLeft_Click);
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
            this.buttonMusic.TabIndex = 24;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormInstr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperInstr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.pictureArrowStart);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.pictureArrowLeft);
            this.Controls.Add(this.labelInstr3);
            this.Controls.Add(this.labelInstr1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormInstr3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.FormInstr3_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormInstr3_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArrowLeft;
        private System.Windows.Forms.Label labelInstr3;
        private System.Windows.Forms.Label labelInstr1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.PictureBox pictureArrowStart;
        private System.Windows.Forms.Button buttonMusic;

    }
}