using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_4_2 : MonoBehaviour
{
    [SerializeField] private string Nombre;
    [SerializeField] private string apellido1;
    [SerializeField] private string apellido2;
    [SerializeField] private int Edad;

    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre(Nombre,apellido1,apellido2,Edad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ConstruirNombre(string Nombre, string apellido1, string apellido2,int Edad)
    {
        Debug.Log("La persona se llama " + Nombre +" "+ apellido1 +" "+ apellido2 + " Y tiene " + Edad + " años");
    }
}
