using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer player;
    public Color color;

    public void assignColor()
    {
        player.material.SetColor("_Color", color);
        SingletonColor.colorJugador = color;
    }

    private void Start()
    {
        player.material.SetColor("_Color", SingletonColor.colorJugador);
    }
}
