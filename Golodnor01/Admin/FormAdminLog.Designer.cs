namespace Golodnor01
{
    partial class FormAdminLog
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
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelExpl = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.BackColor = System.Drawing.Color.Tan;
            this.textBoxPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPsw.Font = new System.Drawing.Font("Advokat Modern", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPsw.Location = new System.Drawing.Point(12, 48);
            this.textBoxPsw.MaxLength = 10;
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.PasswordChar = '*';
            this.textBoxPsw.Size = new System.Drawing.Size(187, 48);
            this.textBoxPsw.TabIndex = 1;
            this.textBoxPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Image = global::Golodnor01.Properties.Resources.buttonBrownDialog;
            this.buttonOk.Location = new System.Drawing.Point(3, 94);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(105, 51);
            this.buttonOk.TabIndex = 22;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelExpl
            // 
            this.labelExpl.BackColor = System.Drawing.Color.Transparent;
            this.labelExpl.Font = new System.Drawing.Font("Advokat Modern", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpl.ForeColor = System.Drawing.Color.Tan;
            this.labelExpl.Location = new System.Drawing.Point(7, 9);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(101, 34);
            this.labelExpl.TabIndex = 98;
            this.labelExpl.Text = "парола:";
            this.labelExpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::Golodnor01.Properties.Resources.buttonBrownDialogCancel;
            this.buttonCancel.Location = new System.Drawing.Point(95, 94);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 52);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "ОТКАЗ";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // FormAdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.exitForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(211, 146);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelExpl);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPsw);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminLog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminLog";
            this.Load += new System.EventHandler(this.FormAdminLog_Load);
            this.VisibleChanged += new System.EventHandler(this.FormAdminLog_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelExpl;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox textBoxPsw;
    }
}