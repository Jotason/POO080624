using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVehiculos : MonoBehaviour
{
    public int cantidad = 10;
    void Start()
    {
        Carro carro = new Carro { nombre = "coche deportivo", velocidad = 200, capacidadCombustible = 50, combustibleActual = 20, numeroPuertas = 2 };
        carro.Acelerar();
        carro.Frenar();
        carro.Tanquear(cantidad);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
