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
    public class BuscarMedicoModel : PageModel
    
    {
        // Variable de tipo Interface
        private readonly IRepositorioMedico repositorio;

        [BindProperty]

        public MascotaEpets.app.Dominio.MedicoVeterinario medico{get;set;}

        //Metodo Constructor de la clase
        public BuscarMedicoModel(IRepositorioMedico repositorio){

            this.repositorio=repositorio;

      } 
        public IActionResult OnGet(int IdMedico)
        {
            medico=repositorio.BuscarMedicoId(IdMedico);

            if (medico==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return Page();
            }
        }    
    }
}
