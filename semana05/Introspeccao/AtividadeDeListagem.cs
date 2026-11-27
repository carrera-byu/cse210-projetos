using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private List<string> _perguntas;

    public AtividadeDeListagem() : base("Listagem", "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, listando o máximo que você conseguir.", 30)
    {
        _perguntas = new List<string>()
        {
            "Quem são pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são pessoas que você já ajudou esta semana?",
            "Quando você se sentiu o Espírito Santo este mês?",
            "Quem são alguns de seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine("Liste o máximo de respostas que puder para o seguinte prompt:");
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);
        Console.WriteLine($"--- {_perguntas[indice]} ---");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();

        DateTime fim = DateTime.Now.AddSeconds(_duracao);
        int contador = 0;
        while (DateTime.Now < fim)
        {
            Console.Write("> ");
            Console.ReadLine();
            contador++;
        }

        Console.WriteLine($"Você listou {contador} itens!");
        ExibirMensagemFinal();
    }
}