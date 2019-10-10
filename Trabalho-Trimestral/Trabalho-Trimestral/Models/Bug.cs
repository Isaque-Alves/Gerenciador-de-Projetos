using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe a prioridade")]
        [StringLength(50)]
        public string Prioridade { get; set; }
        

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Informe se ja foi resolvido")]
        public bool Resolucao { get; set; }

        
        public int DesenvolvedorId { get; set; }


        public int DesenvolvedorSolucionadorId { get; set; }

        public int RequisitoId { get; set; }

        [ForeignKey("DesenvolvedorId")]
        public Desenvolvedor Desenvolvedor { get; set; }

        [ForeignKey("DesenvolvedorSolucionadorId")]
        public Desenvolvedor DesenvolvedorSolucionador { get; set; }
        public Requisito Requisito { get; set; }
    }
}
