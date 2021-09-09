using System.Collections.Generic;
using Morales.CompulsoryPetShop.Core.Models;
using Morales.CompulsoryPetShop.Domain.IRepositories;

namespace Morales.CompulsoryPetShop.Infrastructure.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private static List<PetType> _petTypeTable;

        public PetTypeRepository()
        {
            _petTypeTable = new List<PetType>();

            _petTypeTable.Add(new PetType()
            {
                Id = 1,
                Name = "Cat"
            });

            _petTypeTable.Add(new PetType()
            {
                Id = 2,
                Name = "Dog"
            });
            _petTypeTable.Add(new PetType()
            {
                Id = 3,
                Name = "Bunny"
            });
            _petTypeTable.Add(new PetType()
            {
                Id = 4,
                Name = "Panda"
            });
            _petTypeTable.Add(new PetType()
            {
                Id = 5,
                Name = "Pig"
            });
        }

        public PetType ReadByPetId(int PetEntityTypeId)
        {
            foreach (var petType in _petTypeTable)
            {
                if (petType.Id == PetEntityTypeId)
                {
                    return petType;
                }
            }

            return null;
        }

        public List<PetType> ReadAllPetTypes()
        {
            return _petTypeTable;
        }
    }
}