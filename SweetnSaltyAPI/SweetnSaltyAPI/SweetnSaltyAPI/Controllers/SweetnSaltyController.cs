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
            Flavor f = await _businessClass.PostFlavor(flavorName);
            if (f != null)
            {
                return Created($"http:/5001/sweetnsalty/postaflavor/{f.flavorName}" , f);
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
            Person p = await _businessClass.PostPerson(personFname, personLname);
            if (p != null)
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
             Person p = await _businessClass.GetPerson(personFname, personLname);
             if (p != null)
             {
                 return Ok(p);
             }
             else
             {
                 return NotFound();

            }
            //return null;
        }

        [HttpGet]
        [Route("getapersonandflavors/{personId}")]
        public async Task<ActionResult<Person>> GetPersonAndFlavors(int personId)
        {
             Person p = await _businessClass.GetPersonAndFlavors(personId);
             if (p != null)
             {
                 return Ok(p);
             }
             else
             {
                 return NotFound();
            }
            //return null;
        }

        [HttpGet]
        [Route("getlistofflavors")]
        public async Task<ActionResult<Flavor>> GetAllFlavors()
        {
            //return null;
            List<Flavor> f = await _businessClass.GetAllFlavors();
            if (f.Count > 0)
            {
                return Ok(f);
            }
            else
            {
                return null;
            }
        }
    }
}
