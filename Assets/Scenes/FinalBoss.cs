using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class FinalBoss : BaseEntity
{
    private int buffsAplicados = 0;
    public FinalBoss(string name, int life, int attack, int defense) : base(name, life, attack, defense)
    {
        Debug.Log("Final Boss creado.");
        MostrarStats();
    }
    public void ApplyBuff(string tipo, int cantidad)
    {

       switch(tipo)
        {
            case "ataque":
                Attack += cantidad;
                Debug.Log($"Se ha aumentado el ataque en {cantidad} puntos.");
            break;

            case "defensa":
                Defense += cantidad;
                Debug.Log($"Se ha aumentado la defensa en {cantidad} puntos.");
            break;

            case "salud":
                 Life += cantidad;
                Debug.Log($"Se ha aumentado la vida en {cantidad} puntos.");
            break;

            default:
                Debug.Log("Tipo de buff no reconocido.");  
            return;
        }
           buffsAplicados++;
           MostrarStats();
        
        if (buffsAplicados >= 4)
        {
            DestruirBoss();
        }
    }

    private void DestruirBoss()
    {
        Debug.Log("Buffs máximos alcanzados, destruyendo al jefe...");
        Debug.Log($"¡{Name_} ha sido destruido tras aplicar {buffsAplicados} buffs!");
    }
    
}