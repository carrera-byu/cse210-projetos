public class Registro
{
    public string _data;
    public string _textoPrompt;
    public string _resposta;

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data} - Prompt: {_textoPrompt}");
        Console.WriteLine($"{_resposta}");
        Console.WriteLine();
    }
}