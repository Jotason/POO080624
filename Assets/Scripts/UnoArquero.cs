using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoArquero : UnoPersonaje
{

    public int flechas = 0;

    public override string Ataque()
    {

        return clase + " está " + ataque + " a un mounstruo con " + arma + " y le causó +" + danio + " de daño y gastó "+flechas;

    }



    public override string Defensa()
    {

        return clase + " está " + defensa + " de un mounstruo con " + arma + " y se está defendiendo ";

    }
}
