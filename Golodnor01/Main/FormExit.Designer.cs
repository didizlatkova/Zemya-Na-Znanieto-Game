namespace Golodnor01
{
    partial class FormExit
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
            this.labelExitMessage = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExitMessage
            // 
            this.labelExitMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelExitMessage.Font = new System.Drawing.Font("Advokat Modern", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExitMessage.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelExitMessage.Location = new System.Drawing.Point(11, 14);
            this.labelExitMessage.Name = "labelExitMessage";
            this.labelExitMessage.Size = new System.Drawing.Size(235, 76);
            this.labelExitMessage.TabIndex = 7;
            this.labelExitMessage.Text = "Сигурни ли сте, че искате да напуснете играта?";
            this.labelExitMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonYes.Location = new System.Drawing.Point(32, 85);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(85, 53);
            this.buttonYes.TabIndex = 13;
            this.buttonYes.Text = "ДА";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Transparent;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonNo.Location = new System.Drawing.Point(128, 85);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(85, 53);
            this.buttonNo.TabIndex = 14;
            this.buttonNo.Text = "НЕ";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.exitForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 148);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelExitMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormExit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изход?";
            this.Load += new System.EventHandler(this.FormExit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExitMessage;
        public System.Windows.Forms.Button buttonYes;
        public System.Windows.Forms.Button buttonNo;

    }
}