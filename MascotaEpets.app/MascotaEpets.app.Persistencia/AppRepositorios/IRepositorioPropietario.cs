using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
         PropietarioMascota BuscarPropietarioId(int IdPropietario);

         IEnumerable<PropietarioMascota> ConsultarPropietario();

         PropietarioMascota ActualizarPropietario(PropietarioMascota ObjPropietario);

        PropietarioMascota IngresarPropietario(PropietarioMascota ObjPropietario);
        //bool BorrarPropietario(int IdPropietario);
    }
}