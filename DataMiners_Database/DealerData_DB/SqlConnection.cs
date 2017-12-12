/*
 * Rahil Mehta, Tavi Tenari, Stan Huber, Chayse Summers
 * SqlConnection.cs
 * CSS 475 Database Project
 * 
 * This static class contains the MySQL connection string for the database.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DealerData_DB
{
    class SqlConnection
    {
        public static MySqlConnection connection = new MySqlConnection("server=css475dbinstance.cs0surzhmcrb.us-east-2.rds.amazonaws.com;user id=dataminers475;password=DATAminers;persistsecurityinfo=True;database=dataminersDealerData");
        public static MySqlCommand command;
        public static MySqlDataReader dataReader;
    }
}
