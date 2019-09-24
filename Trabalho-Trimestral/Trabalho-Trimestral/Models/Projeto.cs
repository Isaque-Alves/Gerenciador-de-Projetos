using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Models
{
    public class Projeto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o Nome")]
        [StringLength(200)]
        public string Nome { get; set; }


        
        public DateTime DataEntrega { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Informe o Soolicitante")]
        [StringLength(200)]
        public string Solicitante { get; set; }

        public IEnumerable<Requisito> Requisitos { get; set; }
    }
}
