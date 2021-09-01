using System;
using aula_csharp_oop_funcionario.Funcionarios;
using aula_csharp_oop_funcionario.Prestador;
using aula_csharp_oop_funcionario.Sistemas;

namespace aula_csharp_oop_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SistemaInterno f1 = new SistemaInterno();
            
            Diretor carlos = new Diretor(33628371821);
            carlos.Nome = "Carlos";
            
            Gerente manuel = new Gerente(17998287403, 12000);
            manuel.Nome = "Manuel";
            manuel.Senha = "manu";
            
            ParceiroComercial parceiro = new ParceiroComercial("123");

            f1.Logar(manuel,"nana");
            f1.Logar(parceiro,"123");



            Console.WriteLine("Total de Funcionários:" + Funcionarios.Funcionarios.TotalDeFuncionarios);


            // Console.ReadLine();

        }
    }
}
