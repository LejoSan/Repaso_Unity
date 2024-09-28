using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_6_2 : MonoBehaviour
{

    //bool W = false;
    //bool X = true;
    //bool Y = true;
    //bool Z = false;

    // Start is called before the first frame update
    void Start()
    {
        //A.  W || Y && X && W || Z 

        //    (True) && (True) && (False)

        //    R/. False

        //-----------------------------------------------

        //B.  X && !Y && !X || !W && Y 

        //    (False) || (True)

        //    R/. True

        //-----------------------------------------------

        //C.  !(W || !Y) && X || Z 

        //    (True) || (False)

        //    R/. True

        //-----------------------------------------------

        //D.   X && Y && W || Z || X 

        //    (False) || (True)

        //    R/. True

        //-----------------------------------------------

        //E.   Y || !(Y || Z && W )

        //    (True) || (False)

        //    R/. True

        //-----------------------------------------------

        //F.   !X && Y && (!Z || !X )

        //    (False) && (True) && (True)

        //    R/. False
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
