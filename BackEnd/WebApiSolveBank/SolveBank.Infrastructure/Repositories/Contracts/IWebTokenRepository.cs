﻿using SolveBank.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveBank.Infrastructure.Repositories.Contracts
{
    public interface IWebTokenRepository
    {
        Task<WebToken> CadastrarToken(string usuarioID);        
    }
}
