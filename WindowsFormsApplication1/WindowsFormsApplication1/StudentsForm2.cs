using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
			ctrl_national_id.Text = string.Format("{0:D10}", _student["national_id"]);
			ctrl_grade.SelectedIndex = GetInt("grade");
			ctrl_food_and_drug_allergies.Text = GetString("food_and_drug_allergies");
			ctrl_height.Text = GetStringFromReal("height");
			ctrl_weight.Text = GetStringFromReal("weight");
			ctrl_sbp.Text = GetString("sbp");
			ctrl_dbp.Text = GetString("dbp");
			ctrl_bg.Text = GetString("bg") + (GetInt("rh") == 0 ? "-" : "+");
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

		#region validating

		enum FieldType
		{
			Int,
			BloodGroup,
		}

		bool ValidateControl(Control ctrl, Control lbl, string fieldName, FieldType fieldType)
		{
			var isValid = false;
			switch (fieldType)
			{
				case FieldType.Int:
					int value;
					if (!int.TryParse(ctrl.Text, out value))
						break;
					_student[fieldName] = value;
					isValid = true;
					break;
				case FieldType.BloodGroup:
					var text = ctrl.Text;
					if (text.Length < 2 || text.Length > 3)
						break;
					if (!Regex.IsMatch(text, "[+-]$"))
						break;
					var len = text.Length;
					var rh = text.Substring(len - 1) == "+";
					text = text.Substring(0, len - 1);
					var bg = text == "O" ? 0 : text == "A" ? 1 : text == "B" ? 2 : text == "AB" ? 3 : -1;
					if (bg == -1)
						break;
					_student["bg"] = bg;
					_student["rh"] = rh;
					isValid = true;
					break;
			}
			lbl.ForeColor = isValid ? Color.Black : Color.Red;
			return isValid;
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
			e.Cancel = !ValidateControl(ctrl_national_id, lbl_national_id, "national_id", FieldType.Int);
		}

		private void ctrl_height_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_height, lbl_height, "height", FieldType.Int);
		}

		private void ctrl_weight_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_weight, lbl_weight, "weight", FieldType.Int);
		}

		private void ctrl_sbp_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_sbp, lbl_bp, "sbp", FieldType.Int);
		}

		private void ctrl_dbp_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_dbp, lbl_bp, "dbp", FieldType.Int);
		}

		private void ctrl_bg_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_bg, lbl_bg, "bg", FieldType.BloodGroup);
		}

		private void ctrl_hb_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_hb, lbl_hb, "hb", FieldType.Int);
		}

		private void ctrl_fbs_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_fbs, lbl_fbs, "fbs", FieldType.Int);
		}

		private void ctrl_tsh_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_tsh, lbl_tsh, "tsh", FieldType.Int);
		}

		private void ctrl_tg_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_tg, lbl_tg, "tg", FieldType.Int);
		}

		private void ctrl_ldl_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_ldl, lbl_ldl, "ldl", FieldType.Int);
		}

		private void ctrl_hdl_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_hdl, lbl_hdl, "hdl", FieldType.Int);
		}

		private void ctrl_ast_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_ast, lbl_ast, "ast", FieldType.Int);
		}

		private void ctrl_alt_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = !ValidateControl(ctrl_alt, lbl_alt, "alt", FieldType.Int);
		}

		#endregion

	}
}

