using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
        static string PedirDado(string dado)
        {
            Console.WriteLine(dado + ": ");
            return Console.ReadLine();
        }
    }
}
