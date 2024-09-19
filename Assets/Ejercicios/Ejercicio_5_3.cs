using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_3 : MonoBehaviour
{
    [SerializeField] private int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >= 0 && numero <= 9)
        {
            Debug.Log("El número " + numero + " está comprendido entre 0 y 9.");
        }
        else
        {
            Debug.Log("El número " + numero + " NO está comprendido entre 0 y 9.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
