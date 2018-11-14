using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			var style = tableLayoutPanel1.RowStyles[0];
			style.Height = button1.Height + 6;
			style.SizeType = SizeType.Absolute;
		}
	}
}
