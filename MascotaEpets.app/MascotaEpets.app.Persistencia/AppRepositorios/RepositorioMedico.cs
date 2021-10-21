using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;


namespace MascotaEpets.app.Persistencia.AppRepositorios
{
     public class RepositorioMedico:IRepositorioMedico
    {
        
        #region CRUD Ingresar datos medicos
        //Ingresar Informacion del medico
        public MedicoVeterinario IngresarMedico(MedicoVeterinario ObjMedico){
                
        
                 //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el medico
                     contexto.medicoVeterinario.Add(ObjMedico);
                     contexto.SaveChanges();
                     return ObjMedico;
                 }
               
        }

        #endregion
        
        //Borrar Medico


        public  MedicoVeterinario BorrarMedico(int IdMedico){

          
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
               
                //var BuscarMedico=(from p in contexto.medicoVeterinario where p.Id==IdMedico.Id select p);
                var BuscarMedico=contexto.medicoVeterinario.SingleOrDefault(s=>s.Id==IdMedico);
                if(!(BuscarMedico==null)) {
                    contexto.medicoVeterinario.Remove(BuscarMedico);
                    contexto.SaveChanges();
                    

                }
                return BuscarMedico;
             
            }
        
        }
        
       /// <summary>
       /// Ejemplo de documentacion de actualizar EL Medico Veterinario
       /// </summary>
       /// <param name="medicoVeterinario"></param>
       /// <returns></returns>
 
         public MedicoVeterinario ActualizarMedico(MedicoVeterinario ObjMedico){

            
                using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //var BuscarMedico=(from p in contexto.medicoVeterinario where p.IdMedico=IdMedico select p);
                 var BuscarMedico=contexto.medicoVeterinario.SingleOrDefault(s=>s.Id==ObjMedico.Id);
                 if(!(BuscarMedico==null)) {
                     BuscarMedico.Nombres=ObjMedico.Nombres;
                     BuscarMedico.Apellidos=ObjMedico.Apellidos;
                     BuscarMedico.Cedula=ObjMedico.Cedula;
                     BuscarMedico.Telefono=ObjMedico.Telefono;
                     BuscarMedico.TarjetaProfesional=ObjMedico.TarjetaProfesional;
                     contexto.SaveChanges();
                    

                 }
                  return BuscarMedico;
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

                return contexto.medicoVeterinario.SingleOrDefault(s=>s.Id==IdMedico);

            }

        }
    }   
}