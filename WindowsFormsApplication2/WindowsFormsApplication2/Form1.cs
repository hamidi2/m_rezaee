using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form1 : Form
	{
		enum FieldType
		{
			invalidType,
			boolean,
			integer,
			real,
			character,
			varchar,
			text,
		}

		static FieldType ToFieldType(string name)
		{
			switch (name)
			{
				case "boolean":
					return FieldType.boolean;
				case "integer":
					return FieldType.integer;
				case "real":
					return FieldType.real;
				case "character":
					return FieldType.character;
				case "varchar":
					return FieldType.varchar;
				case "text":
					return FieldType.text;
				default:
					Debug.Assert(false);
					return FieldType.invalidType;
			}
		}

		class Field
		{
			public string Name { get; set; }
			public FieldType Type { get; set; }
			public int Len { get; set; }
		}

		class Table
		{
			public string Name { get; set; }
			public List<Field> Fields = new List<Field>();
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tableLayoutPanel1.RowStyles[0].Height = label1.Height + 6;
			tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
			tableLayoutPanel1.RowStyles[1].Height = cbTables.Height + 6;
			tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
			var tables = new List<Table>();
			var reader = DB.ExecuteReader("SELECT * FROM sqlite_master where type='table'");
			while (reader.Read())
			{
				var sql = reader["sql"].ToString();
				sql = sql.Replace('(', ' ');
				sql = sql.Replace(")", "");
				sql = sql.Replace(",", " , ");
				sql = sql.Replace("  ", " ");
				var parts = sql.Split(' ');
				var table = new Table();
				var i = 2;
				table.Name = parts[i++];
				while (true)
				{
					var field = new Field();
					field.Name = parts[i++];
					field.Type = ToFieldType(parts[i++]);
					if (i < parts.Length)
					{
						int len;
						var hasLen = int.TryParse(parts[i], out len);
						field.Len = len;
						if (hasLen)
							i++;
					}
					table.Fields.Add(field);
					if (i == parts.Length)
						break;
					i++;
				}
				tables.Add(table);
			}
			cbTables.DataSource = tables;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tables = cbTables.DataSource as List<Table>;
			var table = tables[cbTables.SelectedIndex];
			dataGridView1.DataSource = table.Fields;
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			e.
		}
	}
}

