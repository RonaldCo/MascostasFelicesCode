using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public class RepositorioMascota:IRepositorioMascota
    {
        public Mascota BuscarMascotaId(int IdMascota){

             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                // var mascota=(from p in contexto.mascota where p.IdMascota==IdMascota select p).First();
                // return mascota;

                //sintaxis Entity framework (ef)

                return contexto.mascota.SingleOrDefault(s=>s.IdMascota==IdMascota);

            }
        }

        public IEnumerable<Mascota> ConsultarMascota(){

            using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.mascota;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var listaMascota=(from p in contexto.mascota select p).ToList();
                 return listaMascota;
             }

        }

        public Mascota ActualizarMascota(Mascota ObjMascota){

             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //var BuscarMascota=(from p in contexto.mascota where p.IdMascota=IdMascota select p);
                 var BuscarMascota=contexto.mascota.SingleOrDefault(s=>s.IdMascota==ObjMascota.IdMascota);
                 if(!(BuscarMascota==null)) {
                     BuscarMascota.Nombre=ObjMascota.Nombre;
                     BuscarMascota.ColorOjos=ObjMascota.ColorOjos;
                     BuscarMascota.ColorPiel=ObjMascota.ColorPiel ;
                     BuscarMascota.Temperatura=ObjMascota.Temperatura;
                     BuscarMascota.Peso=ObjMascota.Peso;
                     BuscarMascota.FrecuenciaRespiratoria=ObjMascota.FrecuenciaRespiratoria;
                     BuscarMascota.FrecuenciaCardiaca=ObjMascota.FrecuenciaCardiaca;
                     BuscarMascota.EstadoAnimo=ObjMascota.EstadoAnimo;
                     contexto.SaveChanges();
                    

                 }
                  return BuscarMascota;
             }


        }

        public Mascota IngresarMascota(Mascota ObjMascota){

              //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el mascota
                     contexto.mascota.Add(ObjMascota);
                     contexto.SaveChanges();
                     return ObjMascota;
                 } 

        }
    }
}