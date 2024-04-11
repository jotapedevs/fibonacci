using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        List<int> fibonacciSequence = new List<int> {0, 1}; // Inicia a sequência com os dois primeiros números

        // Gera a sequência de Fibonacci até o número informado
        while (fibonacciSequence[fibonacciSequence.Count - 1] < num)
        {
            int nextNumber = fibonacciSequence[fibonacciSequence.Count - 1] + fibonacciSequence[fibonacciSequence.Count - 2];
            fibonacciSequence.Add(nextNumber);
        }

        // Verifica se o número informado pertence à sequência de Fibonacci
        if (fibonacciSequence.Contains(num))
        {
            Console.WriteLine("O número " + num + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número " + num + " não pertence à sequência de Fibonacci.");
        }
    }
}
