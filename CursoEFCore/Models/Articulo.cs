using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEFCore.Models
{
    [Table("Tbl_Articulos")]
    public class Articulo
    {
        [Key]
        public int Articulo_Id { get; set; }
        [Column("Titulo")]
        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(20)]
        public string TituloArticulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Range(0.1, 5.0)]
        public double Calificacion { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
    }
}
