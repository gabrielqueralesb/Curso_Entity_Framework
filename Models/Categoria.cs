using System.ComponentModel.DataAnnotations;

namespace Curso_Entity_Framework.Models
{
    public class Categoria
    {
      //  [Key] //Configuración de CategoriaID, indica que es Key
        public Guid CategoriadId { get; set; }
        //[Required] //Configuracion de Nombre, Indique que es requerido el nombre
        //[MaxLength(150)]//Indica que nombre tendra como maximo 150 caracteres
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection <Tarea> Tareas { get; set; }
    }
}
