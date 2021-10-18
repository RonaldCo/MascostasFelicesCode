/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MascotaEpets.app.Dominio
{
    [Table("EmpresaDb")]
    public class Empresa
    {
        [Key]
        [Column("IdEmpresa")]
        public int IdEmpresa { get; set; }

        [Required]
        [Column("NombreEmpresa")]
        [StringLength(30,MinimumLength=5)]
        public string NombreEmpresa { get; set; }

        [Required]
        [Column("NIt")]
        [StringLength(20,MinimumLength=5)]
        public string Nit { get; set; }

        [Required]
        [Column("Direccion")]
        [StringLength(30,MinimumLength=5)]
        public string Direccion { get; set; }
 
    }
}*/
