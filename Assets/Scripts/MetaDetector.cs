using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MetaDetector : MonoBehaviour
{
    [Serializefield]
    GameObject pantallaFinal;


    [Serializefield]
    TextMeshProUGUI textLabelTime;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<PlayerMovement>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();
        }
    }

}
