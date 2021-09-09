
using Microsoft.Extensions.DependencyInjection;
using Morales.CompulsoryPetShop.Core.IServices;
using Morales.CompulsoryPetShop.Domain.IRepositories;
using Morales.CompulsoryPetShop.Domain.Services;
using Morales.CompulsoryPetShop.Infrastructure.Repositories;

namespace Morales.CompulsoryPetShop.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetTypeRepository, PetTypeRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPetTypeService, PetTypeService>(); 
            
            
            var serviceProvider = serviceCollection.BuildServiceProvider();
            
            IPetRepository petRepository = new PetRepository();
            IPetTypeRepository petTypeRepository = new PetTypeRepository();
            IPetService petService = new PetService(petRepository);
            
            var menu = new Menu(petService, petTypeRepository);
            menu.Start();
        }
    }
}