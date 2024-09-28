using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_4 : MonoBehaviour
{
    int vidas = 100;


    // Start is called before the first frame update

    void Start()
    {
        int incremento = vidas + 77;
        Debug.Log("incremento de la vidas =" + incremento);

        int decremento = incremento - 3;
        Debug.Log("decremento de la vidas =" + decremento);

        int Cuadruplico = decremento * 4;
        Debug.Log("El cuadruple de la vidas =" + Cuadruplico);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
