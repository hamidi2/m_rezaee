using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
	class DB
	{
		static SQLiteConnection conn;
		static public SQLiteConnection Connection
		{
			get { return conn; }
		}

		static DB()
		{
			conn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			conn.Open();
			ExecuteNonQuery(@"
create table if not exists students (
national_id integer primary key, name varchar(40), grade integer,
food_and_drug_allergies varchar(120),
height real, weight real,
sbp integer,  /* blood_pressure_systole */
dbp integer,  /* blood_pressure_diastole */
hb real, fbs real,
blood_group varchar(2), rh boolean,
tsh real, tg integer,
ldl integer, hdl integer,
ast integer, alt integer,
left_eye_problem varchar(120), right_eye_problem varchar(120),
hear_problem varchar(120),
adhd boolean,
adhd_add boolean,
anemia boolean,
anxiety boolean,
behavioral_disorders boolean,
chondromalacia boolean,
depression boolean,
goiter boolean,
dermatitis boolean,
flat_foot boolean,
genu_valgum boolean,
genu_varum boolean,
hair_problem boolean,
nail_problem boolean,
learning_disorders boolean,
obesity boolean,
ocd boolean,  /* OCD: Obsessive Compulsive Disorder */
pediculosis boolean,
personality_disorder boolean,
phobia boolean,
practical_obsession boolean,
schizophrenia boolean,
scoliosis boolean,
others varchar(120),
considerations text
)");
		}

		static public int ExecuteNonQuery(string query)
		{
			var cmd = new SQLiteCommand(query, conn);
			return cmd.ExecuteNonQuery();
		}

		static public object ExecuteScalar(string query)
		{
			var cmd = new SQLiteCommand(query, conn);
			return cmd.ExecuteScalar();
		}

		static public SQLiteDataReader ExecuteReader(string query)
		{
			var cmd = new SQLiteCommand(query, conn);
			return cmd.ExecuteReader();
		}
	}
}

