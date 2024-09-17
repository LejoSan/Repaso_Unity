using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_3 : MonoBehaviour
{
    [SerializeField] private int numero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numero entero inicial = " + numero);

        float doble = numero * numero;
        Debug.Log("Doble de numero entero =" + doble);

        float triple = numero * numero * numero;
        Debug.Log("Triple de numero entero =" + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
