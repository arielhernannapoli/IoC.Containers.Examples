using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoC.Spring.Container.Repositories
{
    public class TestContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }

    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("DOCUMENTO")]
        public string Documento { get; set; }
    }
}
