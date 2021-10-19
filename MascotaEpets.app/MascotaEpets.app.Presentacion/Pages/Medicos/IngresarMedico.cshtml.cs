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
        // Variable de tipo Interface de Medico
        private readonly IRepositorioMedico repositorio;

        // Variable de tipo Interface de Medico
        private readonly IRepositorioTipoAnimal repositorio_tipoAnimal;

        [BindProperty]
        public MascotaEpets.app.Dominio.MedicoVeterinario medico{get;set;}

        public List<MascotaEpets.app.Dominio.TipoAnimal> tipoanimal_=new List<TipoAnimal>();

        //Contructor de la clase para inicializar
        public IngresarMedicoModel(IRepositorioMedico repositorio,IRepositorioTipoAnimal repositorio_tipoAnimal){
            this.repositorio=repositorio;
            this.repositorio_tipoAnimal=repositorio_tipoAnimal;

        }
        public async Task OnGet()
        {
           tipoanimal_= repositorio_tipoAnimal.ListadoAnimal().ToList();
        }

        public void OnPost()
        {
            MedicoVeterinario ObjMedico=new MedicoVeterinario();
            ObjMedico.Nombres=medico.Nombres;
            ObjMedico.Apellidos=medico.Apellidos;
            ObjMedico.Cedula=medico.Cedula;
            ObjMedico.Telefono=medico.Telefono;
            ObjMedico.TarjetaProfesional=medico.TarjetaProfesional;
            medico=repositorio.IngresarMedico(ObjMedico);
        }
    }
}
