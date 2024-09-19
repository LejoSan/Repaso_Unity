using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_9 : MonoBehaviour
{
    [SerializeField] private int tipoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        int daño;
        int vida;

        if (tipoEnemigo == 1)
        {
            daño = 350;
            vida = 650;
        }
        else if (tipoEnemigo == 2)
        {
            daño = 300;
            vida = 550;
        }
        else if (tipoEnemigo == 3)
        {
            daño = 300;
            vida = 500;
        }
        else if (tipoEnemigo == 4)
        {
            daño = 310;
            vida = 460;
        }
        else if (tipoEnemigo == 5)
        {
            daño = 280;
            vida = 490;
        }
        else if (tipoEnemigo == 6)
        {
            daño = 360;
            vida = 520;
        }
        else
        {
            Debug.Log("Tipo de enemigo no válido. Introduce un número entre 1 y 6.");
            return;
        }

        Debug.Log("Enemigo tipo " + tipoEnemigo + " generado. Daño: " + daño + ", Vida: " + vida);
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
