using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TipoArma
{
    Pistola,
    Escopeta,
    Rifle

}
public class Controlador : MonoBehaviour
{
    public TipoArma armaActual;
    public TipoArma ArmaAnterior;
    public TipoArma ArmaSuperior;

    
    // Start is called before the first frame update
    void Start()
    {
        ArmaAnterior = armaActual;
        MostrarEstadoActual();
    }

    // Update is called once per frame
    void Update()
    {
        if (armaActual != ArmaAnterior) {
            ArmaAnterior = armaActual;
            
        }
        CambiarEstado();


        MostrarEstadoActual();

    }

    void CambiarEstado() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            armaActual = TipoArma.Pistola;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            armaActual = TipoArma.Rifle;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            armaActual = TipoArma.Escopeta;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            armaActual = ArmaSuperior;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            armaActual = ArmaSuperior;
        }
    }

    void MostrarEstadoActual() {
        Debug.Log(armaActual);
    }
}
