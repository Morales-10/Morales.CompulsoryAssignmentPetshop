using System.Collections.Generic;
using Morales.CompulsoryPetShop.Core.Models;

namespace Morales.CompulsoryPetShop.Domain.IRepositories
{
    public interface IPetTypeRepository
    {
        PetType ReadByPetId(int PetEntityTypeId);

        List<PetType> ReadAllPetTypes();
    }
}