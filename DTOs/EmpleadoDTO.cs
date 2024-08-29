namespace CasperAPI.DTOs
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public  int Codigo { get; set; }
        public  string Nombres { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public string CURP { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Foto { get; set; }
        public int AdscripcionId { get; set; }
    }
}

