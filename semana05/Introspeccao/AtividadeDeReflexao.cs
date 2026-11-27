using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao() : base("Reflexão", "Esta atividade ajudará você a refletir sobre momentos em que você demonstrou força e resiliência.", 30)
    {
        _reflexoes = new List<string>()
        {
            "Pense em um momento em que você defendeu alguém.",
            "Pense em um momento em que você fez algo realmente difícil.",
            "Pense em um momento em que você ajudou alguém em necessidade.",
            "Pense em um momento em que você fez algo realmente altruísta."
        };

        _perguntas = new List<string>()
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que torna essa experiência diferente de outras?",
            "O que você aprendeu sobre si mesmo através dessa experiência?",
            "O que você poderia aprender com essa experiência que se aplica a outras situações?",
            "Como você pode manter essa experiência em mente no futuro?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        Console.WriteLine("Considere o seguinte prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {ObterReflexoesAleatorias()} ---");
        Console.WriteLine();
        Console.WriteLine("Quando você tiver algo em mente, pressione Enter para continuar.");
        Console.ReadLine();
        Console.WriteLine("Agora reflita sobre as perguntas relacionadas a essa experiência.");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime fim = DateTime.Now.AddSeconds(_duracao);
        while (DateTime.Now < fim)
        {
            Console.WriteLine($"> {ObterPerguntasAleatorias()}");
            ExibirProgresso(5);
        }

        ExibirMensagemFinal();
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();
        return _reflexoes[random.Next(_reflexoes.Count)];
    }

    public string ObterPerguntasAleatorias()
    {
        Random random = new Random();
        return _perguntas[random.Next(_perguntas.Count)];
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine(ObterReflexoesAleatorias());
    }

    public void ExibirPerguntas()
    {
        Console.WriteLine(ObterPerguntasAleatorias());
    }
}