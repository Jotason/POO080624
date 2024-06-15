using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UnoControladorPersonaje : MonoBehaviour
{
    private UnoArquero arc;
    private UnoGuerrero gue;
    private UnoMago mag;

    private UnoPersonaje persObj;

    public TextMeshProUGUI infoPersonaje;
    public TextMeshProUGUI infoEstado;


    void Start()
    {
        arc = new UnoArquero { clase = "arquero", arma = "arco", ataque = "A distancia", defensa = "esquivo", danio = 20, flechas = 15 };
        gue = new UnoGuerrero { clase = "Guerrero", arma = "espada", ataque = "Cercano", defensa = "tanqueo", danio = 30, energia = 20 };
        mag = new UnoMago { clase = "Mago", arma = "Baston", ataque = "Magico", defensa = "escudo magico", danio = 15, mana = 15 };


    }

    public void SeleccionarJugador(UnoPersonaje unoPersonaje)
    {
        persObj = unoPersonaje;
        ActualizarPersonaje();
    }

    public void Atacar()
    {
        if (persObj != null)
        {
            infoEstado.text = persObj.Ataque();
            ActualizarPersonaje();
        }
    }

    public void Defender()
    {
        if (persObj != null)
        {
            infoEstado.text = persObj.Defensa();
            ActualizarPersonaje();
        }
    }
    public void ActualizarPersonaje()
    {
        infoPersonaje.text = $"Clase: {persObj.clase}\n" +
                                    $"Arma: {persObj.arma}\n" +
                                    $"Ataque: {persObj.ataque}\n" +
                                    $"Defensa: {persObj.defensa}\n" +
                                    $"Deño: {persObj.danio}";
    }


}
