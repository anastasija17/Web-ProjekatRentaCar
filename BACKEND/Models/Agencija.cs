using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Models
{
    [Table("Agencija")]
    public class Agencija
    {
        [Key]
        public int ID {get; set;}

        [Required]
        [MaxLength(30)]
        public string Naziv {get; set;}

        [Required]
        [MaxLength]
        public string Lokacija {get; set;}

        public virtual  List<Automobil> AutomobiliZaIznajmljivanje{ get; set; }


    }
    
}