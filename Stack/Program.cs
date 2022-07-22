using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Stack (Pilha)");

            Stack<Livros> livros = new Stack<Livros>();

            livros.Push(new Livros("O Senhor dos Anéis"));
            livros.Push(new Livros("A Culpa é das Estrelas"));
            livros.Push(new Livros("Jogos Vorazes"));

            Console.WriteLine();
            Console.WriteLine($"O primeiro livro da pilha é: {livros.Peek()} \n ");

            //livros.Pop(); //remove o primeiro da pilha
            Console.WriteLine($"O livro {livros.Pop()} foi retirado \n");

            Console.WriteLine($"Existem {livros.Count} livros na pilha \n");

            Console.WriteLine($"Os livros disponiveis neste momento são:");

            foreach (Livros livro in livros)
            {
                Console.WriteLine($"- {livro}");
            }
        }
        public class Livros
        {
            public string Nome { get; set; }
            public Livros(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
