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
		private DataRow _student;

		public StudentsForm2(DataRow student)
		{
			InitializeComponent();
			_student = student;
		}

		bool GetBool(string fieldName)
		{
			return (bool)(_student[fieldName] is DBNull ? false : _student[fieldName]);
		}

		int GetInt(string fieldName)
		{
			return (int)(_student[fieldName] is DBNull ? 0 : _student[fieldName]);
		}

		string GetString(string fieldName)
		{
			return (string)(_student[fieldName] is DBNull ? "" : _student[fieldName]);
		}

		string GetStringFromReal(string fieldName)
		{
			return _student[fieldName] is DBNull ? "" : _student[fieldName].ToString();
		}

		private void StudentsForm2_Load(object sender, EventArgs e)
		{
			ctrl_name.Text = GetString("name");
			ctrl_national_id.Text = string.Format("{0}", _student["national_id"]);
			ctrl_grade.SelectedIndex = GetInt("grade");
			ctrl_food_and_drug_allergies.Text = GetString("food_and_drug_allergies");
			ctrl_height.Text = GetStringFromReal("height");
			ctrl_weight.Text = GetStringFromReal("weight");
			ctrl_sbp.Text = GetString("sbp");
			ctrl_dbp.Text = GetString("dbp");
			ctrl_bg.Text = GetString("blood_group") + (GetInt("rh") == 0 ? "-" : "+");
			ctrl_hb.Text = GetStringFromReal("hb");
			ctrl_fbs.Text = GetStringFromReal("fbs");
			ctrl_tsh.Text = GetStringFromReal("tsh");
			ctrl_tg.Text = GetString("tg");
			ctrl_ldl.Text = GetString("ldl");
			ctrl_hdl.Text = GetString("hdl");
			ctrl_ast.Text = GetString("ast");
			ctrl_alt.Text = GetString("alt");
			ctrl_left_eye_problem.Text = GetString("left_eye_problem");
			ctrl_right_eye_desc.Text = GetString("right_eye_problem");
			ctrl_hear_desc.Text = GetString("hear_problem");
			ctrl_dermatitis.Checked = GetBool("dermatitis");
			ctrl_hair_problem.Checked = GetBool("hair_problem");
			ctrl_nail_problem.Checked = GetBool("nail_problem");
			ctrl_pediculosis.Checked = GetBool("pediculosis");
			ctrl_anemia.Checked = GetBool("anemia");
			ctrl_goiter.Checked = GetBool("goiter");
			ctrl_scoliosis.Checked = GetBool("scoliosis");
			ctrl_flat_foot.Checked = GetBool("flat_foot");
			ctrl_genu_varum.Checked = GetBool("genu_varum");
			ctrl_genu_valgum.Checked = GetBool("genu_valgum");
			ctrl_chondromalacia.Checked = GetBool("chondromalacia");
			ctrl_ocd.Checked = GetBool("ocd");
			ctrl_practical_obsession.Checked = GetBool("practical_obsession");
			ctrl_adhd.Checked = GetBool("adhd");
			ctrl_adhd_add.Checked = GetBool("adhd_add");
			ctrl_depression.Checked = GetBool("depression");
			ctrl_obesity.Checked = GetBool("obesity");
			ctrl_behavioral_disorders.Checked = GetBool("behavioral_disorders");
			ctrl_learning_disorders.Checked = GetBool("learning_disorders");
			ctrl_anxiety.Checked = GetBool("anxiety");
			ctrl_phobia.Checked = GetBool("phobia");
			ctrl_personality_disorder.Checked = GetBool("personality_disorder");
			ctrl_schizophrenia.Checked = GetBool("schizophrenia");
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

		private void save_Click(object sender, EventArgs e)
		{
			if (ValidateChildren())
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void ctrl_height_Validating(object sender, CancelEventArgs e)
		{
			int h;
			e.Cancel = !int.TryParse(ctrl_height.Text, out h);
			lbl_height.ForeColor = e.Cancel ? Color.Red : Color.Black;
			if (!e.Cancel)
				_student["height"] = h;
		}

		private void ctrl_weight_Validating(object sender, CancelEventArgs e)
		{
			int w;
			e.Cancel = !int.TryParse(ctrl_weight.Text, out w);
			lbl_weight.ForeColor = e.Cancel ? Color.Red : Color.Black;
			if (!e.Cancel)
				_student["weight"] = w;
		}

		private void ctrl_right_eye_desc_TextChanged(object sender, EventArgs e)
		{
			ctrl_right_eye_problem.Checked = ctrl_right_eye_desc.Text.Length == 0;
		}

		private void ctrl_left_eye_desc_TextChanged(object sender, EventArgs e)
		{
			ctrl_left_eye_problem.Checked = label3.Text.Length == 0;
		}

		private void ctrl_hear_desc_TextChanged(object sender, EventArgs e)
		{
			ctrl_hear_problem.Checked = ctrl_hear_desc.Text.Length == 0;
		}

		private void ctrl_name_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			if (ctrl_name.Text.IndexOf(" ") == -1)
				return;
			if (ctrl_name.Text.Length < 3)
				return;
			e.Cancel = false;
		}

		private void ctrl_national_id_Validating(object sender, CancelEventArgs e)
		{
			if ((sender as Control).Text.Length == 0)
			//if (ctrl_national_id.Text.Length == 0)
				e.Cancel = true;
		}

		private void ctrl_sbp_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_dbp_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_bg_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_hb_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_fbs_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_tsh_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_tg_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_ldl_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_hdl_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_ldl_sdl_ratio_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_ast_Validating(object sender, CancelEventArgs e)
		{

		}

		private void ctrl_alt_Validating(object sender, CancelEventArgs e)
		{

		}

	}
}

