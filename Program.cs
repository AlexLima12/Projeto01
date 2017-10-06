using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
          
          System.Console.WriteLine( "Digite os dados a seguir");       
            string nome, endereco, rg, idade, genero, estadoCivil, cidade, cpf, profissão, localNascimento;
            nome = PedirDado("Nome");
            endereco = PedirDado("Endereço");
            cidade = PedirDado("Cidade");
            rg = PedirDado("RG");
            cpf = PedirDado("CPF");
            estadoCivil = PedirDado("Estado Civil");
            localNascimento = PedirDado("Local de Nascimento");
            profissão = PedirDado("Profissão");
            idade = PedirDado("Idade");
            genero = PedirDado("Gênero");


            void MostrarDados()
            {
                System.Console.WriteLine("Os dados cadastrados são: ");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Endereço: " + endereco);
                Console.WriteLine("cidade: " + cidade);
                Console.WriteLine("RG: " + rg);
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("Estado civil: " + estadoCivil);
                System.Console.WriteLine("Local de nascimento: " + localNascimento);
                System.Console.WriteLine("Profissão:" + profissão );
                System.Console.WriteLine("Idade: " + idade);
                System.Console.WriteLine("Gênero: " + genero);

            }
            MostrarDados();
        }
        static string PedirDado(string dado)
        {
            Console.WriteLine(dado + ": ");
            return Console.ReadLine();
        }

        
    }
}
