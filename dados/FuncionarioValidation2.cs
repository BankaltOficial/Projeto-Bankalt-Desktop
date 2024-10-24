using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    public class FuncionarioValidation2: AbstractValidator<Funcionario>
    {
        public FuncionarioValidation2()
        {
            RuleFor(Funcionario => Funcionario.Rg).NotEmpty().Length(8, 10).WithMessage("O RG do funcionário não pode ser vazio e deve ter de 8 a 10 digitos");
            RuleFor(Funcionario => Funcionario.Datanascimento).NotEmpty().WithMessage("A Data de nascimento não pode ser vazia e deve satisfazer a esse formato: 11/11/1111");
            RuleFor(Funcionario => Funcionario.Cargo).NotEmpty().Length(1, 50).WithMessage("O cargo não pode ser vazio");
            RuleFor(Funcionario => Funcionario.Estadocivil).NotEmpty().Length(1, 50).WithMessage("O Estado Civíl não pode ser vazio");
        }
    }
}
