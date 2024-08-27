namespace CasperAPI.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public required int Codigo { get; set; }
        public required string Nombres { get; set; } = null!;
        public required string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public string CURP { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Foto { get; set; }
        public required int AdscripcionId { get; set; }

//        public required Adscripcion Adscripcion { get; set; } // Propiedad de navegación para la relación 1:1

    }
}
