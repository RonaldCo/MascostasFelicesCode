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
        // Variable de tipo Interface
        private readonly IRepositorioMedico repositorio;

        [BindProperty]
        public MascotaEpets.app.Dominio.MedicoVeterinario medico{get;set;}

        //Contructor de la clase para inicializar
        public IngresarMedicoModel(IRepositorioMedico repositorio){
            this.repositorio=repositorio;

        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            MedicoVeterinario ObjMedico=new MedicoVeterinario();
            ObjMedico.Nombres=medico.Nombres;
            ObjMedico.Apellidos=medico.Apellidos;
            ObjMedico.TarjetaProfesional=medico.TarjetaProfesional;
            medico=repositorio.IngresarMedico(ObjMedico);
        }
    }
}
