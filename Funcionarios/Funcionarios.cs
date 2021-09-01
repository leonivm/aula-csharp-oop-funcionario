using System;

namespace aula_csharp_oop_funcionario.Funcionarios

{
    public abstract class Funcionarios
    {
        readonly long _cpf;
        public string Nome { get; set; }
        public double Salario { get; protected set; }
        public long CPF => _cpf;
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionarios(long cpf, double salario)
        {
                _cpf = cpf;
                Salario = salario;
                TotalDeFuncionarios++;
                Console.WriteLine("Construtor do Funcionário");
        }
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}