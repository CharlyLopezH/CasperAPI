using System.ComponentModel.DataAnnotations;

namespace CasperAPI.DTOs
{
    public class CrearChecdaDTO
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaHoraChecada { get; set; }        
        public string Dispositivo { get; set; } = "Demo";
    }
}
