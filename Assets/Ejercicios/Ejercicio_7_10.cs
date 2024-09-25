using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_10 : MonoBehaviour
{
    [SerializeField] private int numero_1;
    [SerializeField] private int numero_2;

    // Start is called before the first frame update
    void Start()
    {
        if (numero_1 <= numero_2)
        {
            for (int i = numero_1; i <= numero_2; i++) 
            {
                string signo;
                if (i >= 0)
                {
                    signo = "positivo";  
                }
                else
                {
                    signo = "negativo";  
                }


                string paridad;
                if (i % 2 == 0)
                {
                    paridad = "par";  
                }
                else
                {
                    paridad = "impar";  
                }

                Debug.Log("El número " + i + "es" + signo + " " + paridad);
            }
        }
        else
        {
            for (int i = numero_2; i <= numero_1; i++) 
            {
                string signo;
                if (i >= 0)
                {
                    signo = "positivo";  
                }
                else
                {
                    signo = "negativo"; 
                }
                string paridad;
                if (i % 2 == 0)
                {
                    paridad = "par"; 
                }
                else
                {
                    paridad = "impar";  
                }

                Debug.Log("El número " + i + "es" + signo + " " + paridad);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
