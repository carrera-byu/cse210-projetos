public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        _estaOculta = false;
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    public string ObterTexto()
    {
        if (_estaOculta)
        {
            string oculto = "";
            foreach (char c in _texto)
            {
                oculto += "_";
            }
            return oculto;
        }
        else
        {
            return _texto;
        }
    }
}