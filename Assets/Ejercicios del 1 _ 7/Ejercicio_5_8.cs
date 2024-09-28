using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_8 : MonoBehaviour
{

    [SerializeField] private int H;   
    [SerializeField] private int M; 
    [SerializeField] private int S;

    // Start is called before the first frame update
    void Start()
    {
        if (H >= 0 && H < 24 && M >= 0 && M < 60 && S >= 0 && S < 60)
        {
            Debug.Log("La hora es válida: " + H +":"+ M +":"+ S);
        }
        else
        {
            Debug.Log("La hora ingresada no es válida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
