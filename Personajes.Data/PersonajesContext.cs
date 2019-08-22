using Microsoft.EntityFrameworkCore;
using Personajes.Modelos;

namespace Personajes.Data
{
    /// <summary>
    /// Es importante heredar de DBContext, para poder asi implementar el contexto de la base de datos.
    /// </summary>
    public class PersonajesContext : DbContext
    {
        /// <summary>
        /// Tabla Atributos
        /// </summary>
        public DbSet<Atributo>  Atributos { get; set; }

        /// <summary>
        /// Tabla Habilidades
        /// </summary>
        public DbSet<Habilidad> Habilidades { get; set; }

        /// <summary>
        /// establezco la conexion a la base de datos
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //aqui se define el proveedor y la cadena de conexion

            optionsBuilder.UseSqlite("Data Source= d:\\broxstar.db; ");
        }
            
    }
}
