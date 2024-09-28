using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_3 : MonoBehaviour
{
    int vidas = 100;
    float exp = 20;


    // Start is called before the first frame update
    void Start()
    {
        float producto = vidas * exp;
        Debug.Log("Producto entre vidas y exp =" + producto);

        float cociente = vidas / exp;
        Debug.Log("Cociente entre vidas y exp =" + cociente);

        float resto = vidas % exp;
        Debug.Log("Resto entre vidas y exp =" + resto);

        float doble = vidas * 2;
        Debug.Log("Doble de vidas =" + doble);

        float triple = exp * 3;
        Debug.Log("Triple de exp =" + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
