using CentarlDeUsuarios.Domain.Core;
using CentralUsuarios.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralUsuarios.Domain.Entities
{
    /// <summary>
    /// modelo de entidade de domínio
    /// </summary>
    public class Usuario : IEntity<Guid>
    {
        public Guid Id { get; set;}
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public ValidationResult Validate => new UsuarioValidation().Validate(this);

        
    }
}
