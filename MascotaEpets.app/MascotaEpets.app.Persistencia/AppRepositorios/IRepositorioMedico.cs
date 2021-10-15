using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;


namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico
    {
        bool IngresarMedico(MedicoVeterinario medicoVeterinario);
        bool BorrarMedico(int IdPersona);
        bool ActualizarMedico(MedicoVeterinario medicoVeterinario);
        IEnumerable<MedicoVeterinario> ConsultarMedicos();
        MedicoVeterinario ConsultarMedicos(int dPersona);

    }
}