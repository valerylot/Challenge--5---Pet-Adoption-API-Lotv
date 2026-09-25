using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge__5___Pet_Adoption_API_Lotv.Models
{
    public class Staff
    {
        public int Id {get; set;}
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public bool IsWorking {get; set;} = false;
        public string Salary {get; set;} = string.Empty;
        public string JobPosition {get; set;} = string.Empty;
    }
}