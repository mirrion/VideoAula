﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class OrdemAPI
    {
        [Key]
        public int OrdemId { get; set; }

        public DateTime OrdemData { get; set; }

        public Customizar customizar { get; set; }

        public OrdemStatus OrdemStatus { get; set; }

        public ICollection<OrdemDetalhe>Detalhes  { get; set; }
    }
}