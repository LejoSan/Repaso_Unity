using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_7 : MonoBehaviour
{
    [SerializeField] private float Base;
    [SerializeField] private float Altura;
    // Start is called before the first frame update
    void Start()
    {
        float Area_Triangulo = ((Base * Altura) / 2);
        Debug.Log("El area de vision (Triangulo) es =" + Area_Triangulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
