using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Golodnor01
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
            methods.EmbedFont();
        }

        Methods methods = new Methods();

        private void FormChart_Load(object sender, EventArgs e)
        {
            // Set icon
            this.Icon = Forms.formMain.Icon;

            // Apply font
            labelMain.Font = new Font(methods.myFont.Families[0], 36, FontStyle.Bold);
            dataGridView1.Font = new Font(methods.myFont.Families[0], 16, FontStyle.Bold);
        }

        private void FormChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.formMain.FormMain_FormClosed(sender, e);
        }

        private void FormChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.formMain.FormMain_FormClosing(sender, e);
        }

        private void labelMain_Click(object sender, EventArgs e)
        {
            Forms.formMain.Show();
            this.Hide();
        }

        private void FormChart_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                DataSet ds = new DataSet();

                // TODO: This line of code loads data into the 'dataSet.UserTable' table. You can move, or remove it, as needed.
                this.userTableTableAdapter.Fill(this.dataSet.UserTable);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[dataGridView1.Rows.Count-1].Visible = false;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);               

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    dataGridView1.Rows[i].Height = 35;
                }               
                dataGridView1.Height = dataGridView1.Rows.Count * 35;               
               
                dataGridView1.Enabled = false;  
            }
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            Forms.formMusic.ShowDialog();
        }
    }
}
