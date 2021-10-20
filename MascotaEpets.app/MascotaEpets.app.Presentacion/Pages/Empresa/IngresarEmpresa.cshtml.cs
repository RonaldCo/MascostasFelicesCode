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
    public class IngresarEmpresaModel:PageModel
    {
        // Variable de tipo Interface
        private readonly IRepositorioEmpresa repositorio;

        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.Empresa empresa{get;set;}

        //Metodo Constructor de la clase
        public IngresarEmpresaModel(IRepositorioEmpresa repositorio){
          
          this.repositorio=repositorio;

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Empresa ObjEmpresa=new Empresa();
            ObjEmpresa.NombreEmpresa=empresa.NombreEmpresa;
            ObjEmpresa.Nit=empresa.Nit;
            ObjEmpresa.Direccion=empresa.Direccion;
            empresa=repositorio.IngresarEmpresa(ObjEmpresa);
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
