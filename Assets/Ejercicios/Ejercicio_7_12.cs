using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_12 : MonoBehaviour
{
    [SerializeField] private int numero_1;
    [SerializeField] private int numero_2;

    // Start is called before the first frame update
    void Start()
    {
        int suma_Total = SumarTodosLosNumeros(numero_1, numero_2);
        Debug.Log("La suma de todos los números entre " + numero_1 + "   y  " + numero_2 + "  es  " + suma_Total);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private int SumarTodosLosNumeros(int numero_1, int numero_2) {

        int suma = 0;
        int menor = numero_1;
        int mayor = numero_2;

        if (numero_1 > numero_2)
        {
            menor = numero_2;
            mayor = numero_1;
        }

        int i = menor;
        while (i <= mayor)
        {
            suma += i;
            i++;
        }

        return suma;  // Devolver la suma total
    }
}

