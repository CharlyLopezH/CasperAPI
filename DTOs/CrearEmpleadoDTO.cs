using System.ComponentModel.DataAnnotations;

namespace CasperAPI.DTOs
{
    public class CrearEmpleadoDTO
    {
        public required int Codigo { get; set; }
        public required string Nombres { get; set; } = null!;
        public required string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public string CURP { get; set; } = null!;
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; } = null!;
        public IFormFile? Foto { get; set; }
        public required int AdscripcionId { get; set; }

    }
}
