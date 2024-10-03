using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class FuncionarioValidation3 : AbstractValidator<Funcionario>
    {
        public FuncionarioValidation3()
        {
            RuleFor(Funcionario => Funcionario.Pais).NotEmpty().Length(1, 50).WithMessage("O país não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Estado).NotEmpty().Length(1, 50).WithMessage("O estado não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Cidade).NotEmpty().Length(1, 50).WithMessage("A cidade não pode ser vazia e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Bairro).NotEmpty().Length(1, 50).WithMessage("O bairro não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Rua).NotEmpty().Length(1, 50).WithMessage("A rua não pode ser vazia e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Cep).NotEmpty().Length(1, 50).WithMessage("O cep não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Numero).NotEmpty().Length(1, 50).WithMessage("O numero não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Complemento).NotEmpty().Length(1, 50).WithMessage("O complemento não pode ser vazio e deve ter o tamanho de 1 a 50 caracteres");


        }
    }
}

