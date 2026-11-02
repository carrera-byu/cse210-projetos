public class Emprego
{
    public string _cargo;
    public string _empresa;
    public int _anoInicio;
    public int _anoFim;

    public void Exibir()
    {
        System.Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim}");
    }
}