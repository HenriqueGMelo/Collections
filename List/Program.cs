using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using List (Lista) \n");

            List<string> animais = new List<string>();

            animais.Add("Leão");
            animais.Add("Urso");
            animais.Add("Tigre");
            animais.Add("Foca");

            animais.Insert(1, "Elefante");

            animais.Remove("Foca");

            animais.RemoveAt(1);

            foreach (string animal in animais)
            {
                Console.WriteLine($"Este animal é o {animal}");
            }
        }
    }
}