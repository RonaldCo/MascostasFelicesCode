using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        public PropietarioMascota BuscarPropietarioId(int IdPropietario){
          
            using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                // var Medico=(from p in contexto.medicoVeterinario where p.IdMedico==IdMedico select p).First();
                // return Medico;

                //sintaxis Entity framework (ef)

                return contexto.propietarioMascota.SingleOrDefault(s=>s.Id==IdPropietario);

            }

        }

        public IEnumerable<PropietarioMascota> ConsultarPropietario(){
            
            using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.medico;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var listaPropietarios=(from p in contexto.propietarioMascota select p).ToList();
                 return listaPropietarios;
             }

        }

        public PropietarioMascota ActualizarPropietario(PropietarioMascota ObjPropietario){
            
             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //var BuscarPropietario=(from p in contexto.propietarioMascota where p.IdM=IdMedico select p);
                 var BuscarPropietario=contexto.propietarioMascota.SingleOrDefault(s=>s.Id==ObjPropietario.Id);
                 if(!(BuscarPropietario==null)) {
                     BuscarPropietario.Nombres=ObjPropietario.Nombres;
                     BuscarPropietario.Apellidos=ObjPropietario.Apellidos;
                     BuscarPropietario.Cedula=ObjPropietario.Cedula;
                     BuscarPropietario.Telefono=ObjPropietario.Telefono;
                     BuscarPropietario.Direccion=ObjPropietario.Direccion;
                     BuscarPropietario.Email=ObjPropietario.Email;
                     BuscarPropietario.CantidadMascota=ObjPropietario.CantidadMascota;
                     contexto.SaveChanges();
                    

                 }
                  return BuscarPropietario;
             }

        }

        //Implementacion de la firma del metodo Ingresar un propietario
        public PropietarioMascota IngresarPropietario(PropietarioMascota ObjPropietario){

            
                 //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el medico
                     contexto.propietarioMascota.Add(ObjPropietario);
                     contexto.SaveChanges();
                     return ObjPropietario;
                 }                                 

        }
    }
}