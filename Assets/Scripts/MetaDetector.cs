using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaDetector : MonoBehaviour
{
    [Serializefield]
    GameObject pantallaFinal; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<PlayerMovement>().enabled = false;
        }
    }

}
