using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5_1 : MonoBehaviour
{
    //bool X = true;
    //bool Y = false;
    //bool Z = true;

    // Start is called before the first frame update
    void Start()
    {
        //A.  ((X && Y) || (X && Z))

        //    (False) || (True)

        //    R/. True

        //-----------------------------------------------


        //B.  (X || !Y) && (!X || Z)

        //    (True) && (True)

        //    R/. True

        //-----------------------------------------------


        //C.  (X) || Y && Z

        //    (True) || (False)

        //    R/. True

        //-----------------------------------------------

        //D.  !(X || Y) && Z

        //    (False) && (True)

        //    R/. False

        //-----------------------------------------------

        //E.  X || Y || X  && !Z && !Y 

        //    (True) || (False)

        //    R/. True

        //-----------------------------------------------

        //F.  !X || !Y || Z && X && !Y 

        //    (True) || (True)

        //    R/. True


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
