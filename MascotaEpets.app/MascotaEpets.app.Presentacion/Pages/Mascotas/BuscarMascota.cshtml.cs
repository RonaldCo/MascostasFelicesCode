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
    public class BuscarMascotaModel : PageModel
    {

         // Variable de tipo Interface
        private readonly IRepositorioMascota repositorio;

        [BindProperty]

        public MascotaEpets.app.Dominio.Mascota mascota{get;set;}

        //Metodo Constructor de la clase
        public BuscarMascotaModel(IRepositorioMascota repositorio){

            this.repositorio=repositorio;

        } 
        public IActionResult OnGet(int IdMascota)
        {
             mascota=repositorio.BuscarMascotaId(IdMascota);

            if (mascota==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return Page();
            }
        }
    }
}
