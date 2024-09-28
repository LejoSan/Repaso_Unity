using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_8 : MonoBehaviour
{
    double vida = 120;
    double incremneto = 3;
    int turno;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vida inicial " + vida);

        for (turno = 1; turno <= 5; turno++)
        {
            double reduccion = incremneto * turno;

            double cantidad = (reduccion / 100) * vida;

            vida = vida - cantidad;

            Debug.Log("En el turno: " + turno + " la vida se reduce a: " + vida);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
