using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            Random geradorAleatorio = new Random();
            int numeroMagico = geradorAleatorio.Next(1, 101);
            int palpite = 0;
            int contadorPalpites = 0;
            bool acertou = false;

            while (palpite != numeroMagico && contadorPalpites < 5)
            {
                Console.Write($"Qual é o seu palpite? ({contadorPalpites + 1}/5): ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out palpite))
                {
                    Console.WriteLine("Por favor, digite um número!");
                    continue;
                }

                contadorPalpites++;

                if (palpite < numeroMagico)
                    Console.WriteLine("Mais alto");
                else if (palpite > numeroMagico)
                    Console.WriteLine("Mais baixo");
                else
                {
                    Console.WriteLine("Você adivinhou!");
                    Console.WriteLine($"Você usou {contadorPalpites} palpites.");
                    acertou = true;
                }
            }

            // Se usou 5 palpites e não acertou
            if (!acertou)
            {
                Console.WriteLine($"Você não conseguiu! O número mágico era {numeroMagico}");
            }

            Console.Write("Você quer jogar de novo? (sim/nao) ");
            jogarNovamente = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Obrigado por jogar!");
    }
}