using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_1 : MonoBehaviour
{
    [SerializeField] private int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (i <= 100)
        {
            Debug.Log("Conte  " + i);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
