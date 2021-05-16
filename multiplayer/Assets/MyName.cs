using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    private PhotonView PV;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
        if (PV.IsMine)
            gameObject.name = "LocalAvatar";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
