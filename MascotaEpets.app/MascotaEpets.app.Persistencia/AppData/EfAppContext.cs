using System;
using MascotaEpets.app.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaEpets.app.Persistencia.AppData
{
    public class EfAppContext:DbContext
    {

        public DbSet<Empresa> empresa { get; set; }

        public DbSet<Mascota> mascota { get; set; }

        public DbSet<MedicoVeterinario> medicoVeterinario { get; set; }

        public DbSet<PropietarioMascota> propietarioMascota { get; set; }

        public DbSet<RegistroMedico> registroMedico { get; set; }

        public DbSet<SignoVital> signoVital { get; set; }
        
        public DbSet<SolicitudVisita> solicitudVisita { get; set; }

        public DbSet<TipoAnimal> tipoAnimal { get; set; }
        
        //conexion a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-S0MTAM5\\SQLEXPRESS;Initial Catalog=ProyectoMascotaEpets;Integrated Security=True;");
            }
        }
    }
}
