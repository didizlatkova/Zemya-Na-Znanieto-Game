namespace Golodnor01
{
    partial class FormChangePlayerMessage
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
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.labelExitMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonNo.Location = new System.Drawing.Point(134, 137);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(85, 53);
            this.buttonNo.TabIndex = 17;
            this.buttonNo.Text = "НЕ";
            this.buttonNo.UseVisualStyleBackColor = false;
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
            this.buttonYes.Location = new System.Drawing.Point(38, 137);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(85, 53);
            this.buttonYes.TabIndex = 16;
            this.buttonYes.Text = "ДА";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // labelExitMessage
            // 
            this.labelExitMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelExitMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExitMessage.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelExitMessage.Location = new System.Drawing.Point(12, 19);
            this.labelExitMessage.Name = "labelExitMessage";
            this.labelExitMessage.Size = new System.Drawing.Size(235, 115);
            this.labelExitMessage.TabIndex = 15;
            this.labelExitMessage.Text = "Сигурни ли сте, че искате да смените играча? Сегашният играч ще загуби прогреса с" +
    "и!";
            this.labelExitMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChangePlayerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.exitForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(262, 200);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelExitMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangePlayerMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangePlayerMessage";
            this.Load += new System.EventHandler(this.FormChangePlayerMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonNo;
        public System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label labelExitMessage;
    }
}