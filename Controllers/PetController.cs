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
    [Route("api/[controller]")] // /api/pet
    public class PetController : ControllerBase
    {
        private readonly IPetServices _pet;
        //CONSTRUCTOR
        public PetController(IPetServices pet)
        {
            _pet = pet;
        }

        [HttpGet("getall")]
        public ActionResult<List<Pet>> GetAll()
        {
            List<Pet> pets = _pet.GetAll();

            return Ok(pets);
        }

        [HttpPost("create")]
        public ActionResult<Pet> Create([FromBody] Pet newPet)
        {
            Pet createdPet = _pet.Create(newPet);
            return CreatedAtAction(
                nameof(GetAll),
                createdPet
            );
        }

        [HttpGet("getbyid/{id}")]
        public ActionResult<Pet> GetById(int id)
        {
            Pet idPet = _pet.GetById(id);

            if(idPet == null)
            {
                return NotFound($"No pet found with ID {id}");
            }
            return Ok(idPet);
        }

        [HttpPatch("update/{id}")]
        public ActionResult<bool> UpdatePet(int id, Pet pet)
        {
            Pet updated = _pet.Update(id, pet);

            if(updated == null)
            {
                return NotFound($"No pet found with ID {id}");
            }
            return NoContent();

        }

        [HttpPatch("adopt/{id}")]
        public ActionResult<Pet> AdoptPet(int id)
        {
            Pet adopted = _pet.IsAdopted(id);

            if(adopted == null)
            {
                return NotFound($"No pet found with ID {id}");
            }
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<Pet> DeletePet(int id)
        {
            Pet deleted = _pet.IsDeleted(id);

            if(deleted == null)
            {
                return NotFound($"No pet found with ID {id}");
            }
            return NoContent();
        }
    }
}