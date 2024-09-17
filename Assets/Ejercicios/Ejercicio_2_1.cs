using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_1 : MonoBehaviour
{
    int edad = 25;
    int codigoPostal = 54796;
    double altura = 1.87;
    char genero = 'H';
    string nombre = "Alejandro Sandoval";
    int numeroDeHijos = 0;
    double iva = 0.16;
    int tallaCamisa = 2;
    float peso = 80;
    float precio = 200000;
    string alumnoRepetidor = "No";
    string mensaje = "Ing. Multiemdia";
    char letra = 'S';
    bool mayorEdad = true;
    int minutos = 30;
    int dias = 2;
    string matriculaCoche = "CUO 643";
    int contador = 12;
    char TallaCamisetas = 'L';

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(edad + codigoPostal + altura + genero + nombre + numeroDeHijos + iva + tallaCamisa + peso
            + precio + alumnoRepetidor + mensaje + letra + mayorEdad + minutos + dias + matriculaCoche +
            contador + TallaCamisetas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
