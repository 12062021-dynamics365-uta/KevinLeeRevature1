using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness //Worked with Bishal and Shamal
{
    public class Mapper : IMapper
    {
        public Flavor EntityToFlavor(SqlDataReader dr)
        {
            return new Flavor()
            {
                flavorID = dr.GetInt32(0),
                flavorName = dr[1].ToString(),
            
            };
        }

        public Person EntityToListOfFlavors(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public Person EntityToPerson(SqlDataReader dr)
        {
            return new Person()
            {
                personID = dr.GetInt32(0),
                personFname = dr[1].ToString(),
                personLname = dr[2].ToString(),
            };
        }

        public Person EntityToPersonFlavor(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
