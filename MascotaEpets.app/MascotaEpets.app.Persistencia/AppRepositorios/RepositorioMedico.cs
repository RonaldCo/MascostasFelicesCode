using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;


namespace MascotaEpets.app.Persistencia.AppRepositorios
{
     public class RepositorioMedico:IRepositorioMedico
    {
        
        bool valorRetorno=false;
        #region CRUD Ingresar datos medicos
        //Ingresar Informacion del medico
        public MedicoVeterinario IngresarMedico(MedicoVeterinario ObjMedico){
                
        
                 //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el medico
                     contexto.MedicoVeterinario.Add(ObjMedico);
                     contexto.SaveChanges();
                     return ObjMedico;
                 }
               
        }

        #endregion
        
        //Borrar Medico
        public bool BorrarMedico(int IdMedico){

          
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
               
                var BuscarMedico=(from p in contexto.medicoVeterinario where p.IdPersona ==IdPersona select p);
                if(!(BuscarMedico==null)) {
                    contexto.medicoVeterinario.Remove(BuscarMedico);
                    contexto.SaveChanges();
                    valorRetorno=true;

                }
                return valorRetorno;
             
            }
        
        }
        
       /// <summary>
       /// Ejemplo de documentacion de actualizar EL Medico Veterinario
       /// </summary>
       /// <param name="medicoVeterinario"></param>
       /// <returns></returns>
 
         public MedicoVeterinario ActualizarMedico(int IdMedico,string Nombres,string Apellidos,string TarjetaProfesional){

            
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 var BuscarMedico=(from p in contexto.MedicoVeterinario where p.IdMedico=MedicoVeterinario.IdMedico select p);
                 if(!(BuscarMedico==null)) {
                     BuscarMedico.Nombres=MedicoVeterinario.Nombres;
                     BuscarMedico.Apellidos=MedicoVeterinario.Apellidos;
                     BuscarMedico.TarjetaProfesional=MedicoVeterinario.TarjetaProfesional;
                     valorRetorno=true;

                 }
                 return valorRetorno;
             }
            
          

         }

        // Consultar todos los Medicos (lista)
          public IEnumerable<MascotaEpets.app.Dominio.MedicoVeterinario> ConsultarMedicos(){
            
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
        
        //Consultar un medico 
        public MedicoVeterinario BuscarMedicoId(int IdMedico){

        
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                // var Medico=(from p in contexto.medicoVeterinario where p.IdMedico==IdMedico select p).First();
                // return Medico;

                //sintaxis Entity framework (ef)

                return contexto.medicoVeterinario.SingleOrDefault(s=>s.IdMedico==IdMedico);

            }

        }
    }   
}