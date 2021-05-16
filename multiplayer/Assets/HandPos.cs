using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPos : MonoBehaviour
{
    private PhotonView PV;
    Transform tracker;
    // Start is called before the first frame update
    void Start()
    {
        PV=GetComponent<PhotonView>();
        if (PV.IsMine)
         tracker = GameObject.Find("VRBrowserLHand").transform;
        //if (teacher) tracker = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (PV.IsMine)
        {
            transform.position = tracker.position;
            transform.rotation = tracker.rotation;
        }
    }
}
