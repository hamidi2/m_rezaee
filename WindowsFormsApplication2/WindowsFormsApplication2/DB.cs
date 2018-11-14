using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace WindowsFormsApplication2
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
		}

		static public int ExecuteNonQuery(string query)
		{
			var cmd = new SQLiteCommand(query, dbConn);
			return cmd.ExecuteNonQuery();
		}

		static public object ExecuteScalar(string query)
		{
			var cmd = new SQLiteCommand(query, dbConn);
			return cmd.ExecuteScalar();
		}

		static public SQLiteDataReader ExecuteReader(string query)
		{
			var cmd = new SQLiteCommand(query, dbConn);
			return cmd.ExecuteReader();
		}

	}
}

