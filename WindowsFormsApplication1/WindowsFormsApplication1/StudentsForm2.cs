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
		public StudentsForm2()
		{
			InitializeComponent();
		}

		private void StudentsForm2_Load(object sender, EventArgs e)
		{
			ctrl_grade.SelectedIndex = 0;
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
				this.Close();
			}
		}

		private void save_Click(object sender, EventArgs e)
		{
			int h;
			if (!int.TryParse(ctrl_height.Text, out h))
			{
				MessageBox.Show("قد را اصلاح کنید");
				return;
			}
			int w;
			if (!int.TryParse(ctrl_weight.Text, out w))
			{
				MessageBox.Show("وزن را اصلاح کنید");
				return;
			}
			var sql = string.Format("insert into students (grade, height, weight, sbp, dbp) values ({0}, {1}, {2}, {3}, {4})", ctrl_grade.SelectedIndex, h, w, ctrl_sbp.Text, ctrl_dbp.Text);
			DB.ExecuteNonQuery(sql);
		}
	}
}
