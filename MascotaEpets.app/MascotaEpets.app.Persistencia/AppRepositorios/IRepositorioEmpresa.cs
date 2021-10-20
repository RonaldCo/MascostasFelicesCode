using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioEmpresa
    {
        Empresa BuscarEmpresa(int IdEmpresa);

        IEnumerable<Empresa> ConsultarEmpresa();

        Empresa ActualizarEmpresa(Empresa ObjEmpresa);

        Empresa IngresarEmpresa(Empresa ObjEmpresa);

        //bool BorrarEmpresa(int IdEmpresa);
        
    }
}