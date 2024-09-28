using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_13 : MonoBehaviour
{
    [SerializeField] private int numero;
    // Start is called before the first frame update
    void Start()
    {
        bool esPrimo = EsNumeroPrimo(numero);
        if (esPrimo)
        {
            Debug.Log(numero + "  es un número primo.");
        }
        else
        {
            Debug.Log(numero + "  no es un número primo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private bool EsNumeroPrimo(int num)
    {
        // Un número menor o igual a 1 no es primo
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

}
