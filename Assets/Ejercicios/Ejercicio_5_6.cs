using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_6 : MonoBehaviour
{
    [SerializeField] private int nivelPokemon;
    // Start is called before the first frame update
    void Start()
    {
        if (nivelPokemon % 10 == 0)
        {
            Debug.Log("El nivel " + nivelPokemon + " es múltiplo de 10. ¡El Pokémon puede aprender un nuevo ataque!");
        }
        else
        {
            Debug.Log("El nivel " + nivelPokemon + " NO es múltiplo de 10.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
