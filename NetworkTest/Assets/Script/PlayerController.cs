using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerController : NetworkBehaviour
{

    public Text hp;

    [SyncVar]public int health = 3;

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    
    void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }


    public void TakeDamage()
    {
        if (!isServer)
        {
            return;
        }

        health--;
        if (health == 0)
        {
            //endgame
        }

        //hp.text = "HP: " + health.ToString();

        Debug.Log("damag");
    }
}


/* save
 public GameObject winObj;
    public GameObject loseObj;

    [SyncVar (hook = "CmdOnChangeWin")] public bool winner;

    public float speed;

    private Rigidbody rb;
    public bool jugando = true;
    public bool localWin = false;


    void Start()
    {
        jugando = true;
        rb = GetComponent<Rigidbody>();
    }

    public void win(bool _winner)
    {
        winner = _winner;
    }

    

    [Command]
    public void CmdOnChangeWin(bool _winner)
    {
        winner = _winner;
    }

    private void OnTriggerEnter(Collider other)
    {
        jugando = false;
        CmdOnChangeWin(true);
        
        localWin = true;
    }

    

    void FixedUpdate()
    {
        if(!isLocalPlayer)
        {
            return;
        }


        if (jugando)
        {
            //float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        } else if (!jugando && localWin)
        {
            winObj.SetActive(true);
        }     else if (!jugando && !localWin)
        {
            loseObj.SetActive(true);
        }


    */
