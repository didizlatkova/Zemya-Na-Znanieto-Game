namespace Golodnor01
{
    partial class FormHintMessage
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelHintMessage = new System.Windows.Forms.Label();
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
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonOk.Location = new System.Drawing.Point(77, 109);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(76, 41);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // labelHintMessage
            // 
            this.labelHintMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelHintMessage.Font = new System.Drawing.Font("Advokat Modern", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHintMessage.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelHintMessage.Location = new System.Drawing.Point(5, 15);
            this.labelHintMessage.Name = "labelHintMessage";
            this.labelHintMessage.Size = new System.Drawing.Size(227, 91);
            this.labelHintMessage.TabIndex = 13;
            this.labelHintMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHintMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.HintMessageForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 163);
            this.Controls.Add(this.labelHintMessage);
            this.Controls.Add(this.buttonOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormHintMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormHintMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.Label labelHintMessage;

    }
}