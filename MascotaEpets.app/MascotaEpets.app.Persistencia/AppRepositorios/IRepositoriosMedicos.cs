using MascotaEpets.app.Dominio;
using System.Collections.Generic;
namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositoriosMedicos
    {
        bool IngresarMedico(MedicoVeterinario medicoVeterinario);
        bool BorrarMedico(int IdMedicoVeterinario);
        bool ActualizarMedico(MedicoVeterinario medicoVeterinario);
        IEnumerable<MedicoVeterinario> ConsultarMedicos();
        MedicoVeterinario ConsultarMedicos(int IdMedicoVeterinario);

    }
}