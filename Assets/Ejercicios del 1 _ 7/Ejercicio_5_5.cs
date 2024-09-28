using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_5 : MonoBehaviour
{
    [SerializeField] private float level;
    // Start is called before the first frame update
    void Start()
    {
        if (level % 2 == 0)
        {
            Debug.Log("El nivel " + level + " es par.");
        }
        else
        {
            Debug.Log("El nivel " + level + " es impar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
