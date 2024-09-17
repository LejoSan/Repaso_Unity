using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_7 : MonoBehaviour
{
    int oro = 7;
    int horas = 4;
    // Start is called before the first frame update
    void Start()
    {
        int segundosxhora = 3600; //60 sg * 60 min

        int totalSegundos = horas * segundosxhora;

        int OroRecogido = oro * totalSegundos;

        Debug.Log("el personaje farmea en total " + OroRecogido + " En oro ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
