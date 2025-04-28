using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGoblin : Enemigo, IAtacable
{
    private int dañoBase;

    public EnemigoGoblin(string nombre) : base(nombre)
    {
        this.dañoBase = 10;
    }

    public void Atacar(Enemigo objetivo)
    {
        Debug.Log($"{Nombre} ataca con su daga.");
        objetivo.RecibirDanio(dañoBase);
    }
}
