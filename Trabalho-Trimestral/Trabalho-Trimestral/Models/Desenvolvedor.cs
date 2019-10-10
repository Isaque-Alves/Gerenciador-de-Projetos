using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Trimestral.Models
{
    public class Desenvolvedor
    {
        public int Id { get; set; }
  
        [Required(ErrorMessage ="Informe o Nome")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [StringLength(100)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe")]
        public bool Admin { get; set; }

        [InverseProperty("Desenvolvedor")]
        public IEnumerable<Bug> BugsCriados { get; set; }

        [InverseProperty("DesenvolvedorSolucionador")]
        public IEnumerable<Bug> BugsSolucionados { get; set; }

        public IEnumerable<Atribuicao> Atribuicoes { get; set; }
    }
}
