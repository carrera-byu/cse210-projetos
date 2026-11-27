using System;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() : base("Respiração", "Esta atividade ajudará você a relaxar respirando devagar e com atenção.", 30)
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime fim = DateTime.Now.AddSeconds(_duracao);
        while (DateTime.Now < fim)
        {
            Console.WriteLine();
            Console.Write("Inspire... ");
            ExibirContagemRegressiva(4);
            Console.WriteLine();
            Console.Write("Expire... ");
            ExibirContagemRegressiva(6);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}