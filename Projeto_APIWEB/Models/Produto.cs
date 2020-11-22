using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto_APIWEB.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]

        [Required(ErrorMessage = "O campo Descrição é obrigatório!")]

        public string Descricao { get; set;  }

        [Range(1, 100, ErrorMessage = "Valor fora da Faixa, insira um valor entre 1 e 100")]
        public int Quantidade { get; set; }
       
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }

}
