using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_2 : MonoBehaviour
{
    int vidas = 100;
    float exp = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vidas =" + vidas + " exp = " + exp);

        float resultadoSuma = vidas + exp;
        Debug.Log("Suma:" + resultadoSuma);

        float resultadoResta = exp - vidas;
        Debug.Log("Resta:" + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
