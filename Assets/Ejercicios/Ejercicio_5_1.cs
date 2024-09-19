using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_1 : MonoBehaviour
{

    [SerializeField] private int personaje_1;
    [SerializeField] private int personaje_2;
    // Start is called before the first frame update
    void Start()
    {
        if (personaje_1 > personaje_2)
        {
            Debug.Log("las vidas de los personajes no son iguales  " + personaje_1 +" > "+ personaje_2);
        }
        if(personaje_1 < personaje_2)
        {
            Debug.Log("las vidas de los personajes no son iguales  " + personaje_1 + " < " + personaje_2);

        }
        else
        {
            Debug.Log("Las vidas de los personajas son iguales  " + personaje_1 + " = " + personaje_2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
