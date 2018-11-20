using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class List : Form
    {
	    private SQLiteDataAdapter _ad;
		private readonly DataTable _dt = new DataTable();

		public List()
        {
            InitializeComponent();
			comboBox1.SelectedIndex = 1;
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			_ad = new SQLiteDataAdapter("select * from students", DB.Connection);
			var builder = new SQLiteCommandBuilder(_ad);
			_ad.DeleteCommand = builder.GetDeleteCommand();
			_ad.InsertCommand = builder.GetInsertCommand();
			_ad.SelectCommand = builder.GetUpdateCommand();
			_ad.Fill(_dt);
	        btnEdit.Enabled = btnRemove.Enabled = _dt.Rows.Count != 0;
			listBox1.DataSource = _dt;
			listBox1.DisplayMember = "name";
		}

	    void Update()
	    {
			_ad.Update(_dt);
			btnEdit.Enabled = btnRemove.Enabled = _dt.Rows.Count != 0;
		}
	
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var row = _dt.Rows.Add();
			row["national_id"] = 1;
			Update();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			_dt.Rows.RemoveAt(listBox1.SelectedIndex);
			Update();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Debug.Assert(listBox1.SelectedItem is DataRowView);
			var f = new StudentsForm2(listBox1.SelectedItem as DataRowView);
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				_ad.Update(_dt);
				Update();
			}
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

