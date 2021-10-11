using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("MedicoDb")]

    public class MedicoVeterinario:Persona
    {
        [Required]
        [Column("IdMedico")]
        public int IdMedicoVeterinario { get; set; }

        //[Required]
        //[Column("Nombres")]
        //[StringLength(30,MinimumLength=5)]
        //public string Nombres { get; set; }

        [Required]
        [Column("TarjetaProfesional")]
        public int TarjetaProfesional { get; set; }

        [Required]
        [Column("Especializacion")]
        [StringLength(15,MinimumLength=5)]
        public string EspecializacionTipoAnimal { get; set; }

        [ForeignKey("IdAnimal")]
        public virtual TipoAnimal TipoAnimal{ get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa{ get; set; }

        [ForeignKey("IdSolicitud")]
        public virtual SolicitudVisita SolicitudVisita{ get; set; }

        [ForeignKey("IdHistoria")]
        public virtual HistoriaMedica HistoriaMedica { get; set; }
    }
}
