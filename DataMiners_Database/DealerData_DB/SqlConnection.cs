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
        public static MySqlConnection connection = new MySqlConnection("Server=css475dbinstance.cs0surzhmcrb.us-east-2.rds.amazonaws.com;"
            + " Port=3306; Database=dataminersDealerData; Uid=dataminers475; Pwd=DATAminers;");
        public static MySqlCommand command;
        public static MySqlDataReader dataReader;
    }
}
