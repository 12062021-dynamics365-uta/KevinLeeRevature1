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

        public List<Flavor> EntityToListOfFlavors(SqlDataReader dr)
        {
            List<Flavor> flavors = new List<Flavor>();
            while (dr.Read())
            {
                Flavor f = new Flavor()
                {
                    flavorID = dr.GetInt32(0),
                    flavorName = dr.GetString(1),
                };
                flavors.Add(f);
            }
            return flavors;
           // throw new NotImplementedException();
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
            Person p = new Person();
              List<Flavor> f = new List<Flavor>();
            do
            {
                Flavor flavor = new Flavor()
                {
                    flavorID = dr.GetInt32(3),
                    flavorName = dr.GetString(4),
                };
                f.Add(flavor);
                p = new Person()
                {
                    personID = dr.GetInt32(0),
                    personFname = dr.GetString(1),
                    personLname = dr.GetString(2),

                };
            } while (dr.Read());
            throw new NotImplementedException();
        }
    }
}
