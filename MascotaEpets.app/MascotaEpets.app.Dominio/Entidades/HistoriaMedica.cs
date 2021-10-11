using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("HistoriaMedicaDb")]
    public class HistoriaMedica
    {
        [Column("IdHistoria")]
        [Key]
        public int IdHistoria { get; set; }
              
        [ForeignKey("IdRegistroMedico")]
        public virtual RegistroMedico RegistroMedico { get; set; }

        [ForeignKey("IdMascota")]
        public virtual Mascota Mascota{ get; set; }

        [ForeignKey("IddPropietarioMascota")]
        public virtual PropietarioMascota PropietarioMascota { get; set; }
    }
}
