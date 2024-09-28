using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] private float vidaInicial;
                     private float vidaActual;

    [SerializeField] private float cantidadCura;
    [SerializeField] private float cantidadDanho;

    public float VidaActual { get => vidaActual; set => vidaActual = value; }
    public float VidaInicial { get => vidaInicial; set => vidaInicial = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float RecibirCura()
    {
        if (cantidadCura < 0)
        {
            return -1f;
        }
        VidaActual += cantidadCura;
        return VidaActual;
    }

    public float RecibirDanho()
    {
        if (cantidadDanho < 0)
        {
            return -1f;  
        }

        VidaActual -= cantidadDanho; 

        if (VidaActual <= 0)
        {
            VidaActual = 0;  
            return 0f;       
        }
        return VidaActual;   
    }
}
    
