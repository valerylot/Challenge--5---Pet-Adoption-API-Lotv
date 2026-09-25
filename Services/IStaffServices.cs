using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Models;

namespace Challenge__5___Pet_Adoption_API_Lotv.Services
{
    public interface IStaffServices
    {
        List<Staff> GetAll();
        Staff Create (Staff newStaff);
        List<Staff> IsWorking ();
        Staff Update (int id, Staff changes);
    }
}