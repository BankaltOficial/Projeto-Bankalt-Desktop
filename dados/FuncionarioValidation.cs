using FluentValidation;
using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class FuncionarioValidation:AbstractValidator<Funcionario>
    {
        public FuncionarioValidation()
        {
            RuleFor(Funcionario => Funcionario.Nome).NotEmpty().Length(1, 50).WithMessage("O nome do funcionário não pode ser vazio e deve ter o tamanho entre 1 e 50 caracteres");
            RuleFor(Funcionario => Funcionario.Cpf).NotEmpty().Length(11).WithMessage("O Cpf do funcionário não pode ser vazio e deve ter 11 digitos");
            RuleFor(Funcionario => Funcionario.Username).NotEmpty().Length(1, 50).WithMessage("O Usuário não pode ser vazio e deve ter o tamanho entre 1 e 50 caracteres");
            RuleFor(Funcionario => Funcionario.Senha).NotEmpty().WithMessage("A senha não pode ser vazia");
        }
    }
}
