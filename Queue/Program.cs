using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Queue (Fila) \n");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Henrique", "São Paulo", 25));
            pessoas.Enqueue(new Pessoa("Carol", "Toronto", 28));
            pessoas.Enqueue(new Pessoa("Marcos", "Tokyo", 17));
            pessoas.Enqueue(new Pessoa("Jenifer", "Rio de Janeiro", 21));
            pessoas.Enqueue(new Pessoa("Jorge", "Londres", 32));

            Console.WriteLine($"O primeiro da fila:  {pessoas.Dequeue()}");

            pessoas.Peek(); //O primeiro da fila foi reirado

            Console.WriteLine($"Restam {pessoas.Count} pessoas na fila");

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"As pessoas na fila são: {pessoa} ");
            }
        }
        public class Pessoa
        {
            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, string cidade, int idade)
            {
                Nome = nome;
                Cidade = cidade;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
            }
        }
    }
}
