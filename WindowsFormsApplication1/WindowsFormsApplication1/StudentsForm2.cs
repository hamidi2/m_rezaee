using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class StudentsForm2 : Form
	{
		private DataRowView _student;

		public StudentsForm2(DataRowView student)
		{
			InitializeComponent();
			_student = student;
		}

		private void StudentsForm2_Load(object sender, EventArgs e)
		{
			if (_student == null)
			{
				ctrl_grade.SelectedIndex = 0;
			}
			else
			{
				
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			CalculateBMI();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			CalculateBMI();
		}

		private void CalculateBMI()
		{
			int h_cm;
			if (!int.TryParse(ctrl_height.Text, out h_cm))
				return;
			int w;
			if (!int.TryParse(ctrl_weight.Text, out w))
				return;
			var h = h_cm / 100.0;
			var bmi = w / (h * h);
			ctrl_bmi.Text = bmi.ToString("n2");
		}

		private void StudentsForm2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		void Save()
		{
			//if (_student == null)
			//{
			//    var sql = string.Format("insert into students (grade, height, weight, sbp, dbp) values ({0}, {1}, {2}, {3}, {4})", ctrl_grade.SelectedIndex, h, w, ctrl_sbp.Text, ctrl_dbp.Text);
			//    DB.ExecuteNonQuery(sql);
			//}
			//else
			//{
			//    var sql = string.Format("update students set (grade, height, weight, sbp, dbp) values ({0}, {1}, {2}, {3}, {4}) where national_id = {5}", ctrl_grade.SelectedIndex, h, w, ctrl_sbp.Text, ctrl_dbp.Text, _student);
			//    DB.ExecuteNonQuery(sql);
			//}
		}

		private void save_Click(object sender, EventArgs e)
		{
			if (ValidateChildren())
			{
				Save();
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void ctrl_height_Validating(object sender, CancelEventArgs e)
		{
			int h;
			e.Cancel = !int.TryParse(ctrl_height.Text, out h);
			ctrl_height_label.ForeColor = e.Cancel ? Color.Red : Color.Black;
			if (!e.Cancel)
				_student["height"] = h;
		}

		private void ctrl_weight_Validating(object sender, CancelEventArgs e)
		{
			int w;
			e.Cancel = !int.TryParse(ctrl_weight.Text, out w);
			ctrl_weight_label.ForeColor = e.Cancel ? Color.Red : Color.Black;
			if (!e.Cancel)
				_student["weight"] = w;
		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label28_Click(object sender, EventArgs e)
		{

		}

		private void label27_Click(object sender, EventArgs e)
		{

		}

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void label25_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void checkBox14_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}

