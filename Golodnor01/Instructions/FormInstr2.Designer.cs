﻿namespace Golodnor01
{
    partial class FormInstr2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstr2));
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelInstr1 = new System.Windows.Forms.Label();
            this.pictureArrowLeft = new System.Windows.Forms.PictureBox();
            this.pictureArrowRight = new System.Windows.Forms.PictureBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowRight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSkip
            // 
            this.labelSkip.BackColor = System.Drawing.Color.Transparent;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Advokat Modern", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.Location = new System.Drawing.Point(355, 563);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(408, 52);
            this.labelSkip.TabIndex = 11;
            this.labelSkip.Text = "пропусни инструкциите ...";
            this.labelSkip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSkip.Click += new System.EventHandler(this.labelSkip_Click);
            // 
            // labelInstr1
            // 
            this.labelInstr1.BackColor = System.Drawing.Color.Transparent;
            this.labelInstr1.Font = new System.Drawing.Font("Advokat Modern", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstr1.Location = new System.Drawing.Point(70, 144);
            this.labelInstr1.Name = "labelInstr1";
            this.labelInstr1.Size = new System.Drawing.Size(648, 419);
            this.labelInstr1.TabIndex = 6;
            this.labelInstr1.Text = resources.GetString("labelInstr1.Text");
            this.labelInstr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureArrowLeft
            // 
            this.pictureArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowLeft.Image = global::Golodnor01.Properties.Resources.arrowLeft;
            this.pictureArrowLeft.Location = new System.Drawing.Point(22, 495);
            this.pictureArrowLeft.Name = "pictureArrowLeft";
            this.pictureArrowLeft.Size = new System.Drawing.Size(41, 68);
            this.pictureArrowLeft.TabIndex = 13;
            this.pictureArrowLeft.TabStop = false;
            this.pictureArrowLeft.Click += new System.EventHandler(this.pictureArrowLeft_Click);
            // 
            // pictureArrowRight
            // 
            this.pictureArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowRight.Image = global::Golodnor01.Properties.Resources.arrowRight;
            this.pictureArrowRight.Location = new System.Drawing.Point(711, 495);
            this.pictureArrowRight.Name = "pictureArrowRight";
            this.pictureArrowRight.Size = new System.Drawing.Size(40, 68);
            this.pictureArrowRight.TabIndex = 10;
            this.pictureArrowRight.TabStop = false;
            this.pictureArrowRight.Click += new System.EventHandler(this.pictureArrowRight_Click);
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
            // FormInstr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperInstr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.pictureArrowLeft);
            this.Controls.Add(this.labelSkip);
            this.Controls.Add(this.pictureArrowRight);
            this.Controls.Add(this.labelInstr1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormInstr2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.FormInstr2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.PictureBox pictureArrowRight;
        private System.Windows.Forms.Label labelInstr1;
        private System.Windows.Forms.PictureBox pictureArrowLeft;
        private System.Windows.Forms.Button buttonMusic;
    }
}