using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    private string Name;
    protected int Life;
    protected int Attack;
    protected int Defense;

    public string Name_
    {
        get { return Name; }
        private set { Name = value; }
    }


    public BaseEntity(string name, int life, int attack, int defense)
    {
        Name_ = name;
        Life = life;
        Attack = attack;
        Defense = defense;
    }

    public void MostrarStats()
    {
        Debug.Log($"Nombre: {Name_} | Vida: {Life} | Ataque: {Attack} | Defensa: {Defense}");
    }

}

