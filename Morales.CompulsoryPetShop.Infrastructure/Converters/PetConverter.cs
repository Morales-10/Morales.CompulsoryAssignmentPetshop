using Morales.CompulsoryPetShop.Core.Models;
using Morales.CompulsoryPetShop.Domain.IRepositories;
using Morales.CompulsoryPetShop.Infrastructure.Entities;
using Morales.CompulsoryPetShop.Infrastructure.Repositories;

namespace Morales.CompulsoryPetShop.Infrastructure.Converters
{
    public class PetConverter
    {
        private IPetRepository _petTypeRepo = new PetRepository();

        public PetEntity Convert(Pet pet)
        {
            return new PetEntity()
            {
                Id = pet.Id,
                Name = pet.Name,
                TypeId = pet.Type.Id,
                Color = pet.Color,
                Price = pet.Price,
                BirthDate = pet.Birthdate,
                SoldDate = pet.SoldDate
            };
        }

        public Pet Convert(PetEntity petEntity)
        {
            return new Pet()
            {
                Id = petEntity.Id,
                Name = petEntity.Name,
                Color = petEntity.Color,
                Price = petEntity.Price,
                Birthdate = petEntity.BirthDate,
                SoldDate = petEntity.SoldDate,
                Type = _petTypeRepo.ReadByPetId(petEntity.TypeId)
            };
        }
    }
}