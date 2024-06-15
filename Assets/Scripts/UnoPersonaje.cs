using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnoPersonaje : MonoBehaviour
{

    [SerializeField] public string clase = "";
    [SerializeField] public string arma = "";
    [SerializeField] public string ataque = "";
    [SerializeField] public string defensa = "";
    [SerializeField] public int danio = 1;

    public virtual string Ataque() {

        return clase + " est� " +ataque+ " a un mounstruo con " +arma+  " y le caus� +" + danio+" de da�o";
    
    }

    public virtual string Defensa()
    {

        return clase + " est� " + defensa + " de un mounstruo con " + arma + " y se est� defendiendo ";

    }
}
