using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_6 : MonoBehaviour
{

    int puntuacion1 = 85;
    int puntuacion2 = 90;
    int puntuacion3 = 78;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(" puntuacion 1  = " + puntuacion1 +
                  " puntuacion 2  = " + puntuacion2 +
                  " puntuacion 3  = " + puntuacion3);

        double media = (puntuacion1 + puntuacion2 + puntuacion3) / 3.0;
        Debug.Log(media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
