using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Models
{
    [Table("Korisnik")]
    public class Korisnik
    {
        [Key]
        public int ID { get; set; }   //primarni kljuc

        [Required]
        [MaxLength (30)]
        public string Ime { get; set; }

        [Required]
        [MaxLength(50)]

        public string Prezime { get; set; }

         [Phone]
        public int Telefon {get; set;}

         //Navigacioni property 
        public virtual List<Iznajmljivanje> Iznajmljivanja {get;set;}


    }



    

}
