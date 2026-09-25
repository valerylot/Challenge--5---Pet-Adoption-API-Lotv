using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge__5___Pet_Adoption_API_Lotv.Models
{
    public class Pet
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Species {get; set;}
        public string Breed {get; set;}
        public string Age {get; set;}
        public bool IsAdopted {get; set;}
        public bool IsDeleted {get; set;} = false;
    }
}