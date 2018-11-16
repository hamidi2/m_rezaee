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
				var reader = DB.ExecuteReader("select * from students");
				var names = new List<string>();
				if (reader.HasRows)
				{
					while (reader.Read())
						names.Add(reader["name"].ToString());
				}
				listBox1.DataSource = names;
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
                //new StudentsForm2().ShowDialog(this);
	            new StudentsForm().ShowDialog(this);
        }

		private void List_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = listBox1.Items.Count != 0;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{

		}

    }
}
