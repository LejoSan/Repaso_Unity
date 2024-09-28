using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_2 : MonoBehaviour
{
    [SerializeField] private int Numero_1;
    [SerializeField] private int Numero_2;
    // Start is called before the first frame update
    void Start()
    {
        if (Numero_1 > 3 && Numero_2 > 3)
        {
            Debug.Log("El numero   " + Numero_1 + " > " + 3 + "  y numero es  " + Numero_2 + " > " + 3);
        }
        if (Numero_1 < 3 && Numero_2 < 3)
        {
            Debug.Log("El numero   " + Numero_1 + " < " + 3 + "  y numero es  " + Numero_2 + " < " + 3);

        }
        if (Numero_1 < 3 && Numero_2 > 3)
        {
            Debug.Log("El numero   " + Numero_1 + " < " + 3 + "  y numero es  " + Numero_2 + " > " + 3);

        }
        if (Numero_1 > 3 && Numero_2 < 3)
        {
            Debug.Log("El numero   " + Numero_1 + " > " + 3 + "  y numero es  " + Numero_2 + " < " + 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
