using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    public class Planilla
    {
        public int PlanillaId { get; set; }
        public int CarreraId { get; set; }
        public int MateriaId { get; set; }
        public int ProfesorId { get; set; }
        public int CursoId { get; set; }    
        public DateTime Fecha { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera Carrera { get; set; }
        [ForeignKey("MateriaId")]
        public Materia Materia { get; set; }
        [ForeignKey("ProfesorId")]
        public Profesor Profesor { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set;}
    }
}
