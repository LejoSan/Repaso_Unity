using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_7 : MonoBehaviour
{
    [SerializeField] private int velocidadJugador1;
    [SerializeField] private int velocidadJugador2;
    [SerializeField] private int velocidadJugador3;

    // Start is called before the first frame update
    void Start()
    {
        if (velocidadJugador1 >= velocidadJugador2 && velocidadJugador1 >= velocidadJugador3)
        {
            Debug.Log("Jugador 1 atacará primero con velocidad: " + velocidadJugador1);
        
        }else if (velocidadJugador2 >= velocidadJugador1 && velocidadJugador2 >= velocidadJugador3)
        {
            Debug.Log("Jugador 2 atacará primero con velocidad: " + velocidadJugador2);
        }
        else
        {
            Debug.Log("Jugador 3 atacará primero con velocidad: " + velocidadJugador3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
