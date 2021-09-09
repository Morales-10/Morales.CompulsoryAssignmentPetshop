using System;
using System.Collections.Generic;
using System.Linq;
using Morales.CompulsoryPetShop.Core.Models;
using Morales.CompulsoryPetShop.Domain.IRepositories;
using Morales.CompulsoryPetShop.Infrastructure.Converters;
using Morales.CompulsoryPetShop.Infrastructure.Entities;

namespace Morales.CompulsoryPetShop.Infrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        private static List<PetEntity> _petTable = new List<PetEntity>();
        private List<PetType> _petTypes = new PetTypeRepository().ReadAllPetTypes();
        private static int _id = 1;
        private readonly PetConverter _petConverter;

        public PetRepository()
        {
            CreatePet(new Pet()
            {
                Name = "Anna",
                Type = _petTypes[1],
                Color = "Black",
                Price = 300000,
                Birthdate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            
            CreatePet(new Pet()
            {
                Name = "Robert",
                Type = _petTypes[2],
                Color = "White",
                Price = 240000,
                Birthdate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            {
                Name = "Adriana",
                Type = _petTypes[3],
                Color = "Red",
                Price = 540000,
                Birthdate = DateTime.Now,
                SoldDate = DateTime.Now
            });
            CreatePet(new Pet()
            {
                Name = "Oskar",
                Type = _petTypes[4],
                Color = "Blue",
                Price = 230000,
                Birthdate = DateTime.Now,
                SoldDate = DateTime.Now
            });
        }
        
        public Pet CreatePet(Pet pet)
        {
            var PetEntity = _petConverter.Convert(pet);
            PetEntity.Id = _id++;
            _petTable.Add(PetEntity);
            return _petConverter.Convert(PetEntity);
        }

        public List<Pet> ReadAllPets()
        {
            var listOfPets = new List<Pet>();
            foreach (var pet in _petTable)
            {
                listOfPets.Add(_petConverter.Convert(pet));
            }

            return listOfPets;
        }

          public Pet ReadByPetId(int id)
                {
                    foreach (var petEntity in _petTable)
                    {
                        if (petEntity.Id == id)
                        {
                            return _petConverter.Convert(petEntity);
                        }
                    }
        
                    return null;
                }
          
        public Pet RemovePet(int id)
        {
            var pet = ReadByPetId(id);
            _petTable.Remove(_petTable.FirstOrDefault(p => p.Id == id));
            return pet;
        }

        public Pet UpdatePet(Pet pet)
        {
            var petOld = _petTable.FirstOrDefault(p => p.Id == pet.Id);
            if (petOld != null)
            {
                petOld.Name = pet.Name;
                petOld.Color = pet.Color;
                petOld.Price = pet.Price;
                petOld.BirthDate = pet.Birthdate;
                petOld.SoldDate = pet.SoldDate;
                petOld.TypeId = pet.Type.Id;
            }

            return null;
        }
    }
    
}