using CursoEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Datos
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones)
        {

        }

        //Escribir Modelos
        /*Cuándo crear migraciones (buenas prácticas)
          1. Cuando sea crea una nueva clase (tabla en la bd).
          2. Cuando agregue una nueva propiedad (crear un nuevo campo en una tabla de la bd).
          3. Cuando modifique un valor de campo en la clase (modificar un campo de una tabla de la bd).
      */
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        
      
    }
}
