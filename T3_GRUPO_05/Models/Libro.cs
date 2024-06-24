using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_GRUPO_05.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El tema es obligatorio")]
        public string Tema { get; set; }
        [Required(ErrorMessage = "El editorial es obligatorio")]
        public string Editorial { get; set; }
        [Required(ErrorMessage = "El año de publicación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de publicación es es entre 1900 a 3000")]
        public int AnioPublicacion { get; set; }
        [Required(ErrorMessage = "La cantidad de páginas son obligatorias")]
        [Range(10, 1000, ErrorMessage = "La cantidad de páginas es es entre 10 a 1000")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string Categoria { get; set; }

    }
}
