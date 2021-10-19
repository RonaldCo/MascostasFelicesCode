using MascotaEpets.app.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;


namespace MascotaEpets.app.Persistencia.AppRepositorios
{
    public class RepositorioTipoAnimal:IRepositorioTipoAnimal
    {
        public IEnumerable<TipoAnimal> ListadoAnimal(){

               //var lista de Animales
             using (AppData.EfAppContext contexto= new AppData.EfAppContext()){
                 
                 //primer forma para consultar
                 //return contexto.TipoAnimal;

                 // Otra manera de consultar toda la informacion de una tabla
                 //linq
                 var listaAnimal=(from p in contexto.tipoAnimal select p).ToList();
                 return listaAnimal;
             }
        }
    }
}