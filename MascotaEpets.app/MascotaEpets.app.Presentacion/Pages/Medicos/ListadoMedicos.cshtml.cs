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
    public class ListadoMedicosModel : PageModel
    {
        //private readonly IRepositorioMedico repositorio;
        //public IEnumerable<MascotaEpets.app.Dominio.MedicoVeterinario> medico=new IEnumerable<MascotaEpets.app.Dominio.MedicoVeterinario>;
        public void OnGet()
        {
          //medico=repositorio.ConsultarMedicos().Tolist();
        }

        /*public ListadoMedicosModel(IRepositorioMedico repositorio){

            this.repositorio=repositorio;

      }   */ 

    }
}

