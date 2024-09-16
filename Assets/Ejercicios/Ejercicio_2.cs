using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{
    //---------------------------------------------- 2.1

    //int edad = 25;
    //int codigoPostal = 54796;
    //double altura = 1.87;
    //char genero = 'H';
    //string nombre = "Alejandro Sandoval";
    //int numeroDeHijos = 0;
    //double iva = 0.16;
    //int tallaCamisa = 2;
    //float peso = 80;
    //float precio = 200000;
    //string alumnoRepetidor = "No";
    //string mensaje = "Ing. Multiemdia";
    //char letra = 'S';
    //bool mayorEdad = true;
    //int minutos = 30;
    //int dias = 2;
    //string matriculaCoche ="CUO 643";
    //int contador = 12;
    //char TallaCamisetas = 'L';

    //---------------------------------------------- 2.2 , 2.3 , 2.4

    //int vidas = 100;
    //float exp = 20;
    //char carac = 'A';

    //---------------------------------------------- 2.5

    //int vidasPlayer1 = 10;
    //int vidasPlayer2 = 20;
    //int vidasPlayer3 = 30;
    //int vidasPlayer4 = 40;

    //---------------------------------------------- 2.6

    //int puntuacion1 = 85;
    //int puntuacion2 = 90;
    //int puntuacion3 = 78;

    //---------------------------------------------- 2.7

    //int oro = 7;
    //int horas = 4;

    //---------------------------------------------- 2.8

    double vida = 120;
    double incremneto = 3;
    int turno;



    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("vidas =" + vidas + " exp = " + exp);

        //float resultadoSuma = vidas + exp;
        //Debug.Log("Suma:" + resultadoSuma);

        //float resultadoResta = exp - vidas;
        //Debug.Log("Resta:" + resultadoResta);

        //----------------------------------------------- 2.3

        //float producto = vidas * exp;
        //Debug.Log("Producto entre vidas y exp =" + producto);

        //float cociente = vidas / exp;
        //Debug.Log("Cociente entre vidas y exp =" + cociente);

        //float resto = vidas % exp;
        //Debug.Log("Resto entre vidas y exp =" + resto);

        //float doble = vidas * 2;
        //Debug.Log("Doble de vidas =" + doble);

        //float triple = exp * 3 ;
        //Debug.Log("Triple de exp =" + triple);

        //-----------------------------------------------  2.4

        //int incremento = vidas + 77;
        //Debug.Log("incremento de la vidas =" + incremento);

        //int decremento = incremento - 3;
        //Debug.Log("decremento de la vidas =" + decremento);

        //int Cuadruplico = decremento * 4;
        //Debug.Log("El cuadruple de la vidas =" + Cuadruplico);

        //-----------------------------------------------  2.5

        //Debug.Log("Valor inicial");
        //Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
        //          " VidasPlayer2 = " + vidasPlayer2 +
        //          " VidasPlayer3 = " + vidasPlayer3 +
        //          " VidasPlayer4 = " + vidasPlayer4 );


        //int temp = vidasPlayer2;
        //vidasPlayer2 = vidasPlayer3;
        //Debug.Log("Valor VidasPlayer 2 => Valor VidasPlayer 3");
        //Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
        //          " VidasPlayer2 = " + vidasPlayer2 +
        //          " VidasPlayer3 = " + vidasPlayer3 +
        //          " VidasPlayer4 = " + vidasPlayer4);
        ////Debug.Log("VidasPlayer2 toma valor VidaPlayer3 =" + vidasPlayer2);

        //vidasPlayer3 = vidasPlayer1;
        //Debug.Log("Valor VidasPlayer 3 => Valor VidasPlayer 1");
        //Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
        //          " VidasPlayer2 = " + vidasPlayer2 +
        //          " VidasPlayer3 = " + vidasPlayer3 +
        //          " VidasPlayer4 = " + vidasPlayer4);

        ////Debug.Log("VidasPlayer3 toma valor VidaPlayer1 =" + vidasPlayer3);

        //vidasPlayer1 = vidasPlayer4;
        //Debug.Log("Valor VidasPlayer 1 => Valor VidasPlayer 4");
        //Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
        //          " VidasPlayer2 = " + vidasPlayer2 +
        //          " VidasPlayer3 = " + vidasPlayer3 +
        //          " VidasPlayer4 = " + vidasPlayer4);
        ////Debug.Log("VidasPlayer2 toma valor VidaPlayer4 =" + vidasPlayer1);

        //vidasPlayer4 = temp;
        //Debug.Log("Valor VidasPlayer 4 => Valor VidasPlayer 2");
        //Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
        //          " VidasPlayer2 = " + vidasPlayer2 +
        //          " VidasPlayer3 = " + vidasPlayer3 +
        //          " VidasPlayer4 = " + vidasPlayer4);
        ////Debug.Log("VidasPlayer2 toma valor VidaPlayer2 =" + vidasPlayer4);
        ///

        //-----------------------------------------------  2.6

        //Debug.Log(" puntuacion 1  = " + puntuacion1 +
        //          " puntuacion 2  = " + puntuacion2 +
        //          " puntuacion 3  = " + puntuacion3);

        //double media = (puntuacion1 + puntuacion2 + puntuacion3) / 3.0;
        //Debug.Log(media);

        //-----------------------------------------------  2.7

        //int segundosxhora = 3600; //60 sg * 60 min

        //int totalSegundos = horas * segundosxhora;

        //int OroRecogido = oro * totalSegundos;

        //Debug.Log("el personaje farmea en total " + OroRecogido + " En oro ");

        //----------------------------------------------- 2.8
        

        Debug.Log("Vida inicial " + vida);

        for(turno = 1; turno<=5; turno++)
        {
            double reduccion = incremneto * turno;

            double cantidad = (reduccion / 100) * vida;

            vida = vida - cantidad;

            Debug.Log("En el turno: " + turno + " la vida se reduce a: " + vida);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
