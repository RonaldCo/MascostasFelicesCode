using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa:IRepositorioEmpresa
    {
        public Empresa BuscarEmpresa(int IdEmpresa){

            
             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                
                //con linq
                // var empresa=(from p in contexto.empresa where p.IdEmpresa==IdEmpresa select p).First();
                // return empresa;

                //sintaxis Entity framework (ef)

                return contexto.empresa.SingleOrDefault(s=>s.IdEmpresa==IdEmpresa);

            }


        }

        public IEnumerable<Empresa> ConsultarEmpresa(){

             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.empresa;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var listaEmpresa=(from p in contexto.empresa select p).ToList();
                 return listaEmpresa;
             }


        }

        public Empresa ActualizarEmpresa(Empresa ObjEmpresa){

            using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //var BuscarMascota=(from p in contexto.mascota where p.IdMascota=IdMascota select p);
                 var BuscarEmpresa=contexto.empresa.SingleOrDefault(s=>s.IdEmpresa==ObjEmpresa.IdEmpresa);
                 if(!(BuscarEmpresa==null)) {
                     BuscarEmpresa.NombreEmpresa=ObjEmpresa.NombreEmpresa;
                     BuscarEmpresa.Nit=ObjEmpresa.Nit;
                     BuscarEmpresa.Direccion=ObjEmpresa.Direccion;
                     contexto.SaveChanges();
                    

                 }
                  return BuscarEmpresa;
             }
        }

        public Empresa IngresarEmpresa(Empresa ObjEmpresa){

             //abriendo, Cerrando y liberando recursos del using.
                 using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                    
                    //agrego a la conexion contexto BD un medico con ADD y guardo cambios despues retorno el mascota
                     contexto.empresa.Add(ObjEmpresa);
                     contexto.SaveChanges();
                     return ObjEmpresa;
                 } 

        }
       
    }
}