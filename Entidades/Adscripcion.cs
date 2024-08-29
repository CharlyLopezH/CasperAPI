using System.ComponentModel.DataAnnotations;

namespace CasperAPI.Entidades
{
    public class Adscripcion
    {
        public int Id { get; set; }
        [Required]        
        [StringLength(60, ErrorMessage = "El nombre no puede tener más de 60 caracteres.")]
        public string Nombre { get; set; } = null!;
        [Required]
        [StringLength(10, ErrorMessage = "El nombre no puede tener más de 10 caracteres.")]
        public string Siglas { get; set; } = null!;             
        //Una Adscripción tiene muchos empleados; propiedad de navegación
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();

    }
}
