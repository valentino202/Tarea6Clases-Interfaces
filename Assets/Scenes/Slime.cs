using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour
{
    int vida;

    public int Vida => vida;

    public int GetLife()
    {
        return vida;
    }

    public Slime(int vida)
    {
        this.vida = vida;
    }

    public static Slime operator +(Slime a, Slime b)
    {
        return new Slime(a.vida + b.vida);
    }
    public void VidaSlime()
    {
        Debug.Log($" Slime con {Vida} de vida");
    }
    public void VidaFuncion()
    {
        Debug.Log($"Nuevo Slime  con {GetLife()} de vida");
    }

}
