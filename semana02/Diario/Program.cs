using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePrompts gerador = new GeradorDePrompts();
        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            escolha = Console.ReadLine();
            Console.WriteLine();

            if (escolha == "1")
            {
                string prompt = gerador.ObterPromptAleatorio();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Registro novoRegistro = new Registro();
                novoRegistro._data = DateTime.Now.ToString("dd/MM/yyyy");
                novoRegistro._textoPrompt = prompt;
                novoRegistro._resposta = resposta;

                diario.AdicionarRegistro(novoRegistro);
            }
            else if (escolha == "2")
            {
                diario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.CarregarDeArquivo(arquivo);
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.SalvarParaArquivo(arquivo);
            }
        }
    }
}