using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaganner : MonoBehaviour
{
    void Start()
    {
        EnemigoGoblin goblin = new EnemigoGoblin("Goblin Verde");
        EnemigoGoblin goblin2 = new EnemigoGoblin("Goblin Azul");
        Enemigo orco = new Enemigo("Orco", 150, 2);

        
        goblin2.SetItemADropear(new Consumible("Poci�n grande", 50));

       
        goblin.Atacar(orco);


        Buff a = new Buff("furia","Aumenta el da�o en 20" );
        a.Aplicar();
        Consumible pocion = new Consumible("Poci�n fuerte", 500);
        pocion.Consumir();

        
        Item drop = goblin.DropearItem();
        Item drop2 = goblin2.DropearItem();

        Debug.Log("El goblin dej�: " + drop.Nombre);
        Debug.Log("El goblin azul dej�: " + drop2.Nombre);


        ItemUsar.ConsumirItemSiEsPosible(drop);
        ItemUsar.ConsumirItemSiEsPosible(drop2);

    }

   
}
