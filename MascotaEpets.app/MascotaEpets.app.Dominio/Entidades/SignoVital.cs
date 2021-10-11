using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("SignoVitalesDb")]
    public class SignoVital
    {
        
        [Column("IdSignos")]
        [Key]
        public int IdSignos { get; set; }

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
    }
}
