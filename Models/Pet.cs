using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType
    {
        Shepard,
        Beagle,
        Poodle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever

    }

    public enum PetColorType
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet
    {

        public int Id {get;set;}
        public string name { get; set; }
        public DateTime checkedInAt { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType BreedTypes { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType ColorTypes { get; set; }

        [ForeignKey("ownedBy")]
        public int petOwnerById { get; set; }
        
         public PetOwner ownedBy {get;set;}

    }
}