using System;
using System.Collections.Generic;
using System.Linq;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int>(){}; 

            string aluno;

            int media;

            Console.Write("Digite aqui o nome do aluno: ");
            aluno = Console.ReadLine();

            for(int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o valor da nota {i}: ");
                notas.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();

            media = notas.Sum(x => Convert.ToInt32(x)) / 5;

            Console.WriteLine($"Exibindo agora as nota do aluno: {aluno}");

            notas.ForEach(i => Console.Write($"{i} "));

            Console.WriteLine();

            Console.WriteLine($"A media do aluno foi {media}");

            if(media >= 7)
            {   
                Console.WriteLine("E o aluno foi aprovado");
            }
            else 
            {
                Console.WriteLine("E o aluno foi reprovado");
            }
        }
    }
}
