using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Vehicule : MonoBehaviour
{
    [SerializeField] public string nombre = "";
    [SerializeField] public float velocidad = 0f;
    [SerializeField] public int capacidadCombustible = 0;
    [SerializeField] public int combustibleActual = 0;

    public virtual void Acelerar()
    {
        Debug.Log(nombre + " está acelerando a" + velocidad + " km/h");
    }

    public void Frenar()
    {
        Debug.Log(nombre + " está frenando ");
    }

    public void Tanquear(int cantidad) {
        combustibleActual += cantidad;
        if (combustibleActual > capacidadCombustible)
        {
            combustibleActual = capacidadCombustible;
        }

        Debug.Log(nombre + " a tanqueado.Combustible actual "+combustibleActual );
    }
}
