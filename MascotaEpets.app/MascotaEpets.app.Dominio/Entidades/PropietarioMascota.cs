using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("PropietariosDb")]
    public class PropietarioMascota:Persona
    {
       

        [ForeignKey("IdMascota")]
        public virtual Mascota Mascota { get; set; }
        
        [Required]
        [Column("Direccion")]
        [StringLength(30,MinimumLength=5)]
        public string Direccion { get; set; }

        [Required]
        [Column("Email")]
        [StringLength(30,MinimumLength=5)]
        public string Email { get; set; }

        [Required]
        [Column("CantidadMascotas")]
        public int CantidadMascota { get; set; }
        
    }
}
