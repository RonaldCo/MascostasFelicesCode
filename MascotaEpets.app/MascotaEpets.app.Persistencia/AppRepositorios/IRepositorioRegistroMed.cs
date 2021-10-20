using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistroMed
    {
        RegistroMedico BuscarRegistro(int IdRegistroMedico);

        IEnumerable<RegistroMedico> ConsultarRegistro();

        RegistroMedico ActualizarRegistro(RegistroMedico Registro);

        RegistroMedico IngresarRegistro(RegistroMedico Registro);

        //bool BorrarRegistro(int int IdRegistroMedico);
    }
}