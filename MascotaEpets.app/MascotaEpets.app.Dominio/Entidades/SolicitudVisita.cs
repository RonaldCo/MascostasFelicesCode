using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("SolicitudVisitaDb")]
    public class SolicitudVisita
    {
        [Key]
        [Column("IdSolicitud")]
        public int idSolicitudVisita { get; set; }

        [Required]
        [Column("NombreMascota")]
        [StringLength(30,MinimumLength=5)]
        public string NombreMascota { get; set; }

        [Required]
        [Column("FechaSolicitud")]
        public DateTime FechaSolicitud { get; set; }

        [ForeignKey("IdAnimal")]
        public virtual TipoAnimal TipoAnimal{ get; set; }

        [ForeignKey("IdMedico")]
        public virtual MedicoVeterinario MedicoVeterinario { get; set; }

        [ForeignKey("IdPropietario")]
        public virtual PropietarioMascota PropietarioMascota { get; set; }

        [ForeignKey("IdRegistroM")]
        public virtual RegistroMedico RegistroMedico { get; set; }

        [ForeignKey("IdMascota")]
        public virtual Mascota Mascota { get; set; }

    
    }
}
