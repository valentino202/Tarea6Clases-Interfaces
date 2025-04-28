using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearSlime : MonoBehaviour
{

    void Start()
    {

        Slime N1 = new Slime(20);
        Slime N2 = new Slime(10);
        Slime N3Fucionado = (N1 + N2);

        N1.VidaSlime();
        N2.VidaSlime();
        N3Fucionado.VidaFuncion();

    }

}
    

    
