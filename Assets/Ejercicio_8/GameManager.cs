using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Personaje personaje1;
    [SerializeField] private Personaje personaje2;
    private bool yaEjecutado = false;


    // Start is called before the first frame update
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            prepararPersonjaes();
            yaEjecutado = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float vidaActual = personaje1.SistemaDeVida.RecibirCura();
            Debug.Log("Vida de " + personaje1.Nombre + " despues de curar: " + vidaActual);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float vidaActual = personaje2.SistemaDeVida.RecibirCura();
            Debug.Log("Vida de " + personaje2.Nombre + " despues de curar: " + vidaActual);
        }
    }

    void prepararPersonjaes()
    {

        personaje1.Enemigo = personaje2;
        personaje2.Enemigo = personaje1;

        Debug.Log(personaje1.Nombre + " tiene nivel: " + personaje1.CalcularNivel());
        Debug.Log(personaje2.Nombre + " tiene nivel: " + personaje2.CalcularNivel());
    }

}
