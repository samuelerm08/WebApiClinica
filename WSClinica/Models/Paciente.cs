using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WSClinica.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        public int PacienteId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Apellido { get; set; }
        public int NrioHistClinica { get; set; }
        public Medico Medico { get; set; }
    }
}
