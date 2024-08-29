using System.ComponentModel.DataAnnotations;

namespace CasperAPI.Entidades
{
    public class Checada
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaHoraChecada { get; set; }
        [StringLength(20, ErrorMessage = "El nombre del dispositivo no puede tener +20 caracteres.")]
        public string Dispositivo { get; set; } = "Demo";
    }
}
