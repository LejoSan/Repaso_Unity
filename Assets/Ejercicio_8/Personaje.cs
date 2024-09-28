using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private float experiencia;
    [SerializeField] private SistemaDeVida sistemaDeVida;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public SistemaDeVida SistemaDeVida { get => sistemaDeVida; set => sistemaDeVida = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public float CalcularNivel()
    {
        return experiencia / 1000f;
    }


}
