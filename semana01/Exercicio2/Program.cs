using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota percentual? ");
        string entrada = Console.ReadLine();
        int porcentagem = int.Parse(entrada);

        string letra = "";
        string sinal = "";

        if (porcentagem >= 90)
        {
            letra = "A";
        }
        else if (porcentagem >= 80)
        {
            letra = "B";
        }
        else if (porcentagem >= 70)
        {
            letra = "C";
        }
        else if (porcentagem >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        // Desafio: + e -
        int ultimoDigito = porcentagem % 10;

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }
        else
        {
            sinal = "";
        }

        // Exceções: A+ -> A, e F+ F- -> F
        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }

        if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"Sua nota é: {letra}{sinal}");

        if (porcentagem >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado!");
        }
        else
        {
            Console.WriteLine("Não foi dessa vez, continue se esforçando!");
        }
    }
}