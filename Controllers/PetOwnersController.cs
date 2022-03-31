using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;

        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable <PetOwner> GetPets() {
            Console.WriteLine("inside get PetOwners");
            // return new List<PetOwner>();
            return _context.PetOwnersTable;
        }

        [HttpGet("{id}")]
        public ActionResult <PetOwner> getById(int id) {
            PetOwner petowner = _context.PetOwnersTable.SingleOrDefault(petowner => petowner.Id == id);
            if (petowner is null) {
                return NotFound();
            }
            return petowner; 
        }

        [HttpPost]
        public IActionResult Post(PetOwner petowner)
        {

            _context.Add(petowner);
            _context.SaveChanges(); 
            return CreatedAtAction(nameof(Post),
            new{id=petowner.Id}, petowner);
        }  

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            PetOwner petowner = _context.PetOwnersTable.SingleOrDefault(p => p.Id == id);

            if(petowner is null){
                return NotFound();
            }

            _context.PetOwnersTable.Remove(petowner);
            _context.SaveChanges();

            return NoContent();
        } 
    }
}
