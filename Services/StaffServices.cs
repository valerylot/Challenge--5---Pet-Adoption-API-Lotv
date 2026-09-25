using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Data;
using Challenge__5___Pet_Adoption_API_Lotv.Models;

namespace Challenge__5___Pet_Adoption_API_Lotv.Services
{
    public class StaffServices : IStaffServices
    {
        private AppDbContext _db;

        public StaffServices(AppDbContext db)
        {
            _db = db;
        }

        public List<Staff> GetAll()
        {
            return _db.Staff.ToList();
        }

        public Staff Create(Staff newStaff)
        {
            newStaff.Id = 0;

            _db.Staff.Add(newStaff);
            _db.SaveChanges();
            return newStaff;
        }

        public List<Staff> IsWorking()
        {
            IEnumerable<Staff> working = _db.Staff;
            working = working.Where(s => s.IsWorking == true);

            return working.ToList();
        }

        public Staff Update(int id, Staff staff)
        {
            Staff? exists = _db.Staff.Find(id);

            if(exists == null)
            {
                return null;
            }

            if(string.IsNullOrWhiteSpace(staff.Salary) == false)
            {
                exists.Salary = staff.Salary;
            }

            if(string.IsNullOrWhiteSpace(staff.JobPosition) == false)
            {
                exists.JobPosition = staff.JobPosition;
            }

            _db.SaveChanges();
            return exists;
        }
    }
}