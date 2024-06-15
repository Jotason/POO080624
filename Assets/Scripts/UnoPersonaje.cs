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

        return clase + " está " +ataque+ " a un mounstruo con " +arma+  " y le causó +" + danio+" de daño";
    
    }

    public virtual string Defensa()
    {

        return clase + " está " + defensa + " de un mounstruo con " + arma + " y se está defendiendo ";

    }
}
