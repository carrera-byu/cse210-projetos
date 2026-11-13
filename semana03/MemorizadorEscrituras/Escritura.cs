public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] partes = texto.Split(' ');
        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra(parte);
            _palavras.Add(palavra);
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random random = new Random();
        int ocultadas = 0;

        while (ocultadas < numeroParaOcultar)
        {
            int indice = random.Next(_palavras.Count);
            if (!_palavras[indice].EstaOculta())
            {
                _palavras[indice].Ocultar();
                ocultadas++;
            }

            if (EstaCompletamenteOculta())
            {
                break;
            }
        }
    }

    public string ObterTexto()
    {
        string texto = _referencia.ObterTexto() + " - ";
        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTexto() + " ";
        }
        return texto;
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }
        return true;
    }
}