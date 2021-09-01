using System;

namespace aula_csharp_oop_funcionario.Sistemas
{
    public class SistemaInterno
    {
        public void Logar(IAutenticavel autenticavel, string senha){
            bool usuarioAutenticado = autenticavel.Autenticar(senha);
            
            if (usuarioAutenticado){
                Console.WriteLine("Seja Bem Vindo");
            }
                
            else{
                Console.WriteLine("Senha Invalida");
            }
            
        }
    }
}