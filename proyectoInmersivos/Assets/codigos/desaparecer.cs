using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    
    void Start()
    {

    }

    
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            gameObject.SetActive(false);
        }   
        if (collision.gameObject.CompareTag("Obstaculo1"))
        {
         gameObject.SetActive(false);
        }

            }
            
        }s
    
