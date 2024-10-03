using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompRotatorio : MonoBehaviour
{
    [Serializefield]
    float rotacionY = 10f;
    void Update()
    {
        transform.Rotate(0.0f, 10f * Time.deltaTime, 0f);
    }
}