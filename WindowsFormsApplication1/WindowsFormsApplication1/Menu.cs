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
        public Menu()
		{
			InitializeComponent();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
	}
}
