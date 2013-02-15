namespace Golodnor01
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelImg1 = new System.Windows.Forms.Label();
            this.labelImg2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo2
            // 
            this.labelInfo2.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.Location = new System.Drawing.Point(36, 306);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(540, 226);
            this.labelInfo2.TabIndex = 4;
            this.labelInfo2.Text = resources.GetString("labelInfo2.Text");
            this.labelInfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelImg1
            // 
            this.labelImg1.BackColor = System.Drawing.Color.Transparent;
            this.labelImg1.Image = global::Golodnor01.Properties.Resources.info1_1;
            this.labelImg1.Location = new System.Drawing.Point(579, 49);
            this.labelImg1.Name = "labelImg1";
            this.labelImg1.Size = new System.Drawing.Size(400, 250);
            this.labelImg1.TabIndex = 56;
            this.labelImg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImg2
            // 
            this.labelImg2.BackColor = System.Drawing.Color.Transparent;
            this.labelImg2.Image = global::Golodnor01.Properties.Resources.info1_2;
            this.labelImg2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelImg2.Location = new System.Drawing.Point(579, 299);
            this.labelImg2.Name = "labelImg2";
            this.labelImg2.Size = new System.Drawing.Size(400, 250);
            this.labelImg2.TabIndex = 57;
            this.labelImg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonOk.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.buttonOk.Location = new System.Drawing.Point(443, 552);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(259, 56);
            this.buttonOk.TabIndex = 58;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelInfo1
            // 
            this.labelInfo1.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo1.Location = new System.Drawing.Point(36, 70);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(540, 222);
            this.labelInfo1.TabIndex = 59;
            this.labelInfo1.Text = resources.GetString("labelInfo1.Text");
            this.labelInfo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.buttonMusic.Location = new System.Drawing.Point(942, 12);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(46, 46);
            this.buttonMusic.TabIndex = 60;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperInfo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelImg2);
            this.Controls.Add(this.labelImg1);
            this.Controls.Add(this.labelInfo2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Label labelInfo2;
        public System.Windows.Forms.Label labelImg1;
        public System.Windows.Forms.Label labelImg2;
        public System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Button buttonMusic;
    }
}