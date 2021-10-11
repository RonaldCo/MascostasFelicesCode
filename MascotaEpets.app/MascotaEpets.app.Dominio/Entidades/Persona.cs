using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("PersonaDb")]
    public class Persona
    {
        [Column("IdPersona")]
        [Key]
        public int IdPersona { get; set; }

        [Required]
        [Column("Cedula")]
        [StringLength(12,MinimumLength=5)]
        public string Cedula { get; set; }

        [Required]
        [Column("Nombre")]
        [StringLength(30,MinimumLength=5)]
        public string Nombres { get; set; }

        [Required]
        [Column("Apellido")]
        [StringLength(30,MinimumLength=5)]
        public string Apellidos { get; set; }

        [Required]
        [Column("Telefono")]
        [StringLength(12,MinimumLength=5)]
        public string Telefono { get; set; }
    }
}
