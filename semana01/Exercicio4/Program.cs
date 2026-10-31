using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;
        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Por favor, digite um número válido!");
                continue;
            }

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        if (numeros.Count == 0)
        {
            Console.WriteLine("Nenhum número foi inserido.");
            return;
        }

        // 1. Soma
        int soma = 0;
        foreach (int n in numeros)
        {
            soma += n;
        }

        // 2. Média
        double media = (double)soma / numeros.Count;

        // 3. Maior número
        int maior = numeros[0];
        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }

        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maior}");

        // DESAFIO EXTRA: Menor positivo
        int menorPositivo = int.MaxValue;
        bool temPositivo = false;
        foreach (int n in numeros)
        {
            if (n > 0 && n < menorPositivo)
            {
                menorPositivo = n;
                temPositivo = true;
            }
        }

        if (temPositivo)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        // DESAFIO EXTRA: Lista ordenada
        numeros.Sort();
        Console.WriteLine("A lista reordenada é:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}