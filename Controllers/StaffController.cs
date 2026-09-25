using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Models;
using Challenge__5___Pet_Adoption_API_Lotv.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge__5___Pet_Adoption_API_Lotv.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffServices _staff;

        public StaffController(IStaffServices staff)
        {
            _staff = staff;
        }

        [HttpGet("getall")]
        public ActionResult<List<Staff>> GetAll()
        {
            List<Staff> allStaff = _staff.GetAll();

            return Ok(allStaff);
        }

        [HttpPost("create")]
        public ActionResult<Staff> Create([FromBody] Staff newStaff)
        {
            Staff createdStaff = _staff.Create(newStaff);
            return CreatedAtAction(
                nameof(GetAll),
                createdStaff
            );
        }

        [HttpGet("isworking")]
        public ActionResult<List<Staff>> IsWorking()
        {
            List<Staff> working = _staff.IsWorking();

            return Ok(working);
        }

        [HttpPatch("update/{id}")]
        public ActionResult<bool> UpdateStaff (int id, Staff staff)
        {
            Staff updated = _staff.Update(id, staff);
            if(updated == null)
            {
                return NotFound($"No staff memeber found with ID {id}");
            }
            return NoContent();

        }
    }
}