class Program
{
    static void Main(string[] args)
    {
        Fracao f1 = new Fracao();
        Fracao f2 = new Fracao(5);
        Fracao f3 = new Fracao(3, 4);
        Fracao f4 = new Fracao(1, 3);

        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());
        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());
        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());
        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());

        // Prueba de Getters y Setters
        f3.DefinirNumerador(6);
        f3.DefinirDenominador(7);
        Console.WriteLine($"Después del setter: {f3.ObterFracaoEmTexto()}");
        Console.WriteLine($"Numerador con getter: {f3.ObterNumerador()}");
    }
}