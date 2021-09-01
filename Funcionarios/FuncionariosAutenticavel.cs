namespace aula_csharp_oop_funcionario.Funcionarios
{
    public abstract class FuncionariosAutenticavel : Funcionarios, IAutenticavel
    {
        public string Senha{ get; set; }
        protected FuncionariosAutenticavel(long cpf, double salario) : base(cpf, salario)
        {
        }

        public bool Autenticar(string senha)
        {
            return (Senha == senha);    
        }
    }
}