using System.Collections.Generic;
using Morales.CompulsoryPetShop.Core.Models;

namespace Morales.CompulsoryPetShop.Core.IServices
{
    public interface IPetTypeService
    {
        PetType CreatePetType(PetType pet);
        PetType RemovePetType(int id);
        PetType UpdatePetType(PetType pet);
        PetType ReadById(int id);

        List<PetType> ReadAllPetTypes();
    }
}