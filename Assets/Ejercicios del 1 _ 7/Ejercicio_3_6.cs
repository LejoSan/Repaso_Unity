using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_6 : MonoBehaviour
{
    [SerializeField] private float velocidad_Km_H;
    // Start is called before the first frame update
    void Start()
    {
        float velocidad_M_S;

        float conversion = 1000f / 3600f;  //1 km/hr = 1000 m/3600 seg = 1 / 3,6 m / seg

        velocidad_M_S = velocidad_Km_H * conversion;

        Debug.Log("Velocidad en Km/h: " + velocidad_Km_H);
        Debug.Log("Velocidad en m/s: " + velocidad_M_S);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
