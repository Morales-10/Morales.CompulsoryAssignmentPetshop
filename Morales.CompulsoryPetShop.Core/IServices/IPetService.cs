using System.Collections.Generic;
using Morales.CompulsoryPetShop.Core.Models;

namespace Morales.CompulsoryPetShop.Core.IServices
{
    public interface IPetService
    {
        Pet CreatePet(Pet pet);
        Pet RemovePet(int id);
        Pet UpdatePet(Pet pet);
        PetType ReadByPetId(int id);

        List<Pet> ReadAllPets();

    }
}