using System;

namespace aula_csharp_oop_funcionario.Funcionarios
{
    public class Diretor : Funcionarios
    {
        public Diretor(long cpf, double salario = 10000) : base(cpf, salario)
        {
            Console.WriteLine("Construtor do Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}