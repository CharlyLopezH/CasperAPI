using System.ComponentModel.DataAnnotations;

namespace CasperAPI.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public required int Codigo { get; set; }        
        [StringLength(60, ErrorMessage = "El nombre no puede tener más de 60 caracteres.")]
        public required string Nombres { get; set; } = null!;        
        [StringLength(60, ErrorMessage = "El Apellido no puede tener más de 60 caracteres.")]
        public required string PrimerApellido { get; set; }
        
        [StringLength(60, ErrorMessage = "El nombre no puede tener más de 60 caracteres.")]
        public string? SegundoApellido { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public string CURP { get; set; } = null!;

        [StringLength(80, ErrorMessage = "El email no puede tener más de 80 caracteres.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public required string Email { get; set; } = null!;
        
        [StringLength(200, ErrorMessage = "La ruta de la fotografía no puede exceder 200 chars.")]
        public string? Foto { get; set; }
        public required int AdscripcionId { get; set; }

        //Un Empleado tiene much; propiedad de navegación
        public List<Checada> Checadas { get; set; } = new List<Checada>();


    }
}
