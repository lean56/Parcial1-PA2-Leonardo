using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="El Semestre es Obligatorio!!!")]
        public string Semestre { get; set; }
        [Range(minimum:1,maximum:28,ErrorMessage ="El limite de creditos es 28")]
        public int Limite { get; set; }
        [Range(minimum: 1, maximum: 28, ErrorMessage = "El limite de creditos tomado es 28")]
        public int Tomados { get; set; }
        public int Disponible { get; set; }
        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
        }
    }
}
