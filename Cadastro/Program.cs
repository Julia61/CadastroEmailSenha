using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entrada entrada = new Entrada();
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            entrada.NomePessoa(nome);
            

            Console.Write("Cadrastre o seu email: ");
            string emailCadrastro = Console.ReadLine();
            Console.Write("Cadrastre sua senha: ");
            string senhaCadrastro = Console.ReadLine();
            entrada.Cadastro(emailCadrastro, senhaCadrastro);

            Console.WriteLine("Suas informações foram cadastradas!");
            Console.Write("Deseja entrar no programa (s/n): ");
            char escolha = char.Parse(Console.ReadLine());
            Console.WriteLine();

            while (escolha != 's' && escolha != 'n')
            {
                Console.WriteLine("Opção Inválida! Tente novamente.");
                Console.Write("Deseja entrar no programa (s/n): ");
                escolha = char.Parse(Console.ReadLine());
            }

            if(escolha == 's')
            {
                Console.Write("Digite seu email: ");
                string emailEntrada = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                string senhaEntrada = Console.ReadLine();
                entrada.Entrando(emailEntrada, senhaEntrada);
            }
            else
            {
                Console.WriteLine("Obrigado por se cadastrar.");
            }

            Console.ReadKey();
        }
    }
}
