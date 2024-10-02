using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movimientoejeX;
    public float movimientoejeY;
    public float movimientoejeZ;
    public float velocidadMovimiento = 1.5f;

    void Update()
    {
        movimientoejeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoejeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoejeX, movimientoejeY, movimientoejeZ);
    }
}