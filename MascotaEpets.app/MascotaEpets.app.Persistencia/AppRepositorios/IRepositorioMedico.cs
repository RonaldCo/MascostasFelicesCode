using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System;
using System.Linq;



namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public interface IRepositorioMedico 
    {
        #region Firma de los metodos para la implementacion en la clase
        //Firma del Metodo Para Ingresar Datos
        MedicoVeterinario IngresarMedico(MedicoVeterinario ObjMedico);

        //Firma del Metodo para Eliminar un Medico
        //bool BorrarMedico(int IdMedico);

        //Firma del Metodo para Actualizar Datos
        //MedicoVeterinario ActualizarMedico(int IdMedico,string Nombres,string Apellidos,string TarjetaProfesional);
        //Firma del Metodo para Actualizar Datos   OTRA FORMA DE HACERLO
        MedicoVeterinario ActualizarMedico(MedicoVeterinario ObjMedico);
        //Firma del Metodo para consultar todos los medicos
        IEnumerable<MedicoVeterinario> ConsultarMedicos();

         //Firma del Metodo para un medico ID   
        MedicoVeterinario BuscarMedicoId(int IdMedico);
        #endregion
    }
}