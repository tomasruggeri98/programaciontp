using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        // crear GameObjects para cada producto, en caso de querer usar los objetos en un juego realmente deberiamos
        //crear un object con un sprite, metodos, funciones, etc y asignarlos de forma publica
        GameObject espadaObject = new GameObject("Espada");
        GameObject escudoObject = new GameObject("Escudo");
        GameObject pistolaObject = new GameObject("Pistola");

        //agregar a la tienda
        Tienda espada = espadaObject.AddComponent<Tienda>();
        espada.Nombre = "Espada de Hierro";
        espada.Precio = 1.5f;

        Tienda escudo = escudoObject.AddComponent<Tienda>();
        escudo.Nombre = "Escudo de Madera";
        escudo.Precio = 0.5f;

        Tienda pistola = pistolaObject.AddComponent<Tienda>();
        pistola.Nombre = "Pistola:Pew-Pew";
        pistola.Precio = 9999f;

        // mostrar en la consola la información de cada producto
        Debug.Log(espada.Nombre + ": " + espada.Precio + " monedas");
        Debug.Log(escudo.Nombre + ": " + escudo.Precio + " monedas ");
        Debug.Log(pistola.Nombre + ": " + pistola.Precio + " monedas");
    }
}
