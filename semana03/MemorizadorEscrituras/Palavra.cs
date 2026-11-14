using System;
using System.Collections.Generic;
using System.Linq;
public class Palavra
{
    private string _texto;
    private bool _oculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _oculta = false;
    }

    public void Ocultar()
    {
        _oculta = true;
    }

    public bool EstaOculta()
    {
        return _oculta;
    }

    public string GetTextoExibicao()
    {
        if (_oculta)
        {
            return new string('_', _texto.Length);
        }
        else
        {
            return _texto;
        }
    }
}