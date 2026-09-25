using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge__5___Pet_Adoption_API_Lotv.Models;

namespace Challenge__5___Pet_Adoption_API_Lotv.Services
{
    public interface IPetServices
    {
        List<Pet> GetAll();
        Pet Create(Pet newPet);
        Pet GetById(int id);
        Pet Update(int id, Pet pet);
        List<Pet> IsAdopted();
        Pet IsDeleted(int id, Pet pet);
    }
}