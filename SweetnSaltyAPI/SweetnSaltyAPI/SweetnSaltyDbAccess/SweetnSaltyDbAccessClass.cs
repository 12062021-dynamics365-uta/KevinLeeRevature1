using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess //Worked with Bishal and Shamal
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data source = LAPTOP-16481HHS\\SQLEXPRESS; initial Catalog = SweetnSalty; integrated security = true";            
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(str);
            _con.Open();
        }

        public async Task<SqlDataReader> PostFlavor(string flavorName)
        {
            string sqlQuery = $"INSERT INTO Flavor VALUES (@flavorName);";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {
                cmd.Parameters.AddWithValue("@flavorName", flavorName);
                
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavor ORDER BY flavorID DESC";
                    using (SqlCommand cmd1 = new SqlCommand(retrieveFlavor, _con))
                    {                        

                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There is an exception in SweetnSaltyBusinessClass.PostFlavor{ex}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> PostPerson(string personFname, string personLname)
        {
            string sqlQuery = $"INSERT INTO Person VALUES (@personFname, @personLname)";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {
                cmd.Parameters.AddWithValue("@personFname", personFname);
                cmd.Parameters.AddWithValue("@personLname", personLname);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrievePerson = "SELECT TOP 1 * FROM Person ORDER BY personID DESC";
                    using (SqlCommand cmd1 = new SqlCommand(retrievePerson, _con))
                    {

                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There is an exception in SweetnSaltyBusinessClass.PostPerson{ex}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> GetAllFlavors()
        {
            string sqlQuery = "SELECT * FROM Flavor;";
            using (SqlCommand cmd1 = new SqlCommand(sqlQuery, _con))
            {
                SqlDataReader dr = cmd1.ExecuteReader();
                return dr;
            }
            
        }

        public async Task<SqlDataReader> GetPerson(string personFname, string personLname)
        {
            string sqlQuery = $"SELECT * FROM Person WHERE personFname = @personFname AND personLname = @personLname";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {
                cmd.Parameters.AddWithValue("@personFname", personFname);
                cmd.Parameters.AddWithValue("@personLname", personLname);
                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                return dr;
            }
        }

            public async Task<SqlDataReader> GetPersonAndFlavors(int personId)
            {
            string sqlQuery = $"SELECT Person.personId, Person.personFname, Person.personLname FROM Person INNER JOIN ON" 
                + $" Flavor.flavorId = Person.personId";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
            {
                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                return dr;
            }
        }
        
    }//EoC
}//EoN
