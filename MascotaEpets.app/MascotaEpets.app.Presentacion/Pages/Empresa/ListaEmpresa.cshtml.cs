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
    public class ListaEmpresaModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioEmpresa repositorio;

        //Variable que contiene la asignacion del metodo Buscar Mascotas
        public IEnumerable<MascotaEpets.app.Dominio.Empresa> empresa= new List<MascotaEpets.app.Dominio.Empresa>();
        
        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.Empresa Empresa{get;set;}

        //Metodo Constructor de la clase
        public ListaEmpresaModel(IRepositorioEmpresa repositorio){
          
          this.repositorio=repositorio;

        }
        public void OnGet()
        {
             empresa=repositorio.ConsultarEmpresa().ToList();
        }
    }
}
