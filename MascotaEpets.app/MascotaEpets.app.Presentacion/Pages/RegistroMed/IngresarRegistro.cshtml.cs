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
    public class IngresarRegistroModel : PageModel
    {

         // Variable de tipo Interface de Medico
        private readonly IRepositorioRegistroMed repositorio;

        [BindProperty]
        public MascotaEpets.app.Dominio.RegistroMedico registro{get;set;}

        //Contructor de la clase para inicializar
        public IngresarRegistroModel(IRepositorioRegistroMed repositorio){
            this.repositorio=repositorio;
    

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            RegistroMedico ObjRegistro=new RegistroMedico();
            ObjRegistro.Recomendaciones=registro.Recomendaciones;
            ObjRegistro.FechaAtencion=registro.FechaAtencion;
            ObjRegistro.Medicamentos=registro.Medicamentos;
            registro=repositorio.IngresarRegistro(registro);
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
