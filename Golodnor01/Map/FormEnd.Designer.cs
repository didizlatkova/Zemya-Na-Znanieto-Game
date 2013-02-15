namespace Golodnor01
{
    partial class FormEnd
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
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.pictureLine = new System.Windows.Forms.PictureBox();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.labelExpl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Golodnor01.DataSet();
            this.userTableTableAdapter = new Golodnor01.DataSetTableAdapters.UserTableTableAdapter();
            this.labelChart = new System.Windows.Forms.Label();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnd
            // 
            this.labelEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd.ForeColor = System.Drawing.Color.Tan;
            this.labelEnd.Location = new System.Drawing.Point(206, 22);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(443, 81);
            this.labelEnd.TabIndex = 87;
            this.labelEnd.Text = "Край на Играта";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Bookman Old Style", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.Tan;
            this.labelResult.Location = new System.Drawing.Point(17, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(185, 44);
            this.labelResult.TabIndex = 88;
            this.labelResult.Text = "Резултат:";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Visible = false;
            // 
            // labelLevel
            // 
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.Color.Tan;
            this.labelLevel.Location = new System.Drawing.Point(70, 213);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(96, 44);
            this.labelLevel.TabIndex = 89;
            this.labelLevel.Text = "1";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLevel.Visible = false;
            // 
            // labelMultiply
            // 
            this.labelMultiply.BackColor = System.Drawing.Color.Transparent;
            this.labelMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMultiply.ForeColor = System.Drawing.Color.Tan;
            this.labelMultiply.Location = new System.Drawing.Point(172, 213);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(55, 44);
            this.labelMultiply.TabIndex = 90;
            this.labelMultiply.Text = "х";
            this.labelMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMultiply.Visible = false;
            // 
            // label100
            // 
            this.label100.BackColor = System.Drawing.Color.Transparent;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label100.ForeColor = System.Drawing.Color.Tan;
            this.label100.Location = new System.Drawing.Point(247, 213);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(109, 44);
            this.label100.TabIndex = 91;
            this.label100.Text = "100";
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label100.Visible = false;
            // 
            // labelPlus
            // 
            this.labelPlus.BackColor = System.Drawing.Color.Transparent;
            this.labelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlus.ForeColor = System.Drawing.Color.Tan;
            this.labelPlus.Location = new System.Drawing.Point(38, 260);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(30, 44);
            this.labelPlus.TabIndex = 92;
            this.labelPlus.Text = "+";
            this.labelPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlus.Visible = false;
            // 
            // labelCoins
            // 
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.Tan;
            this.labelCoins.Location = new System.Drawing.Point(65, 283);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(111, 54);
            this.labelCoins.TabIndex = 93;
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCoins.Visible = false;
            // 
            // pictureLine
            // 
            this.pictureLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureLine.Image = global::Golodnor01.Properties.Resources.lineEnd;
            this.pictureLine.Location = new System.Drawing.Point(59, 358);
            this.pictureLine.Name = "pictureLine";
            this.pictureLine.Size = new System.Drawing.Size(268, 14);
            this.pictureLine.TabIndex = 94;
            this.pictureLine.TabStop = false;
            this.pictureLine.Visible = false;
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalResult.ForeColor = System.Drawing.Color.Tan;
            this.labelFinalResult.Location = new System.Drawing.Point(61, 389);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(166, 81);
            this.labelFinalResult.TabIndex = 95;
            this.labelFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinalResult.Visible = false;
            // 
            // timerResult
            // 
            this.timerResult.Interval = 1000;
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // labelExpl
            // 
            this.labelExpl.BackColor = System.Drawing.Color.Transparent;
            this.labelExpl.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpl.ForeColor = System.Drawing.Color.Tan;
            this.labelExpl.Location = new System.Drawing.Point(197, 138);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(590, 44);
            this.labelExpl.TabIndex = 97;
            this.labelExpl.Text = "(бр. отговорени въпроси * 100 + бр. жълтици)";
            this.labelExpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExpl.Visible = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(362, 248);
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
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.Visible = false;
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
            // labelChart
            // 
            this.labelChart.BackColor = System.Drawing.Color.Transparent;
            this.labelChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChart.ForeColor = System.Drawing.Color.Tan;
            this.labelChart.Location = new System.Drawing.Point(438, 201);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(239, 44);
            this.labelChart.TabIndex = 100;
            this.labelChart.Text = "Класация";
            this.labelChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChart.Visible = false;
            // 
            // labelNewGame
            // 
            this.labelNewGame.BackColor = System.Drawing.Color.Transparent;
            this.labelNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewGame.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGame.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelNewGame.Location = new System.Drawing.Point(78, 496);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(227, 57);
            this.labelNewGame.TabIndex = 101;
            this.labelNewGame.Text = "Нова игра";
            this.labelNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Image = global::Golodnor01.Properties.Resources.buttonBrown;
            this.labelExit.Location = new System.Drawing.Point(78, 576);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(227, 57);
            this.labelExit.TabIndex = 102;
            this.labelExit.Text = "Изход";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // FormEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golodnor01.Properties.Resources.wallpaperEndFrame2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 668);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelNewGame);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelExpl);
            this.Controls.Add(this.labelFinalResult);
            this.Controls.Add(this.pictureLine);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.labelMultiply);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEnd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Земя на Знанието";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEnd_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEnd_FormClosed);
            this.Load += new System.EventHandler(this.FormEnd_Load);
            this.VisibleChanged += new System.EventHandler(this.FormEnd_VisibleChanged);
            this.DoubleClick += new System.EventHandler(this.FormEnd_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox pictureLine;
        private System.Windows.Forms.Label labelFinalResult;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.Label labelExpl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private DataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userScoreDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label labelNewGame;
        public System.Windows.Forms.Label labelExit;
    }
}