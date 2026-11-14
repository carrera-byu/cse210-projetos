using System;
using System.Collections.Generic;
using System.Linq;
public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        foreach (string palavraTexto in texto.Split(' '))
        {
            _palavras.Add(new Palavra(palavraTexto));
        }
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        List<Palavra> visiveis = _palavras.Where(p => !p.EstaOculta()).ToList();
        if (visiveis.Count == 0)
        {
            return;
        }
        if (quantidade > visiveis.Count)
        {
            quantidade = visiveis.Count;
        }

        Random random = new Random();
        for (int i = 0; i < quantidade; i++)
        {
            int indice = random.Next(visiveis.Count);
            visiveis[indice].Ocultar();
            visiveis.RemoveAt(indice);
        }
    }

    public string GetTextoExibicao()
    {
        string texto = _referencia.GetTextoExibicao() + "\n";
        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.GetTextoExibicao() + " ";
        }
        return texto;
    }

    public bool EstaCompletamenteOculta()
    {
        return _palavras.All(p => p.EstaOculta());
    }
}