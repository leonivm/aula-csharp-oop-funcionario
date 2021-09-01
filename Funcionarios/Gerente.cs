using System;

namespace aula_csharp_oop_funcionario.Funcionarios
{
    public class Gerente : FuncionariosAutenticavel
    {
        public Gerente(long cpf, double salario = 5000) : base(cpf, salario)
        {
            Console.WriteLine("Construtor do Gerente");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario*0.5;
        }
    }
}