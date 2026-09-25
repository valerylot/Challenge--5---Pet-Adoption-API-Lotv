using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Data;
using Challenge__5___Pet_Adoption_API_Lotv.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge__5___Pet_Adoption_API_Lotv.Services
{
    public class PetServices : IPetServices
    {
        //this is Dependency injection
        private AppDbContext _db;

        //CONSTRUCTOR same name as class
        public PetServices(AppDbContext db)
        {
            _db = db;
        }

        public List<Pet> GetAll()
        {
            IEnumerable<Pet> result = _db.Pets;

            result = result.Where(g => g.IsDeleted == false);

            return result.ToList();
            
        }


        public Pet Create(Pet newPet)
        {
            newPet.Id = 0;

            _db.Pets.Add(newPet);

            _db.SaveChanges();

            return newPet;
        }

        public Pet GetById(int id)
        {
            Pet? idPet = _db.Pets.FirstOrDefault(p => p.Id == id);

            return idPet;
        }

        public Pet Update(int id, Pet pet)
        {
            Pet? existing = _db.Pets.Find(id);

            if(existing == null)
            {
                return null;
            }

            if(string.IsNullOrWhiteSpace(pet.Name) == false)
            {
                existing.Name = pet.Name;
            }
            if(string.IsNullOrWhiteSpace(pet.Species) == false)
            {
                existing.Species = pet.Species;
            }
            if(string.IsNullOrWhiteSpace(pet.Breed) == false)
            {
                existing.Breed = pet.Breed;
            }
            if(string.IsNullOrWhiteSpace(pet.Age) == false)
            {
                existing.Age = pet.Age;
            }
            if(pet.IsAdopted == false)
            {
                existing.IsAdopted = pet.IsAdopted;
            }
            if(pet.IsDeleted == false)
            {
                existing.IsDeleted = pet.IsDeleted;
            }

            _db.SaveChanges();

            return existing;
        }

        public List<Pet> IsAdopted()
        {
            IEnumerable<Pet> adopted = _db.Pets;

            adopted = adopted.Where(p => p.IsAdopted == false);

            return adopted.ToList();
        }

        public Pet IsDeleted(int id, Pet pet)
        {
            Pet? deleted = _db.Pets.Find(id);

            if(pet.IsDeleted == false)
            {
                return null;
            }
            if(pet.IsDeleted == true)
            {
                deleted.IsDeleted = pet.IsDeleted;
            }

            _db.SaveChanges();

            return deleted;
        }
    }
}