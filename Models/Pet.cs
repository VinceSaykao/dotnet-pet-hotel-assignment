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
    }

    public enum PetColorType 
    {
        Red,
        Blue,
        Tiger,
        Spots,
    }
    public class Pet {
        public int Id {get; set;}
        public string Name { get; set;}
        public string Color {get; set; }
        public string checkedInAt {get; set;}

        public int petOwnderid {get; set;}

        public string Breed {get; set;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType BreedTypes { get; set; }
    
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType ColorTypes {get; set;}

        [ForeignKey("petOwner")]
        public int petOwner {get; set; }
//  add something here after petOwner built out

    }
}
