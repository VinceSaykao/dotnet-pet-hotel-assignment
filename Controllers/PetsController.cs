using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetsController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        // [HttpGet]
        // public IEnumerable<Pet> GetPets() {
        //     // return new List<Pet>();
        //     Console.WriteLine("get all bakers");
        //     return _context.PetsTable;
        // }

        //   [HttpGet]
        // // get all pet route
        // public IEnumerable<Pet> GetPets()
        // {
        //     return _context.PetsTable
        //     .Include(PetOwner=> PetOwner.ownedBy);
        // }

        [HttpGet]
        public IEnumerable <Pet> GetAllPets() {
            Console.WriteLine("inside get Pets");
            // return new List<Pet>();
            return _context.PetsTable;
        }

        
        [HttpGet("{id}")]
        public ActionResult <Pet> getById(int id ) {
            Pet pet = _context.PetsTable.SingleOrDefault(pet => pet.Id == id);
            // Pet pet = _context.PetsTable.SingleOrDefault(pet => pet.Id == id);

            if (pet is null){
                return NotFound();
            }
            return pet; 
        }

        [HttpPost]
        public IActionResult Create(Pet pet)
        {
            _context.Add(pet);
            _context.SaveChanges();
            return CreateAtAction(nameof(Create),
            new{id=pet.Id}, pet);
        }

        // [HttpGet]
        // public IEnumerable <PetOwner> GetPets() {
        //     Console.WriteLine("inside get PetOwners");
        //     // return new List<PetOwner>();
        //     return _context.PetOwnersTable;
        // }

        // [HttpGet]
        // [Route("test")]
        // public IEnumerable<Pet> GetPets() {
        //     PetOwner blaine = new PetOwner{
        //         name = "Blaine"
        //     };

        //     Pet newPet1 = new Pet {
        //         name = "Big Dog",
        //         petOwner = blaine,
        //         color = PetColorType.Black,
        //         breed = PetBreedType.Poodle,
        //     };

        //     Pet newPet2 = new Pet {
        //         name = "Little Dog",
        //         petOwner = blaine,
        //         color = PetColorType.Golden,
        //         breed = PetBreedType.Labrador,
        //     };

        //     return new List<Pet>{ newPet1, newPet2};
        // }



    }
}
