using System;

class Program
{
    static void Main(string[] args)
    {
        string escolha = "";

        while (escolha != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu - Programa de Introspecção");
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                AtividadeDeRespiracao atividade = new AtividadeDeRespiracao();
                atividade.Executar();
            }
            else if (escolha == "2")
            {
                AtividadeDeReflexao atividade = new AtividadeDeReflexao();
                atividade.Executar();
            }
            else if (escolha == "3")
            {
                AtividadeDeListagem atividade = new AtividadeDeListagem();
                atividade.Executar();
            }
            else if (escolha == "4")
            {
                Console.WriteLine("Até mais!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                Console.ReadLine();
            }
        }
    }
}