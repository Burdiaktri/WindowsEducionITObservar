using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int TipoId { get; set; }
        public int EstudianteId { get; set; }
        public int DetalleId { get; set; }
        public int Nota { get; set; }

        [ForeignKey("TipoId")]
        public Tipo Tipo { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        [ForeignKey("DetalleId")]
        public Detalle Detalle { get; set;
        }
    }
}
