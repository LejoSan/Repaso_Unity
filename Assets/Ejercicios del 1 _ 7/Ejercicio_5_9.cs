using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_9 : MonoBehaviour
{
    [SerializeField] private int tipoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        int da�o;
        int vida;

        if (tipoEnemigo == 1)
        {
            da�o = 350;
            vida = 650;
        }
        else if (tipoEnemigo == 2)
        {
            da�o = 300;
            vida = 550;
        }
        else if (tipoEnemigo == 3)
        {
            da�o = 300;
            vida = 500;
        }
        else if (tipoEnemigo == 4)
        {
            da�o = 310;
            vida = 460;
        }
        else if (tipoEnemigo == 5)
        {
            da�o = 280;
            vida = 490;
        }
        else if (tipoEnemigo == 6)
        {
            da�o = 360;
            vida = 520;
        }
        else
        {
            Debug.Log("Tipo de enemigo no v�lido. Introduce un n�mero entre 1 y 6.");
            return;
        }

        Debug.Log("Enemigo tipo " + tipoEnemigo + " generado. Da�o: " + da�o + ", Vida: " + vida);
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
