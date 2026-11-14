// ============================================================================
// CRIATIVIDADE - ALÉM DOS REQUISITOS:
// ============================================================================
// O que eu fiz para ir além do que foi pedido:
//
// 1. BIBLIOTECA DE ESCRITURAS:
//    Em vez de usar apenas UMA escritura fixa como pede o requisito básico,
//    criei uma biblioteca (List<Escritura>) com 5 escrituras diferentes:
//    João 3:16, Provérbios 3:5-6, Salmos 23:1, Filipenses 4:13 e
//    Doutrina e Convênios 4:2. O programa escolhe uma aleatoriamente
//    a cada vez que é executado com new Random(), então cada execução
//    é uma experiência diferente.
//
// 2. NÍVEIS DE DIFICULDADE:
//    O usuário escolhe no início: 1 = Fácil (oculta 3 palavras por ENTER),
//    2 = Médio (oculta 5 palavras) e 3 = Difícil (oculta 8 palavras).
//    Isso permite praticar de acordo com o nível de memorização.
//
// 3. CONTADOR DE TENTATIVAS E MENSAGEM FINAL:
//    Criei a variável 'tentativas' que conta quantas vezes o usuário
//    apertou ENTER. Quando a escritura fica completamente oculta, o
//    programa mostra: "Parabéns! Você memorizou em X tentativas!"
//
// 4. LÓGICA INTELIGENTE PARA OCULTAR:
//    Em Escritura.OcultarPalavrasAleatorias(), eu primeiro filtro só as
//    palavras que ainda estão visíveis com .Where(p => !p.EstaOculta()).
//    Assim o programa nunca tenta ocultar uma palavra que já está oculta
//    e nunca trava em loop infinito. Se faltam menos palavras visíveis
//    do que a quantidade pedida, ele ajusta a quantidade automaticamente.
//
// 5. OPÇÃO DE SAIR:
//    O usuário pode digitar 'sair' a qualquer momento para encerrar
//    o programa, além de terminar automaticamente quando tudo está oculto.
//
// ============================================================================

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Escritura> biblioteca = new List<Escritura>
        {
            new Escritura(new Referencia("João", 3, 16), "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna"),
            new Escritura(new Referencia("Provérbios", 3, 5, 6), "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento Reconhece-o em todos os teus caminhos e ele endireitará as tuas veredas"),
            new Escritura(new Referencia("Salmos", 23, 1), "O Senhor é o meu pastor nada me faltará"),
            new Escritura(new Referencia("Filipenses", 4, 13), "Tudo posso naquele que me fortalece"),
            new Escritura(new Referencia("Doutrina e Convênios", 4, 2), "Portanto ó vós que embarcais a serviço de Deus vede que o sirvais de todo o coração poder mente e força")
        };

        Random random = new Random();
        Escritura escritura = biblioteca[random.Next(biblioteca.Count)];

        Console.WriteLine("Bem-vindo ao Memorizador de Escrituras!");
        Console.WriteLine("Escolha a dificuldade: 1 = Fácil (3), 2 = Médio (5), 3 = Difícil (8)");
        Console.Write("Digite 1, 2 ou 3: ");
        string escolha = Console.ReadLine();

        int quantidade = 3;
        if (escolha == "2") quantidade = 5;
        if (escolha == "3") quantidade = 8;

        int tentativas = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.GetTextoExibicao());
            Console.WriteLine();
            Console.WriteLine($"Tentativas: {tentativas}");
            Console.WriteLine("Pressione ENTER para ocultar mais palavras ou digite 'sair' para terminar.");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            tentativas++;
            escritura.OcultarPalavrasAleatorias(quantidade);

            if (escritura.EstaCompletamenteOculta())
            {
                Console.Clear();
                Console.WriteLine(escritura.GetTextoExibicao());
                Console.WriteLine();
                Console.WriteLine($"Parabéns! Você memorizou em {tentativas} tentativas!");
                break;
            }
        }
    }
}