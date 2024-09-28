using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_7 : MonoBehaviour
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
                Debug.Log(i); 
            }
        }
        else
        {
            for (int i = numero_2; i <= numero_1; i++)
            {
                Debug.Log(i);  
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
