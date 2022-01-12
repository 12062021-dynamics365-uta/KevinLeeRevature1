using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public interface ISweetnSaltyDbAccessClass
    {
        Task<SqlDataReader> PostFlavor(string flavorName);
        Task<SqlDataReader> PostPerson(string personFname, string personLname);
        Task<SqlDataReader> GetPerson(string personFname, string personLname);
        Task<SqlDataReader> GetPersonAndFlavors(int personId);
        Task<SqlDataReader> GetAllFlavors();
    }
}
