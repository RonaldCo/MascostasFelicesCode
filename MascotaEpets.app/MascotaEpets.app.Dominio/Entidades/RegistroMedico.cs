using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("RegistroMedicoDb")]
    public class RegistroMedico
    {
       

        [Required]
        [Column("Recomendaciones")]
        [StringLength(50,MinimumLength=5)]
        public string Recomendaciones { get; set; }

        [Required]
        [Column("FechaAtencion")]
        public DateTime FechaAtencion { get; set; }

        [Required]
        [Column("Medicamentos")]
        [StringLength(30,MinimumLength=5)]
        public string Medicamentos { get; set; }

        [ForeignKey("IdMedico")]
        public virtual MedicoVeterinario MedicoVeterinario { get; set; }
        
         [Key]
        [Column("IdRegistroM")]
        public int IdRegistroMedico { get; set; }
        

    
    }
}