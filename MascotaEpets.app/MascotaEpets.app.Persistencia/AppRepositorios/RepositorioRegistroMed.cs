using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public class RepositorioRegistroMed:IRepositorioRegistroMed
    {
        public RegistroMedico BuscarRegistro(int IdRegistroMedico){
               
                  using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                // var registroMedico=(from p in contexto.mascota where p.IdRegistroMedico==IdRegistroMedico select p).First();
                // return registroMedico;

                //sintaxis Entity framework (ef)

                return contexto.registroMedico.SingleOrDefault(s=>s.IdRegistroMedico==IdRegistroMedico);

            }

        }

        public IEnumerable<RegistroMedico> ConsultarRegistro(){

            using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.registroMedico;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var ListaRegistro=(from p in contexto.registroMedico select p).ToList();
                 return ListaRegistro;
             }


        }

        public RegistroMedico ActualizarRegistro(RegistroMedico Registro){

             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //var BuscarRegistro=(from p in contexto.registroMedico where p.IdRegistroMedico=IdRegistroMedico select p);
                 var BuscarRegistro=contexto.registroMedico.SingleOrDefault(s=>s.IdRegistroMedico==Registro.IdRegistroMedico);
                 if(!(BuscarRegistro==null)) {
                     BuscarRegistro.Recomendaciones =Registro.Recomendaciones;
                     BuscarRegistro.FechaAtencion=Registro.FechaAtencion;
                     BuscarRegistro.Medicamentos=Registro.Medicamentos;
                     contexto.SaveChanges();
                    

                 }
                  return BuscarRegistro;
             }

        }

        public RegistroMedico IngresarRegistro(RegistroMedico Registro){

            
              //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el mascota
                     contexto.registroMedico.Add(Registro);
                     contexto.SaveChanges();
                     return Registro;
                 } 


        }
    }
}