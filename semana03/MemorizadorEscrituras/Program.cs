class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);
        Escritura escritura = new Escritura(referencia, "Confia no Senhor de todo o teu coração e não te apoies no teu próprio entendimento");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar.");

            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);

            if (escritura.EstaCompletamenteOculta())
            {
                Console.Clear();
                Console.WriteLine(escritura.ObterTexto());
                break;
            }
        }
    }
}