using Microsoft.AspNetCore.Mvc;
using SweetnSaltyBusiness;
using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SweetnSaltyAPI.Controllers //Worked with Bishal and Shamal
{
    [ApiController]
    [Route("[controller]")]
    public class SweetnSaltyController : ControllerBase
    {
        private readonly ISweetnSaltyBusinessClass _businessClass;
        //constructor
        public SweetnSaltyController(ISweetnSaltyBusinessClass ISweetnSaltyBusinessClass)
        {
            this._businessClass = ISweetnSaltyBusinessClass;
        }


        [HttpPost]
        [Route("postaflavor/{flavorName}")]
        public async Task<ActionResult<Flavor>> PostFlavor(string flavorName)
        {
            Flavor f = await this._businessClass.PostFlavor(flavorName);
            if (f is null)
            {
                return Created($"http:/5001/sweetnsalty/postaflavor/{f.flavorID}" , f);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("postaperson/{personFname}/{personLname}")]
        public async Task<ActionResult<Person>> PostPerson(string personFname, string personLname)
        {
            Person p = await this._businessClass.PostPerson(personFname, personLname);
            if (p is null)
            {
                return Created($"http:/5001/sweetnsalty/postaperson/{p.personID}", p);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getaperson/{personFname}/{personLname}")]
        public async Task<ActionResult<Person>> GetPerson(string personFname, string personLname)
        {
             Person p = await this._businessClass.GetPerson(personFname, personLname);
             if (p is null)
             {
                 return Ok(p);
             }
             else
             {
                 return BadRequest();

            }
            //return null;
        }

        [HttpGet]
        [Route("getapersonandflavors/{personId}")]
        public async Task<ActionResult<Person>> GetPersonAndFlavors(int personId)
        {
             Person p = await this._businessClass.GetPersonAndFlavors(personId);
             if (p is null)
             {
                 return Ok(p);
             }
             else
             {
                 return BadRequest();
            }
            //return null;
        }

        [HttpGet]
        [Route("getlistofflavors")]
        public async Task<ActionResult<Flavor>> GetAllFlavors()
        {
            return null;
           /* List<Flavor> f = await this._businessClass.GetAllFlavors();
            if (f.Count > 0)
            {
                return Ok(f);
            }
            else
            {
                return BadRequest();
            }*/
        }
    }
}
