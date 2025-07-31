using CadastroUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Usuario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Usuario user = new Usuario(nome, idade);
        user.Exibir();
    }
}

