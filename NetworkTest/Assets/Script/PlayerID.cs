using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerID : NetworkBehaviour
{
    [SyncVar] public string playerIdentification;
    private NetworkInstanceId playerNetID;


    public override void OnStartLocalPlayer()
    {

    }

    void Awake()
    {

    }
}
