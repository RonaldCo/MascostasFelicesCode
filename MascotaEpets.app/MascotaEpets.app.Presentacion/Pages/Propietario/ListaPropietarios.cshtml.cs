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
    public class ListaPropietariosModel : PageModel
    {
        //variable de tipo interface
        private readonly IRepositorioPropietario repositorio;

        //Variable que contiene la asignacion del metodo Buscar Propietarios
        public IEnumerable<MascotaEpets.app.Dominio.PropietarioMascota> Propietarios= new List<MascotaEpets.app.Dominio.PropietarioMascota>();

        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.PropietarioMascota ObjPropietario{get;set;}
        public void OnGet()
        {
           Propietarios=repositorio.ConsultarPropietario().ToList();

        }

        //Metodo Constructor
        public ListaPropietariosModel(IRepositorioPropietario repositorio){
         
         this.repositorio=repositorio;

        }
    }
}
