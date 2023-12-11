using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    private Animator anim;
    public float velocidadMovimiento = 50f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Caminar", true);
            MoverIzquierda();
        }

        
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Caminar", true);
            MoverDerecha();
        }
        else 
        {
            anim.SetBool("Caminar", false);
           
        }
    }

   
    void MoverDerecha()
    {
        Vector3 posicionActual = transform.position;
        Vector3 nuevaPosicion = new Vector3(posicionActual.x + velocidadMovimiento * Time.deltaTime, posicionActual.y, posicionActual.z);
        transform.position = nuevaPosicion;
    }
    void MoverIzquierda()
    {
        Vector3 posicionActual = transform.position;
        Vector3 nuevaPosicion = new Vector3(posicionActual.x - velocidadMovimiento * Time.deltaTime, posicionActual.y, posicionActual.z);
        transform.position = nuevaPosicion;
    }
}