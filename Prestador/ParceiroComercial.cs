namespace aula_csharp_oop_funcionario.Prestador
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; private set; }
        public ParceiroComercial(string senha)
        {
            Senha = senha;
        }


        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
