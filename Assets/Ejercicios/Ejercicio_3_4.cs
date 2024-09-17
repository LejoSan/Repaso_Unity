using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3_4 : MonoBehaviour
{
    [SerializeField] private int Exp;
    // Start is called before the first frame update
    void Start()
    {
        int Lvl;
        Lvl = 32 + (9 * Exp / 5);
        Debug.Log("El nivel del personaje es =" + Lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
