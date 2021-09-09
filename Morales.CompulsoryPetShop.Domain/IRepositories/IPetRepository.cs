using System.Collections.Generic;
using Morales.CompulsoryPetShop.Core.Models;
using Morales.CompulsoryPetShop.Domain.Services;

namespace Morales.CompulsoryPetShop.Domain.IRepositories
{
    public interface IPetRepository
    {
        Pet CreatePet(Pet pet);
        Pet RemovePet(int id);
        Pet UpdatePet(Pet pet);
        PetType ReadByPetId(int id);

        List<Pet> ReadAllPets();
    }
}