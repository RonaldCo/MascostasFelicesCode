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
    public class IngresarMedicoModel : PageModel
    {
        [BindProperty]

        public MascotaEpets.app.Dominio.MedicoVeterinario medico{get;set;}
        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
