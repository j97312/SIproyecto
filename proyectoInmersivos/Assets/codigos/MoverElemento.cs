using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverElemento : MonoBehaviour
{
    public float velocidadMovimiento = 5f;  

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            
            MoverDerecha();
        }
    }

    void MoverDerecha()
    {
        
        Vector3 posicionActual = transform.position;
        Vector3 nuevaPosicion = new Vector3(posicionActual.x + velocidadMovimiento * Time.deltaTime, posicionActual.y, posicionActual.z);
        transform.position = nuevaPosicion;
    }
}
