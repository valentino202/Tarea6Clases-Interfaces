using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
 
    void Start()
    {
        FinalBoss  boss = new FinalBoss(" EL rey demonio",100, 20, 15);
        boss.ApplyBuff("ataque", 10);
        boss.ApplyBuff("defensa", 5);
        boss.ApplyBuff("salud", 20);
        boss.ApplyBuff("ataque", 15);
    }
    

     
}  





    

    
