namespace Curso_Entity_Framework.Models
{
    public class Categoria
    {
        public Guid CategoriadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection <Tarea> Tareas { get; set; }
    }
}
