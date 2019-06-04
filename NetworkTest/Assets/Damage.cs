using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    PlayerController playerController = new PlayerController();

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "P1_bar")
        {
            Debug.Log("dañop1");
        } else if (other.name == "P2_bar")
        {
            Debug.Log("dañop2");
        }


        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
