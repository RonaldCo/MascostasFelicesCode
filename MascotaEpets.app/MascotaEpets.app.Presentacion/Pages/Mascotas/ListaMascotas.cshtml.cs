using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaEpets.app.Persistencia.AppRepositorios;
using MascotaEpets.app.Dominio;

namespace MascotaEpets.app.Presentacion.Pages
{
    public class ListaMascotasModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioMascota repositorio;

        //Variable que contiene la asignacion del metodo Buscar Mascotas
        public IEnumerable<MascotaEpets.app.Dominio.Mascota> Mascota= new List<MascotaEpets.app.Dominio.Mascota>();
        
        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.Mascota ObjMascota{get;set;}

        //Metodo Constructor de la clase
        public ListaMascotasModel(IRepositorioMascota repositorio){
          
          this.repositorio=repositorio;

        }

        //Metodo de consulta
        public void OnGet()
        {
            Mascota=repositorio.ConsultarMascota().ToList();
        }
    }
}
