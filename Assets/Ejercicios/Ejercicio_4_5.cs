using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_5 : MonoBehaviour
{
    [SerializeField] private float radio;
    [SerializeField] private float Base;
    [SerializeField] private float Altura;
    [SerializeField] private float lado_1;
    [SerializeField] private float lado_2;
    public float Pi = 3.1416f;

    [SerializeField] private string moneda;
    // Start is called before the first frame update
    void Start()
    {
        float area_circulo = Calcular_Area_Circulo(radio, Pi);
        Debug.Log("El área del círculo es: " + area_circulo);

        float area_Triangulo = Calcular_Area_Triangulo(Base, Altura);
        Debug.Log("El área del Trinagulo es: " + area_Triangulo);

        float area_Cuadrado = Calcular_Area_Cuadrado(lado_1, lado_2);
        Debug.Log("El área del Cuadrado es: " + area_Triangulo);


        float monedas_circulo = Convertir(area_circulo, moneda);
        Debug.Log("La cantidad expresada en la moneda escogida para el área del círculo es: " + monedas_circulo);

        float monedas_triangulo = Convertir(area_Triangulo, moneda);
        Debug.Log("La cantidad expresada en la moneda escogida para el área del triángulo es: " + monedas_triangulo);

        float monedas_cuadrado = Convertir(area_Cuadrado, moneda);
        Debug.Log("La cantidad expresada en la moneda escogida para el área del cuadrado es: " + monedas_cuadrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Calcular_Area_Circulo(float radio, float pi)
    {
        return (radio * radio) * pi;
    }

    float Calcular_Area_Triangulo(float Base, float Altura)
    {
        return ((Base * Altura) / 2);
    }

    float Calcular_Area_Cuadrado(float lado_1, float lado_2)
    {
        return lado_1 * lado_2;
    }

    float Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            // Conversión de euros ==> dólares
            return cantidad * 1.11f;
        }
        else if (moneda == "dolar")
        {
            // Conversión de dólares ==> euros
            return cantidad / 1.11f;
        }
        else
        {
            Debug.LogError("Moneda no reconocida. Escribe 'euro' o 'dolar'");
            return 0;
        }
    }
}
