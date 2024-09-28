using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_3 : MonoBehaviour
{
    [SerializeField] private float cantidad;
    [SerializeField] private string moneda; 

    // Start is called before the first frame update
    void Start()
    {
        float conversion = Convertir(cantidad, moneda);

        Debug.Log("Estas convirtiendo una cantidad = " + cantidad + " a moneda " + moneda +" y tu resultado es = " + conversion); 
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Método que realiza la conversión
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
