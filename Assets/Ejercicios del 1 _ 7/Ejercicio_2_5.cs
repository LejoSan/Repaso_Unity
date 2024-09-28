using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2_5 : MonoBehaviour
{
    int vidasPlayer1 = 10;
    int vidasPlayer2 = 20;
    int vidasPlayer3 = 30;
    int vidasPlayer4 = 40;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Valor inicial");
        Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
                  " VidasPlayer2 = " + vidasPlayer2 +
                  " VidasPlayer3 = " + vidasPlayer3 +
                  " VidasPlayer4 = " + vidasPlayer4);


        int temp = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("Valor VidasPlayer 2 => Valor VidasPlayer 3");
        Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
                  " VidasPlayer2 = " + vidasPlayer2 +
                  " VidasPlayer3 = " + vidasPlayer3 +
                  " VidasPlayer4 = " + vidasPlayer4);
        //Debug.Log("VidasPlayer2 toma valor VidaPlayer3 =" + vidasPlayer2);

        vidasPlayer3 = vidasPlayer1;
        Debug.Log("Valor VidasPlayer 3 => Valor VidasPlayer 1");
        Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
                  " VidasPlayer2 = " + vidasPlayer2 +
                  " VidasPlayer3 = " + vidasPlayer3 +
                  " VidasPlayer4 = " + vidasPlayer4);

        //Debug.Log("VidasPlayer3 toma valor VidaPlayer1 =" + vidasPlayer3);

        vidasPlayer1 = vidasPlayer4;
        Debug.Log("Valor VidasPlayer 1 => Valor VidasPlayer 4");
        Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
                  " VidasPlayer2 = " + vidasPlayer2 +
                  " VidasPlayer3 = " + vidasPlayer3 +
                  " VidasPlayer4 = " + vidasPlayer4);
        //Debug.Log("VidasPlayer2 toma valor VidaPlayer4 =" + vidasPlayer1);

        vidasPlayer4 = temp;
        Debug.Log("Valor VidasPlayer 4 => Valor VidasPlayer 2");
        Debug.Log(" VidasPlayer1 = " + vidasPlayer1 +
                  " VidasPlayer2 = " + vidasPlayer2 +
                  " VidasPlayer3 = " + vidasPlayer3 +
                  " VidasPlayer4 = " + vidasPlayer4);
        //Debug.Log("VidasPlayer2 toma valor VidaPlayer2 =" + vidasPlayer4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
