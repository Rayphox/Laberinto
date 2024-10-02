using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsCollisions : MonoBehaviour
{
    [Serializefield]
    Material materialPorDefecto;

    [Serializefield]
    Material materialParedTocada;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
        }
    }

}
