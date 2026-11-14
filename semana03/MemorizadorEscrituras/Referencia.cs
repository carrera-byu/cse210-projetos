using System;
using System.Collections.Generic;
using System.Linq;
public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _versiculoFinal;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _versiculoFinal = 0;
    }

    public Referencia(string livro, int capitulo, int versiculoInicio, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculoInicio;
        _versiculoFinal = versiculoFinal;
    }

    public string GetTextoExibicao()
    {
        if (_versiculoFinal != 0)
        {
            return $"{_livro} {_capitulo}:{_versiculo}-{_versiculoFinal}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
    }
}