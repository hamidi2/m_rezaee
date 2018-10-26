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
anxiety boolean,
mi boolean,
dvt boolean,
gout boolean,
ibs boolean,
pancreatitis boolean,
physical_disability boolean,
ihd boolean,
heart_valve_problems boolean,
asthma boolean,
ms boolean,
ibd boolean,
ptsd boolean,
anemia boolean,
stent boolean,
diabetes boolean,
copd boolean,
epilepsy boolean,
fatty_liver boolean,
obsession boolean,
thalassemia boolean,
cabg boolean,
hyperlipidemia boolean,
kidney stone boolean,
tia boolean,
hepatitis boolean,
depression boolean,
malignancy boolean,
malignancy_type varchar(40),
others varchar(120),
surgical_record_and_hospitalization varchar(40),
drugs_used varchar(120),
height integer,
weight integer,
bmi integer,
blood_pressure integer,
blood_group_rh 
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
