using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_5 : MonoBehaviour
{
    [SerializeField] private int numero;
    // Start is called before the first frame update
    void Start()
    {
        bloqueWHILE();

        bloqueFOR();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void bloqueFOR()
    {
        for (int i = 1; i <= numero; i++)
        {
            Debug.Log("Conte desde el modulo FOR  " + i);
        }
    }

    void bloqueWHILE()
    {
        int i = 1;

        while (i <= numero)
        {
            Debug.Log("Conte desde el modulo WHILE  " + i);
            i++;
        }
    }


}
