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
    public class ActualizarEmpresaModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioEmpresa repositorio;
        
        [BindProperty]

        public MascotaEpets.app.Dominio.Empresa empresa{get;set;}

        public ActualizarEmpresaModel(IRepositorioEmpresa repositorio){

            this.repositorio=repositorio;

        } 
        public IActionResult OnGet(int IdEmpresa)
        {
            empresa=repositorio.BuscarEmpresa(IdEmpresa);

            if (empresa==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return Page();
            }
        }

         public IActionResult OnPost()
        {
           empresa=repositorio.ActualizarEmpresa(empresa);
              if (empresa==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return RedirectToPage("./ListaEmpresa") ;
            
                }
         }
    }
}
