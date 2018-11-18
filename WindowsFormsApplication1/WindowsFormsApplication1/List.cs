using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

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
			var cmd = new SQLiteCommand("select * from students", DB.Connection);
			var ad = new SQLiteDataAdapter(cmd);
			var dt = new DataTable();
			ad.Fill(dt);
			listBox1.DataSource = dt;
			listBox1.DisplayMember = "name";
			btnEdit.Enabled = btnRemove.Enabled = listBox1.Items.Count != 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Debug.Assert(listBox1.DataSource is DataTable);
			var dt = listBox1.DataSource as DataTable;
			dt.Rows.Add();
			btnEdit.Enabled = btnRemove.Enabled = dt.Rows.Count != 0;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Debug.Assert(listBox1.SelectedItem is DataRowView);
			new StudentsForm2(listBox1.SelectedItem as DataRowView).ShowDialog(this);
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			Debug.Assert(listBox1.DataSource is DataTable);
			var dt = listBox1.DataSource as DataTable;
			dt.Rows.RemoveAt(listBox1.SelectedIndex);
			btnEdit.Enabled = btnRemove.Enabled = dt.Rows.Count != 0;
		}

		private void List_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

    }
}

