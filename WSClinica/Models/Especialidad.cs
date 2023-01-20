using System.ComponentModel.DataAnnotations.Schema;

namespace WSClinica.Models
{
    [Table("Especialidad")]
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
    }
}
