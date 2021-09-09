using System;

namespace Morales.CompulsoryPetShop.Core.Models
{
    public class Pet
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Birthdate} - {SoldDate} - {Color} - {Price} - {Type.Name}";
        }
    }
}