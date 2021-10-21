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
    public class ActualizarRegistroModel : PageModel
    {
        // Variable de tipo Interface
        private readonly IRepositorioRegistroMed repositorio;
        
        [BindProperty]

        public MascotaEpets.app.Dominio.RegistroMedico registro{get;set;}

        public ActualizarRegistroModel(IRepositorioRegistroMed repositorio){

            this.repositorio=repositorio;

        } 
        public IActionResult OnGet(int IdRegistroMedico)
        {
            registro=repositorio.BuscarRegistro(IdRegistroMedico);

            if (registro==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return Page();
            }
        }

         public IActionResult OnPost()
        {
            registro=repositorio.ActualizarRegistro(registro);
              if (registro==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return RedirectToPage("./ListaRegistros") ;
            
                }
         }
    }
}
