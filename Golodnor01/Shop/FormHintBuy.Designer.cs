namespace Golodnor01
{
    partial class FormHintBuy
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
            this.labelBuy = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBuy
            // 
            this.labelBuy.BackColor = System.Drawing.Color.Transparent;
            this.labelBuy.Font = new System.Drawing.Font("Advokat Modern", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuy.ForeColor = System.Drawing.Color.BurlyWood;
            this.labelBuy.Location = new System.Drawing.Point(6, 19);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(235, 72);
            this.labelBuy.TabIndex = 14;
            this.labelBuy.Text = "Сигурни ли сте, че искате да купите този жокер?";
            this.labelBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonNo.Location = new System.Drawing.Point(128, 89);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(85, 53);
            this.buttonNo.TabIndex = 16;
            this.buttonNo.Text = "НЕ";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
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
            this.buttonYes.Location = new System.Drawing.Point(32, 89);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(85, 53);
            this.buttonYes.TabIndex = 15;
            this.buttonYes.Text = "ДА";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // FormHintBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.HintMessageForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(248, 154);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelBuy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormHintBuy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormHintBuy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBuy;
        public System.Windows.Forms.Button buttonNo;
        public System.Windows.Forms.Button buttonYes;
    }
}