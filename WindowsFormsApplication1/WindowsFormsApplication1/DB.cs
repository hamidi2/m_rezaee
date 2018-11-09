using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
	class DB
	{
		static SQLiteConnection dbConn;
		static public SQLiteConnection DBConnection
		{
			get { return dbConn; }
		}

		static DB()
		{
			dbConn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			dbConn.Open();
			//            ExecuteNonQuery(@"create table if not exists teachers (\
			//name varchar(40),\
			//surname varchar(40),\
			//id character(10),\
			//htn boolean,
			//arrhythmia boolean,
			//hypothyroid boolean,
			//prostate_enlargement boolean,
			//cva boolean,
			//bile_duct_problem boolean,
			//anxiety boolean,
			//mi boolean,
			//dvt boolean,
			//gout boolean,
			//ibs boolean,
			//pancreatitis boolean,
			//physical_disability boolean,
			//ihd boolean,
			//heart_valve_problems boolean,
			//asthma boolean,
			//ms boolean,
			//ibd boolean,
			//ptsd boolean,
			//anemia boolean,
			//stent boolean,
			//diabetes boolean,
			//copd boolean,
			//epilepsy boolean,
			//fatty_liver boolean,
			//obsession boolean,
			//thalassemia boolean,
			//cabg boolean,
			//hyperlipidemia boolean,
			//kidney stone boolean,
			//tia boolean,
			//hepatitis boolean,
			//depression boolean,
			//malignancy boolean,
			//malignancy_type varchar(40),
			//others varchar(120),
			//surgical_record_and_hospitalization varchar(40),
			//drugs_used varchar(120),
			//height integer,
			//weight integer,
			//bmi integer,
			//blood_pressure integer,
			//blood_group_rh 
			//            )");
			ExecuteNonQuery("create table if not exists students (" +
				//"id integer primary key autoincrement,"+
				"name varchar(40)," +
				"surname varchar(40)," +
				"national_id character(10)," +
				"grade integer," +
				"food_and_drug_allergies varchar(120)," +
				"height real," +
				"weight real," +
				"sbp integer," +  // blood_pressure_systole
				"dbp integer," +  // blood_pressure_diastole
				"hb real, fbs real, blood_group varchar(2), rh boolean," +
				"tsh real, tg integer, ldl integer, hdl integer," +
				"ast integer, alt integer," +
				"right_eye_refer_desc varchar(120), left_eye_refer_desc varchar(120), hear_problem varchar(120)," +
				"dermatitis boolean, hair_problem boolean, nail_problem boolean, pediculosis boolean," +
				"anemia boolean, goiter boolean," +
				"scoliosis boolean, flat_foot boolean, genu_varum boolean, genu_valgum boolean, chondromalacia boolean, others varchar(120)," +
				"ocd boolean," +  // OCD: Obsessive Compulsive Disorder
				"practical_obsession boolean, adhd boolean, adhd_add boolean, depression boolean, obesity boolean, behavioral_disorders boolean, learning_disorders boolean, anxiety boolean, phobia boolean, personality_disorder boolean, schizophrenia boolean," +
				"considerations text)"
			);
		}

		static public object ExecuteScalar(string query)
		{
			var cmd = new SQLiteCommand(query, dbConn);
			return cmd.ExecuteScalar();
		}

		static public int ExecuteNonQuery(string query)
		{
			var cmd = new SQLiteCommand(query, dbConn);
			return cmd.ExecuteNonQuery();
		}
	}
}

