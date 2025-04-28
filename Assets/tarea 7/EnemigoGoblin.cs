using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGoblin : Enemigo, IAtacable
{
    private int da�oBase;

    public EnemigoGoblin(string nombre) : base(nombre)
    {
        this.da�oBase = 10;
    }

    public void Atacar(Enemigo objetivo)
    {
        Debug.Log($"{Nombre} ataca con su daga.");
        objetivo.RecibirDanio(da�oBase);
    }
}
