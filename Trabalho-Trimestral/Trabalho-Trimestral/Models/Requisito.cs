using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Models
{
    public class Requisito
    {
        public int Id { get; set; }

        
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Informe a descrição")]
        [StringLength(200)]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "Informe a data prevista")]
        [DataType(DataType.Date,ErrorMessage = "Informe a data prevista")]
        public DateTime DataPrevista { get; set; }

        [Required(ErrorMessage = "Informe o tipo")]
        public bool Funcional { get; set; }

        public IEnumerable<Bug> Bugs { get; set; }
        public IEnumerable<Atribuicao> Atribuicoes { get; set; }
        public Projeto Projeto { get; set; }

        [NotMapped]
        public int[] Desenvolvedores { get; set; }
    }
}
