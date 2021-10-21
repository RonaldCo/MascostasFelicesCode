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
    public class ListaRegistrosModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioRegistroMed repositorio;

        //Variable que contiene la asignacion del metodo Buscar Mascotas
        public IEnumerable<MascotaEpets.app.Dominio.RegistroMedico> registro= new List<MascotaEpets.app.Dominio.RegistroMedico>();
        
        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.RegistroMedico Registro{get;set;}

        //Metodo Constructor de la clase
        public ListaRegistrosModel(IRepositorioRegistroMed repositorio){
          
          this.repositorio=repositorio;

        }
        public void OnGet()
        {
            registro=repositorio.ConsultarRegistro().ToList();
        }
    }
}
