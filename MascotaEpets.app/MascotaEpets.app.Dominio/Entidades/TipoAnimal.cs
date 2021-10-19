using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("TipoAnimalDb")]
    public class TipoAnimal
    {
        [Column("IdAnimal")]
        [Key]
        public int idAnimal { get; set; }

        [Required]
        [Column("Animal")]
        [StringLength(20,MinimumLength=5)]
        public string Animal { get; set; }

    }
}
