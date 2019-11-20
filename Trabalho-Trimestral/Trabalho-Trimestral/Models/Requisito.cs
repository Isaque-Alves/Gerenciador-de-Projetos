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
        [DataType(DataType.Date, ErrorMessage = "Informe a data prevista")]
        public DateTime DataPrevista { get; set; }

        [Required(ErrorMessage = "Informe o tipo")]
        public bool Funcional { get; set; }

        public IEnumerable<Bug> Bugs { get; set; }
        public ICollection<Atribuicao> Atribuicoes { get; set; }
        public Projeto Projeto { get; set; }

        [NotMapped]
        public int[] Desenvolvedores { get; set; }

        public int TempoGastoo()
        {
            int dias = 0;

            if (DataCadastro < DataPrevista)
            {
                dias = (DataPrevista.Day - DataCadastro.Day) + (DataPrevista.Month - DataCadastro.Month) * 30 + (DataPrevista.Year - DataCadastro.Year) * 360;
            }




            return dias;
        }

        public int TempoGasto => (int) DataPrevista.Subtract(DataCadastro).TotalDays;

        public static int ComparaDatas(Requisito r1, Requisito r2)
        {
            if (r1.TempoGasto < r2.TempoGasto)
            {
                return 1;
            }
            else if (r1.TempoGasto == r2.TempoGasto)
            {
                return 0;
            }

            return -1;
        }
    }
}
