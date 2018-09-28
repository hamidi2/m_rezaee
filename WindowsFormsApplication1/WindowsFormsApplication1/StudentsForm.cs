using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
	public partial class StudentsForm : Form
	{
		public StudentsForm()
		{
			InitializeComponent();
		}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void lineShape6_Click(object sender, EventArgs e)
        {

        }

        private void lineShape12_Click(object sender, EventArgs e)
        {

        }

        private void lineShape11_Click(object sender, EventArgs e)
        {

        }

        private void lineShape10_Click(object sender, EventArgs e)
        {

        }

        private void lineShape8_Click(object sender, EventArgs e)
        {

        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sql = "insert into students values ('hamidi', 2)";
            var parent = Parent as Menu;
            var cmd = new SQLiteCommand(sql, parent.DBConnection);
            cmd.ExecuteNonQuery();
        }
	}
}

