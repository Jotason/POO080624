using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoGuerrero : UnoPersonaje
{

    public int energia = 0;
    public override string Ataque()
    {

        return clase + " está " + ataque + " a un mounstruo con " + arma + " y le causó +" + danio + " de daño y perdió "+energia+" de energía";

    }

    public override string Defensa()
    {

        return clase + " está " + defensa + " de un mounstruo con " + arma + " y se está defendiendo ";

    }
}
