namespace Curso_Entity_Framework.Models
{
    public class Tarea
    {
        public Guid TareaId { get; set; }
        public Guid CategoriaId { get; set;}
        public string Titulo { get; set;}
        public string Descripcion { get; set;}

        public Prioridad PrioridadTarea { get; set;}
        public DateTime FechaCreacion { get; set;}
        public Categoria Categoria { get; set;}
    }
    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}

