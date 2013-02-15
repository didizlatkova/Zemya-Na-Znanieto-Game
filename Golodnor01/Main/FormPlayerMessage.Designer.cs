namespace Golodnor01
{
    partial class FormPlayerMessage
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
            this.labelPlayerMessage = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayerMessage
            // 
            this.labelPlayerMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerMessage.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelPlayerMessage.Location = new System.Drawing.Point(2, 1);
            this.labelPlayerMessage.Name = "labelPlayerMessage";
            this.labelPlayerMessage.Size = new System.Drawing.Size(219, 104);
            this.labelPlayerMessage.TabIndex = 15;
            this.labelPlayerMessage.Text = "Първо трябва да изберете играч!";
            this.labelPlayerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonOk.Location = new System.Drawing.Point(74, 108);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(76, 41);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // FormPlayerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.HintMessageForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(222, 161);
            this.Controls.Add(this.labelPlayerMessage);
            this.Controls.Add(this.buttonOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlayerMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlayerMessage";
            this.Load += new System.EventHandler(this.FormPlayerMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelPlayerMessage;
        private System.Windows.Forms.Button buttonOk;
    }
}