using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Models
{
    public class Atribuicao
    {
        public int Id { get; set; }
        public int DesenvolvedorId { get; set; }
        public int RequisitoId { get; set; }

        [Required(ErrorMessage ="Informe o tempo gasto")]
        public int TempoGasto { get; set; }

        public Requisito Requisito;
        public Desenvolvedor Desenvolvedor;
    }
}
