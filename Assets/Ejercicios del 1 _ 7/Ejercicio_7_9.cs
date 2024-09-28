using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_9 : MonoBehaviour
{
    [SerializeField] private int numero_1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= numero_1; i++)
        {

            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
