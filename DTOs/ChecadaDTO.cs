using System.ComponentModel.DataAnnotations;

namespace CasperAPI.DTOs
{
    public class ChecadaDTO
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaHoraChecada { get; set; }        
        public string Dispositivo { get; set; } = "Demo";
    }
}
