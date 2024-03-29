﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveBank.Entities.Models
{
    public class WebToken
    {
        [Key]
        public Guid Id { get; set; }
        public string Token { get; set; } = null!;
        [ForeignKey("Usuario")]
        public string UsuarioID { get; set; } = null!;
        public virtual Usuario Usuario { get; set; } = null!;
        public DateTime DataCriado { get; set; }
        public DateTime ExpiracaoToken { get; set; }
    }
}
