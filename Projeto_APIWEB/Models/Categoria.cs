﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto_APIWEB.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]

        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
