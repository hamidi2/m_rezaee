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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
			comboBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
			{
				var data = DB.ExecuteScalar("select name from students");
				string firstColumn = null;
				if (data != null)
					firstColumn = data.ToString();
				listBox1.DataSource = data;
			}
			catch
			{
				throw;
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                new TeachersForm().Show();
            else
                new StudentsForm2().ShowDialog(this);
        }

		private void List_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

    }
}
