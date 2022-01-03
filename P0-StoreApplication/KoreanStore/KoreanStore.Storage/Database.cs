using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace KoreanStore.Storage
{
    internal class Database 
    {
        string query;
        string dbSource = "Data source = LAPTOP-16481HHS\\SQLEXPRESS; initial Catalog = P0 Project; integrated security = true";
        private readonly SqlConnection connection;

        public Database()
        {
            this.connection = new SqlConnection(dbSource);
            connection.Open();
        }
    }
}

