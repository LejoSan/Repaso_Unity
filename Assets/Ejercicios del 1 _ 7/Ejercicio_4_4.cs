using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_4 : MonoBehaviour
{
    [SerializeField] private float velocidad_Km_H;
    // Start is called before the first frame update
    void Start()
    {
        float velocidad_M_S  = conversor(velocidad_Km_H);
        Debug.Log("Velocidad en Km/h: " + velocidad_Km_H);
        Debug.Log("Velocidad en m/s: " + velocidad_M_S);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float conversor(float velocidad_Km_H)
    {
        float conversion = 1000f / 3600f;  //1 km/hr = 1000 m/3600 seg = 1 / 3,6 m / seg

         return  velocidad_Km_H * conversion;


    }
}
