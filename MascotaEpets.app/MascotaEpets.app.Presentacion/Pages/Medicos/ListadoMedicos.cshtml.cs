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
        // Variable de tipo Interface
        private readonly IRepositorioMedico repositorio;

        //Variable que contiene la asignacion del metodo Buscar Medicos
        public IEnumerable<MascotaEpets.app.Dominio.MedicoVeterinario> Medicos= new List<MascotaEpets.app.Dominio.MedicoVeterinario>();
        
        // Inicializacion de la pagina

        [BindProperty]
        public MascotaEpets.app.Dominio.MedicoVeterinario ObjMedico{get;set;}

        //Metodo de consulta
        public void OnGet()
        {
          Medicos=repositorio.ConsultarMedicos().ToList();
        }

        //Metodo Constructor de la clase
        public ListadoMedicosModel(IRepositorioMedico repositorio){

            this.repositorio=repositorio;

      }    

    }
}

