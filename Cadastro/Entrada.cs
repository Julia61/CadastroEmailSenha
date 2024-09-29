using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Entrada
    {
        public string Email {  get; private set; }
        public string Senha { get; private set; }
        public string Nome { get; private set; }

        public void NomePessoa(string nomePessoa)
        {
            Nome = nomePessoa;
        }

        public void Cadastro(string emailCadastro,string senhaCadrastro)
        {
            Email = emailCadastro;
            Senha = senhaCadrastro;
        }

        public void Entrando(string emailEntrada,string senhaEntrada)
        {
            while(emailEntrada != Email || senhaEntrada != Senha)
            {
                Console.WriteLine();
                Console.WriteLine("Informações erradas! Tente novamente.");
                Console.Write("Digite seu email: ");
                emailEntrada = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                senhaEntrada = Console.ReadLine();
                
            }
            Console.WriteLine($"Seja bem-vindo, {Nome}");
            


        }
    }
}
