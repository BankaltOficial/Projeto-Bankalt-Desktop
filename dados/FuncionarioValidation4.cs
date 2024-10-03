using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class FuncionarioValidation4 : AbstractValidator<Funcionario>
    {
        public FuncionarioValidation4()
        {
            RuleFor(Funcionario => Funcionario.Celular).NotEmpty().Length(11).WithMessage("O celular não pode ser vazio e deve ter o tamanho de 11 caracteres contando com o ddd");
            RuleFor(Funcionario => Funcionario.Telefone).Length(10).WithMessage("O telefone não pode ser vazio e deve ter o tamanho de 10 caracteres contando com o ddd");
            RuleFor(Funcionario => Funcionario.Contatoemergencia).Length(11).WithMessage("O contato de emergencia não pode ser vazio e deve ter o tamanho de 11 caracteres contando com o dd");
            RuleFor(Funcionario => Funcionario.Email).NotEmpty().EmailAddress().Length(1,50).WithMessage("O email deve ser compativel com o formato e deve ser entre 1 a 50 caracteres");
            RuleFor(Funcionario => Funcionario.Salario).NotEmpty().WithMessage("O salario não pode conter letras e espaços");
        }
    }
}
