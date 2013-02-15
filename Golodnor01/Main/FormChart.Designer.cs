namespace Golodnor01
{
    partial class FormChart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Golodnor01.DataSet();
            this.userTableTableAdapter = new Golodnor01.DataSetTableAdapters.UserTableTableAdapter();
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureArrowMain = new System.Windows.Forms.PictureBox();
            this.buttonMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.userScoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(197, 155);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(404, 385);
            this.dataGridView1.TabIndex = 1;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Играч";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // userScoreDataGridViewTextBoxColumn
            // 
            this.userScoreDataGridViewTextBoxColumn.DataPropertyName = "UserScore";
            this.userScoreDataGridViewTextBoxColumn.HeaderText = "Точки";
            this.userScoreDataGridViewTextBoxColumn.Name = "userScoreDataGridViewTextBoxColumn";
            this.userScoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.userScoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.userScoreDataGridViewTextBoxColumn.Width = 200;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.Black;
            this.labelMain.Location = new System.Drawing.Point(67, 592);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(271, 67);
            this.labelMain.TabIndex = 33;
            this.labelMain.Text = "Начало";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            // 
            // pictureArrowMain
            // 
            this.pictureArrowMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureArrowMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureArrowMain.Image = global::Golodnor01.Properties.Resources.arrowLeft;
            this.pictureArrowMain.Location = new System.Drawing.Point(30, 592);
            this.pictureArrowMain.Name = "pictureArrowMain";
            this.pictureArrowMain.Size = new System.Drawing.Size(38, 67);
            this.pictureArrowMain.TabIndex = 32;
            this.pictureArrowMain.TabStop = false;
            this.pictureArrowMain.Click += new System.EventHandler(this.labelMain_Click);
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
            this.buttonMusic.TabIndex = 34;
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperChart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.pictureArrowMain);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChart_FormClosed);
            this.Load += new System.EventHandler(this.FormChart_Load);
            this.VisibleChanged += new System.EventHandler(this.FormChart_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArrowMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private DataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureArrowMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonMusic;
    }
}