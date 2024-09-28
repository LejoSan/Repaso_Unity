using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_5 : MonoBehaviour
{
    [SerializeField] private float Radio;
    // Start is called before the first frame update
    void Start()
    {
        float pi = 3.1415f;

        float Formula_Longitud_Circuferencia = 2 * pi * Radio;

        float Area_Circunferencia = pi * Radio * Radio;

        Debug.Log("La longitud de la circuferencia es = " + Formula_Longitud_Circuferencia);

        Debug.Log("Área de la circunferencia: " + Area_Circunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
