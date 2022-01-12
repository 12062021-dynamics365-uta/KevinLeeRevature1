using System;
using System.Collections.Generic;

namespace SweetnSaltyModels
{
    public class Person
    {
        public int personID { get; set; }
        public string personFname { get; set; }
        public string personLname {get; set;}
        public List<Flavor> personFalvor { get; set; }
    }
}
