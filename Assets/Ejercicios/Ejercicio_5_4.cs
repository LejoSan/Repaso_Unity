using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_4 : MonoBehaviour
{

    [SerializeField] private float dividendo; 
    [SerializeField] private float divisor; 
    // Start is called before the first frame update
    void Start()
    {
        if (divisor != 0)
        {
            float resultado = dividendo / divisor;
            Debug.Log("El resultado de dividir " + dividendo + " entre " + divisor + " es: " + resultado);
        }
        else
        {
            Debug.Log("Error: El divisor no puede ser cero.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
