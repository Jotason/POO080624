using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoGuerrero : UnoPersonaje
{

    public int energia = 0;
    public override string Ataque()
    {

        return clase + " est� " + ataque + " a un mounstruo con " + arma + " y le caus� +" + danio + " de da�o y perdi� "+energia+" de energ�a";

    }

    public override string Defensa()
    {

        return clase + " est� " + defensa + " de un mounstruo con " + arma + " y se est� defendiendo ";

    }
}
