using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_11 : MonoBehaviour
{
    [SerializeField] private int numero;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)  
        {
            int resultado = numero * i;  

            Debug.Log(numero + "  x  " + i + "  =  " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
