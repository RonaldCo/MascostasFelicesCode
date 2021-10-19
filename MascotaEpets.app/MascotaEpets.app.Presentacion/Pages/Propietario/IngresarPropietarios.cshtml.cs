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
    public class IngresarPropietariosModel : PageModel
    {
        // Variable de tipo Interface de Propietario
        private readonly IRepositorioPropietario repositorio;

        [BindProperty]
        public MascotaEpets.app.Dominio.PropietarioMascota Propietario{get;set;}

        public IngresarPropietariosModel(IRepositorioPropietario repositorio){
            this.repositorio=repositorio;

        }

        public void OnGet()
        {
        }

          public IActionResult OnPost()
        {
            PropietarioMascota ObjPropietario=new PropietarioMascota();
            ObjPropietario.Nombres=Propietario.Nombres;
            ObjPropietario.Apellidos=Propietario.Apellidos;
            ObjPropietario.Cedula=Propietario.Cedula;
            ObjPropietario.Telefono=Propietario.Telefono;
            ObjPropietario.Direccion=Propietario.Direccion;
            ObjPropietario.Email=Propietario.Email;
            ObjPropietario.CantidadMascota=Propietario.CantidadMascota;
            Propietario=repositorio.IngresarPropietario(ObjPropietario);

             if (Propietario==null)
            {
               return RedirectToPage("./PaginaNoEncontrada") ;
            }
            else{

                return RedirectToPage("./ListaPropietarios") ;
            
                }
        }
    }
}
