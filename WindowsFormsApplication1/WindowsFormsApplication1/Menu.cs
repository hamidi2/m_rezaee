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
	public partial class Menu : Form
	{
        SQLiteConnection dbConn;
        public SQLiteConnection DBConnection
        {
            get { return dbConn; }
        }

        public Menu()
		{
			InitializeComponent();
            dbConn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConn.Open();
            new SQLiteCommand("create table if not exists students (name varchar(20), score int)", dbConn).ExecuteNonQuery();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            new TeachersForm().Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            new StudentsForm().Show();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new StudentsForm2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new StudentsForm3().Show();
        }
	}
}
