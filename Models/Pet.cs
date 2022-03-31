using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType 
    {
        Shiba_Inu,
        German_Shepard,
        Poodle,
        Bull_Dog,
        Tabby,
        Labrador,
    }

    public enum PetColorType 
    {
        Red,
        Blue,
        Tiger,
        Spots,

        Black,

        Golden, 
    }
    public class Pet 
    {
        public int Id {get; set;}
        public string name { get; set;}
        public string color {get; set; }
        // public string checkedInAt {get; set;}

        public int petOwner {get; set;}

        public string breed {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breedTypes { get; set; }
    
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType colorTypes {get; set;}

        [ForeignKey("ownedBy")]
        public int petOwnerById {get; set; }

        public PetOwner ownedBy {get;set;}

    }
}