//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Ejercicio_7_13 : MonoBehaviour
//{
//    [SerializeField] private int numero;

//    // Start is called before the first frame update
//    void Start()
//    {
//        bool esPrimo = EsNumeroPrimo(numero);
//        if (esPrimo)
//        {
//            Debug.Log($"{numero} es un n�mero primo.");
//        }
//        else
//        {
//            Debug.Log($"{numero} no es un n�mero primo.");
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    private bool EsNumeroPrimo(int num)
//    {
//        // Un n�mero menor o igual a 1 no es primo
//        if (num <= 1)
//        {
//            return false;
//        }

//        // Verificar si num es divisible entre cualquier n�mero desde 2 hasta la ra�z cuadrada de num
//        for (int i = 2; i <= Mathf.Sqrt(num); i++)
//        {
//            if (num % i == 0)
//            {
//                return false;  // Si es divisible, no es primo
//            }
//        }

//        return true;  // Si no es divisible por ning�n n�mero, es primo
//    }
//}
