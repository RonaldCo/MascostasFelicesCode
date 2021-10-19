using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("MascotaDb")]
    public class Mascota
    {
        [Column("IdMascota")]
        [Key]
        public int IdMascota { get; set; }

        [Required]
        [Column("Nombre")]
        [StringLength(30,MinimumLength=5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(15,MinimumLength=5)]
        [Column("ColorOjos")]
        public string ColorOjos { get; set; }

        [Required]
        [Column("ColorPiel")]
        [StringLength(15,MinimumLength=5)]
        public string ColorPiel { get; set; }

        [Required]
        [Column("Temperatura")]
        public double Temperatura { get; set; }

        [Required]
        [Column("Peso")]
        public double Peso { get; set; }

        [Required]
        [Column("FrecuenciaRespiratoria")]
        public double FrecuenciaRespiratoria { get; set; }

        [Required]
        [Column("FrecuenciaCardiaca")]
        public double FrecuenciaCardiaca { get; set; }

        [Required]
        [Column("EstadoAnimo")]
        [StringLength(20,MinimumLength=5)]
        public string EstadoAnimo { get; set; }
        /*[ForeignKey("IdSignos")]
        public virtual SignoVital SignoVital { get; set; }*/

        [ForeignKey("IdAnimal")]
        public virtual TipoAnimal TipoAnimal { get; set; }

      
    }
}