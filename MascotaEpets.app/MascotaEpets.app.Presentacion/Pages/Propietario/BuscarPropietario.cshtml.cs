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
    public class BuscarPropietarioModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioPropietario repositorio;

        [BindProperty]

        public MascotaEpets.app.Dominio.PropietarioMascota propietario{get;set;}

        //Metodo Constructor de la clase
        public BuscarPropietarioModel(IRepositorioPropietario repositorio){

            this.repositorio=repositorio;

        } 
        public IActionResult OnGet(int IdPropietario)
        {
             propietario=repositorio.BuscarPropietarioId(IdPropietario);

            if (propietario==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return Page();
            }
        }
    }
}
