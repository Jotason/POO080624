using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion : Vehiculo
{
    public int numeroPuertas, capacidadCarga, cargaActual;
    
    public override void Acelerar() { 
        Debug.Log(nombre + " está acelerando a" + velocidad + " km/h");
    }
}
