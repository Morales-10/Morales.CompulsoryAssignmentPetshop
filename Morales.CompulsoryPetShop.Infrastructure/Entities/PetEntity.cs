using System;

namespace Morales.CompulsoryPetShop.Infrastructure.Entities
{
    public class PetEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int TypeId { get; set; }
    }
}