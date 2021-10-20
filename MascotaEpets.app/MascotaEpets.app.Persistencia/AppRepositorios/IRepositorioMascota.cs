using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        Mascota BuscarMascotaId(int IdMascota);

        IEnumerable<Mascota> ConsultarMascota();

        Mascota ActualizarMascota(Mascota ObjMascota);

        Mascota IngresarMascota(Mascota ObjMascota);

        //bool BorrarMascota(int IdMascota);
        
    }
}