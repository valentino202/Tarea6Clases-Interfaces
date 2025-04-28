using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
public interface IAtacable
{
    void Atacar(Enemigo objetivo);
}

public interface IRecibirDanio
{
    void RecibirDanio(int cantidad);
}

public interface IDropearItems
{
    Item DropearItem();
}


public class Enemigo : IRecibirDanio, IDropearItems
{
    string nombre;
    int salud;
    int nivel;

    public string Nombre => nombre;
    public int Salud => salud;
    public int Nivel => nivel;

    public Enemigo(string nombre)
    {
        this.nombre = nombre;
        this.salud = 100;
        this.nivel = 1;
    }

    public Enemigo(string nombre, int salud, int nivel)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.nivel = nivel;
    }

    public virtual void RecibirDanio(int cantidad)
    {
        salud -= cantidad;
        if (salud <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log($"{nombre} ha muerto.");
    }



    protected Item itemADropear;
    public  Item DropearItem()
    {
        if (itemADropear != null)
            return itemADropear;

        return new Consumible("Poci�n com�n", 10);
    }
    public void SetItemADropear(Item item)
    {
        itemADropear = item;
    }

    
}

