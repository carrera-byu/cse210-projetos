using System;
using System.Threading;

public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao, int duracao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = duracao;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à Atividade de {_nome}");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();
        Console.Write($"Quanto tempo, em segundos, você gostaria para a sua sessão? ");
        _duracao = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Prepare-se para começar...");
        ExibirProgresso(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!");
        ExibirProgresso(3);
        Console.WriteLine($"Você completou mais {_duracao} segundos da Atividade de {_nome}.");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        for (int i = 0; i < segundos; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}