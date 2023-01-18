using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curso_Entity_Framework.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId { get; set; }
        [ForeignKey("CategoriaId")]
        [MaxLength(200)]
        public Guid CategoriaId { get; set;}
        [Required]
        [MaxLength(200)]
        public string Titulo { get; set;}
        public string Descripcion { get; set;}

        public Prioridad PrioridadTarea { get; set;}
        public DateTime FechaCreacion { get; set;}
        public Categoria Categoria { get; set;}
        [NotMapped]//Omite el campo para la creación de base de datos
        public string Resumen { get; set;}
    }
    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}

