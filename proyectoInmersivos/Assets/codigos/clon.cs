using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clon : MonoBehaviour
{
    public GameObject playerPrefab; // Asigna el prefab del personaje en el Inspector
    private bool yaClonado = false;  // Variable para rastrear si ya se ha realizado el clon

    void Start()
    {
        // Llama a la función para clonar el personaje solo si aún no se ha clonado
        if (!yaClonado)
        {
            Clonar();
            yaClonado = true;  // Marca que ya se ha realizado el clon
        }
    }

    void Clonar()
    {
        // Utiliza Instantiate para crear una copia del personaje en la posición actual
        GameObject clon = Instantiate(playerPrefab, transform.position, Quaternion.identity);

        // Ajusta cualquier otra configuración que puedas necesitar para el clon, por ejemplo, nombre, escala, etc.
        clon.name = "Clon";
        clon.transform.localScale = transform.localScale;

        // Agrega cualquier otro comportamiento o componente necesario para el clon
        // clon.AddComponent<YourComponent>();
    }
}