using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : Vehicule
{
    public int numeroPuertas;
    
    public override void Acelerar() { 
        Debug.Log(nombre + " est� acelerando a" + velocidad + " km/h");
    }
}
