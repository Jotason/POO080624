using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoArquero : UnoPersonaje
{

    public int flechas = 0;

    public override string Ataque()
    {

        return clase + " est� " + ataque + " a un mounstruo con " + arma + " y le caus� +" + danio + " de da�o y gast� "+flechas;

    }



    public override string Defensa()
    {

        return clase + " est� " + defensa + " de un mounstruo con " + arma + " y se est� defendiendo ";

    }
}
