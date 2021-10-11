using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace MascotaEpets.app.Persistencia.AppRepositorios
{
     public class RepositoriosMedico:IRepositoriosMedicos
    {
        bool valorRetorno=false;
        //Ingresar Informacion del medico
        public bool IngresarMedico(MedicoVeterinario medicoVeterinario){
                
            try
            {
                 //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                   
                     var RegistroMed=contexto.Add(medicoVeterinario);
                     contexto.SaveChanges();
                     if(contexto.SaveChanges()>=1){
                        valorRetorno=true;
                     }
                     return valorRetorno;
                 }
            }
            catch (Exception ex)
            {
                string error=ex;
            }

               
        }
        //Borrar Medico
        public bool BorrarMedico(int IdMedicoVeterinario){

            try
            {
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
               
                var BuscarMedico=(from p in contexto.medicoVeterinario where p.IdMedicoVeterinario==IdMedicoVeterinario select p);
                if(!(BuscarMedico==null)) {
                    contexto.medicoVeterinario.Remove(BuscarMedico);
                    contexto.SaveChanges();
                    valorRetorno=true;

                }
                return valorRetorno;
             }
            }
            catch (Exception ex)
            {
                 string error=ex;
            }
        
        }

       /// <summary>
       /// Ejemplo de documentacion de actualizar EL Medico Veterinario
       /// </summary>
       /// <param name="medicoVeterinario"></param>
       /// <returns></returns>
       #region Actualizar Datos del Medico Veterinario
         public bool ActualizarMedico(MedicoVeterinario medicoVeterinario){

            try
            {
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 var BuscarMedico=(from p in contexto.medicoVeterinario where p.IdMedicoVeterinario==medicoVeterinario.IdMedicoVeterinario select p);
                 if(!(BuscarMedico==null)) {
                     BuscarMedico.Nombres=medicoVeterinario.Nombres;
                     BuscarMedico.TarjetaProfesional=medicoVeterinario.TarjetaProfesional;
                     bool valorRetorno=true;

                 }
                 return valorRetorno;
             }
            }
            catch (Exception ex)
            {
               string error=ex;
            }
        }
       #endregion
    
       
        // Consultar todos los Medicos (lista)
        public IEnumerable<MedicoVeterinario> ConsultarMedicos(){

            try
            {
                //var lista de medicos
             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.medico;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var listaMedicos=(from p in contexto.medicoVeterinario select p).ToList();
                 return listaMedicos;
             }
   
            }
            catch (Exception ex)
            {
                 string error=ex;
            }
             
        }
        //Consultar un medico 
        public MedicoVeterinario ConsultarMedicos(int IdMedicoVeterinario){

            try
            {
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                 var listaMedicos=(from p in contexto.medicoVeterinario where p.IdMedicoVeterinario==IdMedicoVeterinario select p).First();
                 return listaMedicos;


              }
            }
            catch (Exception ex)
            {
                 string error=ex;
            }
            
            
        }

    }

}    