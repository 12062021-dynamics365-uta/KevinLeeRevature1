using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness //Worked with Bishal and Shamal
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbAccess;
        private readonly IMapper _mapper;

        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper mapper)//you need a reference to the DbAccess Layer 
        {
            this._mapper = mapper;
            this._dbAccess = Dbaccess;
        }

        //Posting a flavor
        public async Task<Flavor> PostFlavor(string flavorName)
        {
            SqlDataReader dr = await _dbAccess.PostFlavor(flavorName);
            if (dr.Read())
            {
                Flavor f = this._mapper.EntityToFlavor(dr);
                return f;
            }
            else
            {
                return null;
            }
        }

        //Posting a person
        public async Task<Person> PostPerson(string fname, string lname)
        {
            SqlDataReader dr = await _dbAccess.PostPerson(fname, lname);
            if (dr.Read())
            {
                Person p = this._mapper.EntityToPerson(dr);
                return p;
            }
            else
            {
                return null;
            }
        }

        //Geting all of flavor registers by using list.
        public async Task<List<Flavor>> GetAllFlavors()
        {
            SqlDataReader dr = await _dbAccess.GetAllFlavors();
            List<Flavor> f = this._mapper.EntityToListOfFlavors(dr);            
             return f;
            //throw new NotImplementedException();

        }

        //Finding person record with person's first and last
        public async Task<Person> GetPerson(string personFname, string personLname)
        {
            SqlDataReader dr = await _dbAccess.GetPerson(personFname, personLname);
            if (dr.Read())
            {
                Person p = this._mapper.EntityToPerson(dr);
                return p;
            }
            else
            {
                return null;
            }
        }

        //Finding person record with id number
        public async Task<Person> GetPersonAndFlavors(int personId)
        {
            SqlDataReader dr = await _dbAccess.GetPersonAndFlavors(personId);
            if (dr.Read())
            {
                Person p = this._mapper.EntityToPerson(dr);
                return p;
            }
            else
            {
                return null;
            }
        }      
    }
}
