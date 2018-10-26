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
            ExecuteNonQuery(@"create table if not exists teachers (\
name varchar(40),\
surname varchar(40),\
id character(10),\
htn boolean,
arrhythmia boolean,
hypothyroid boolean,
prostate_enlargement boolean,
cva boolean,
bile_duct_problem boolean,
anxiety
mi
dvt
gout
ibs
pancreatitis
physical_disability
ihd
heart_valve_problems
asthma
ms
ibd
ptsd
anemia
stent
diabetes
copd
epilepsy
fatty_liver

            )");
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
