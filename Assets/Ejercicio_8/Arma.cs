using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] private float danhoMinimo;
    [SerializeField] private float danhoMaximo;
    [SerializeField] private float capacidadTotal;
    [SerializeField] private bool esAutomatica;
    [SerializeField] private float municionActual;

    public float DanhoMinimo { get => danhoMinimo; set => danhoMinimo = value; }
    public float DanhoMaximo { get => danhoMaximo; set => danhoMaximo = value; }
    public float CapacidadTotal { get => capacidadTotal; set => capacidadTotal = value; }
    public bool EsAutomatica { get => esAutomatica; set => esAutomatica = value; }
    public float MunicionActual { get => municionActual; set => municionActual = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int UtilizarArma()
    {
        if (MunicionActual > 0)
        {
            MunicionActual--; 
            return 0; 
        }
        return -1; 
    }

    public int RecargarArma()
    {
        if (MunicionActual < CapacidadTotal)
        {
            MunicionActual = CapacidadTotal; 
            return 0; 
        }
        return -1; 
    }
}
