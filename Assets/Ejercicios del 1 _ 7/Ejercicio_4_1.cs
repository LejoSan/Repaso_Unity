using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_1 : MonoBehaviour
{
    [SerializeField] private float radio;
    [SerializeField] private float Base;
    [SerializeField] private float Altura;
    [SerializeField] private float lado_1;
    [SerializeField] private float lado_2;
    public float Pi = 3.1416f;

    // Start is called before the first frame update
    void Start()
    {
        float area_circulo = Calcular_Area_Circulo(radio, Pi);
        Debug.Log("El área del círculo es: " + area_circulo);

        float area_Triangulo = Calcular_Area_Triangulo(Base, Altura);
        Debug.Log("El área del Trinagulo es: " + area_Triangulo);

        float area_Cuadrado = Calcular_Area_Cuadrado(lado_1, lado_2);
        Debug.Log("El área del Cuadrado es: " + area_Triangulo);


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
}
