using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public interface ISweetnSaltyBusinessClass
    {
        Task<Flavor> PostFlavor(string flavorName);
        Task<Person> PostPerson(string personFname, string personLname);
        Task<Person> GetPerson(string personFname, string personLname);
        Task<Person> GetPersonAndFlavors(int personId);
        Task<List<Flavor>> GetAllFlavors();
    }
}
