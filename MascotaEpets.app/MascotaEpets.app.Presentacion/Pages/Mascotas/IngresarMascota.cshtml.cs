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
    public class IngresarMascotaModel : PageModel
    {
         // Variable de tipo Interface
        private readonly IRepositorioMascota repositorio;

        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.Mascota mascota{get;set;}

        //Metodo Constructor de la clase
        public IngresarMascotaModel(IRepositorioMascota repositorio){
          
          this.repositorio=repositorio;

        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Mascota ObjMascota=new Mascota();
            ObjMascota.Nombre=mascota.Nombre;
            ObjMascota.ColorOjos=mascota.ColorOjos;
            ObjMascota.ColorPiel=mascota.ColorPiel;
            ObjMascota.Temperatura=mascota.Temperatura;
            ObjMascota.Peso=mascota.Peso;
            ObjMascota.FrecuenciaRespiratoria=mascota.FrecuenciaRespiratoria;
            ObjMascota.FrecuenciaCardiaca=mascota.FrecuenciaCardiaca;
            ObjMascota.EstadoAnimo=mascota.EstadoAnimo;
            mascota=repositorio.IngresarMascota(ObjMascota);
              if (mascota==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return RedirectToPage("./ListaMascotas") ;
            
                }
        }
    }
}
