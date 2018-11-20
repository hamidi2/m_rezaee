namespace WindowsFormsApplication1
{
	partial class StudentsForm2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.ctrl_sbp = new System.Windows.Forms.TextBox();
			this.ctrl_dbp = new System.Windows.Forms.TextBox();
			this.ctrl_bmi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ctrl_weight = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ctrl_height = new System.Windows.Forms.TextBox();
			this.ctrl_food_and_drug_allergies = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ctrl_weight_label = new System.Windows.Forms.Label();
			this.ctrl_height_label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ctrl_grade = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ctrl_save = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabControl1.RightToLeftLayout = true;
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1007, 569);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.ctrl_sbp);
			this.tabPage1.Controls.Add(this.ctrl_dbp);
			this.tabPage1.Controls.Add(this.ctrl_bmi);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.ctrl_weight);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.ctrl_height);
			this.tabPage1.Controls.Add(this.ctrl_food_and_drug_allergies);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.ctrl_weight_label);
			this.tabPage1.Controls.Add(this.ctrl_height_label);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.ctrl_grade);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(999, 543);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "صفحه اول";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// ctrl_sbp
			// 
			this.ctrl_sbp.Location = new System.Drawing.Point(713, 203);
			this.ctrl_sbp.Name = "ctrl_sbp";
			this.ctrl_sbp.Size = new System.Drawing.Size(100, 20);
			this.ctrl_sbp.TabIndex = 15;
			// 
			// ctrl_dbp
			// 
			this.ctrl_dbp.Location = new System.Drawing.Point(573, 203);
			this.ctrl_dbp.Name = "ctrl_dbp";
			this.ctrl_dbp.Size = new System.Drawing.Size(100, 20);
			this.ctrl_dbp.TabIndex = 14;
			// 
			// ctrl_bmi
			// 
			this.ctrl_bmi.Location = new System.Drawing.Point(418, 171);
			this.ctrl_bmi.Name = "ctrl_bmi";
			this.ctrl_bmi.Size = new System.Drawing.Size(100, 20);
			this.ctrl_bmi.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(588, 174);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "کیلوگرم";
			// 
			// ctrl_weight
			// 
			this.ctrl_weight.Location = new System.Drawing.Point(638, 171);
			this.ctrl_weight.Name = "ctrl_weight";
			this.ctrl_weight.Size = new System.Drawing.Size(100, 20);
			this.ctrl_weight.TabIndex = 11;
			this.ctrl_weight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.ctrl_weight.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_weight_Validating);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(803, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "سانتی متر";
			// 
			// ctrl_height
			// 
			this.ctrl_height.Location = new System.Drawing.Point(864, 171);
			this.ctrl_height.Name = "ctrl_height";
			this.ctrl_height.Size = new System.Drawing.Size(100, 20);
			this.ctrl_height.TabIndex = 9;
			this.ctrl_height.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.ctrl_height.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_height_Validating);
			// 
			// ctrl_food_and_drug_allergies
			// 
			this.ctrl_food_and_drug_allergies.Location = new System.Drawing.Point(8, 68);
			this.ctrl_food_and_drug_allergies.Multiline = true;
			this.ctrl_food_and_drug_allergies.Name = "ctrl_food_and_drug_allergies";
			this.ctrl_food_and_drug_allergies.Size = new System.Drawing.Size(985, 89);
			this.ctrl_food_and_drug_allergies.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(679, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "روی";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(819, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(172, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "فشار خون (بر حسب میلی لیتر جیوه):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(524, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "BMI:";
			// 
			// ctrl_weight_label
			// 
			this.ctrl_weight_label.AutoSize = true;
			this.ctrl_weight_label.Location = new System.Drawing.Point(744, 174);
			this.ctrl_weight_label.Name = "ctrl_weight_label";
			this.ctrl_weight_label.Size = new System.Drawing.Size(28, 13);
			this.ctrl_weight_label.TabIndex = 4;
			this.ctrl_weight_label.Text = "وزن:";
			// 
			// ctrl_height_label
			// 
			this.ctrl_height_label.AutoSize = true;
			this.ctrl_height_label.Location = new System.Drawing.Point(970, 174);
			this.ctrl_height_label.Name = "ctrl_height_label";
			this.ctrl_height_label.Size = new System.Drawing.Size(21, 13);
			this.ctrl_height_label.TabIndex = 3;
			this.ctrl_height_label.Text = "قد:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(847, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "حساسیتهای غذایی و دارویی:";
			// 
			// ctrl_grade
			// 
			this.ctrl_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ctrl_grade.FormattingEnabled = true;
			this.ctrl_grade.Items.AddRange(new object[] {
            "اول دبستان",
            "دوم دبستان",
            "سوم دبستان",
            "چهارم دبستان",
            "پنجم دبستان",
            "ششم دبستان",
            "اول دبیرستان",
            "دوم دبیرستان",
            "سوم دبیرستان",
            "چهارم دبیرستان",
            "پنجم دبیرستان",
            "ششم دبیرستان"});
			this.ctrl_grade.Location = new System.Drawing.Point(787, 16);
			this.ctrl_grade.Name = "ctrl_grade";
			this.ctrl_grade.Size = new System.Drawing.Size(121, 21);
			this.ctrl_grade.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(932, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ورودی پایه";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(999, 543);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "صفحه دوم";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ctrl_save
			// 
			this.ctrl_save.Location = new System.Drawing.Point(12, 578);
			this.ctrl_save.Name = "ctrl_save";
			this.ctrl_save.Size = new System.Drawing.Size(75, 23);
			this.ctrl_save.TabIndex = 1;
			this.ctrl_save.Text = "ذخیره";
			this.ctrl_save.UseVisualStyleBackColor = true;
			this.ctrl_save.Click += new System.EventHandler(this.save_Click);
			// 
			// StudentsForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 613);
			this.Controls.Add(this.ctrl_save);
			this.Controls.Add(this.tabControl1);
			this.KeyPreview = true;
			this.Name = "StudentsForm2";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "فرم دانش آموزان";
			this.Load += new System.EventHandler(this.StudentsForm2_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentsForm2_KeyDown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ComboBox ctrl_grade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox ctrl_sbp;
		private System.Windows.Forms.TextBox ctrl_dbp;
		private System.Windows.Forms.TextBox ctrl_bmi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ctrl_weight;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox ctrl_height;
		private System.Windows.Forms.TextBox ctrl_food_and_drug_allergies;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ctrl_weight_label;
		private System.Windows.Forms.Label ctrl_height_label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ctrl_save;
	}
}

