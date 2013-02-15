namespace Golodnor01
{
    partial class FormMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.buttonOk = new System.Windows.Forms.Button();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            this.axIntro = new AxWMPLib.AxWindowsMediaPlayer();
            this.axLevel1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axLevel2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axLevel3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axLevel4 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrownDialogSmall;
            this.buttonOk.Location = new System.Drawing.Point(30, 52);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(63, 31);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBarMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMusic.LargeChange = 50;
            this.trackBarMusic.Location = new System.Drawing.Point(12, 5);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(104, 45);
            this.trackBarMusic.SmallChange = 10;
            this.trackBarMusic.TabIndex = 13;
            this.trackBarMusic.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarMusic.Value = 50;
            this.trackBarMusic.Scroll += new System.EventHandler(this.trackBarMusic_Scroll);
            // 
            // axIntro
            // 
            this.axIntro.Enabled = true;
            this.axIntro.Location = new System.Drawing.Point(3, 5);
            this.axIntro.Name = "axIntro";
            this.axIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIntro.OcxState")));
            this.axIntro.Size = new System.Drawing.Size(75, 23);
            this.axIntro.TabIndex = 15;
            this.axIntro.Visible = false;
            // 
            // axLevel1
            // 
            this.axLevel1.Enabled = true;
            this.axLevel1.Location = new System.Drawing.Point(3, 27);
            this.axLevel1.Name = "axLevel1";
            this.axLevel1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLevel1.OcxState")));
            this.axLevel1.Size = new System.Drawing.Size(75, 23);
            this.axLevel1.TabIndex = 16;
            this.axLevel1.Visible = false;
            // 
            // axLevel2
            // 
            this.axLevel2.Enabled = true;
            this.axLevel2.Location = new System.Drawing.Point(3, 50);
            this.axLevel2.Name = "axLevel2";
            this.axLevel2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLevel2.OcxState")));
            this.axLevel2.Size = new System.Drawing.Size(75, 23);
            this.axLevel2.TabIndex = 17;
            this.axLevel2.Visible = false;
            // 
            // axLevel3
            // 
            this.axLevel3.Enabled = true;
            this.axLevel3.Location = new System.Drawing.Point(53, 12);
            this.axLevel3.Name = "axLevel3";
            this.axLevel3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLevel3.OcxState")));
            this.axLevel3.Size = new System.Drawing.Size(75, 23);
            this.axLevel3.TabIndex = 18;
            this.axLevel3.Visible = false;
            // 
            // axLevel4
            // 
            this.axLevel4.Enabled = true;
            this.axLevel4.Location = new System.Drawing.Point(53, 41);
            this.axLevel4.Name = "axLevel4";
            this.axLevel4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLevel4.OcxState")));
            this.axLevel4.Size = new System.Drawing.Size(75, 23);
            this.axLevel4.TabIndex = 19;
            this.axLevel4.Visible = false;
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.exitForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(130, 85);
            this.Controls.Add(this.axLevel4);
            this.Controls.Add(this.axLevel3);
            this.Controls.Add(this.axLevel2);
            this.Controls.Add(this.axLevel1);
            this.Controls.Add(this.axIntro);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.trackBarMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMusic";
            this.Load += new System.EventHandler(this.FormMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLevel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TrackBar trackBarMusic;
        public AxWMPLib.AxWindowsMediaPlayer axIntro;
        public AxWMPLib.AxWindowsMediaPlayer axLevel1;
        public AxWMPLib.AxWindowsMediaPlayer axLevel2;
        public AxWMPLib.AxWindowsMediaPlayer axLevel3;
        public AxWMPLib.AxWindowsMediaPlayer axLevel4;
    }
}