using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private float experiencia;
    [SerializeField] private SistemaDeVida sistemaDeVida;
    [SerializeField] private Arma arma;
    [SerializeField] private KeyCode teclaCura;
    [SerializeField] private KeyCode teclaDanho;
    [SerializeField] private KeyCode teclaRecarga;
    [SerializeField] private Personaje enemigo;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public SistemaDeVida SistemaDeVida { get => sistemaDeVida; set => sistemaDeVida = value; }
    public Arma Arma { get => arma; set => arma = value; }
    public KeyCode TeclaCura { get => teclaCura; set => teclaCura = value; }
    public KeyCode TeclaDanho { get => teclaDanho; set => teclaDanho = value; }
    public KeyCode TeclaRecarga { get => teclaRecarga; set => teclaRecarga = value; }
    public Personaje Enemigo { get => enemigo; set => enemigo = value; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(TeclaCura))
        {
            float vidaActual = sistemaDeVida.RecibirCura();
            Debug.Log(nombre + " ha recibido cura. Vida actual: " + vidaActual);
        }

        if (Input.GetKeyDown(TeclaDanho))
        {
            int resultadoUso = arma.UtilizarArma();

            if (resultadoUso == 0)
            {

                float danho = Random.Range(arma.DanhoMinimo, arma.DanhoMaximo);
                float vidaActual = Enemigo.SistemaDeVida.RecibirDanho();
                Debug.Log(Enemigo.Nombre + " ha recibido " + danho + " de daño. Vida actual: " + vidaActual);
            }
            else
            {
                Debug.Log("Necesitas Recargar");
            }

            if (Input.GetKeyDown(TeclaRecarga))
            {
                int resultadoRecarga = arma.RecargarArma();

                if (resultadoRecarga == 0)
                {
                    Debug.Log(arma.MunicionActual + " municiones disponibles después de recargar.");
                }
                else
                {
                    Debug.Log("Tu Arma esta cargada");
                }
            }
        }
    }


    public float CalcularNivel()
    {
        return experiencia / 1000f;
    }



}









